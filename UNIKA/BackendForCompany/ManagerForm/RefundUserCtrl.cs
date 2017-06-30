using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PayPal.Api;
using System.Resources;
using BackendClassLibrary.DataAccess;
using BackendClassLibrary.Data;
using MetroFramework.Controls;

namespace BackendForCompany.ManagerForm
{
    public partial class RefundUserCtrl : MetroUserControl
    {
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(RefundUserCtrl).Assembly);
        private MySqlConnection conn = Database.getConnection();

        private OrderDA oda = new OrderDA();
        private OrderLineDA olda = new OrderLineDA();

        private string staffID;

        private APIContext apiContext = null;

        public RefundUserCtrl(string staffID)
        {
            InitializeComponent();

            this.staffID = staffID;

            try
            {
                apiContext = PayPalAPI.getApiContext();
            }
            catch (PayPal.ConnectionException)
            {
                displayOrderPanel.Visible = false;
                failConnectPayPalMsg.Visible = true;
            }

            notRedundedStartDateTime.MaxDate = DateTime.Now.Date.AddDays(-1);
            notRedundedStartDateTime.Value = notRedundedStartDateTime.MaxDate;
            notRedundedEndDateTime.MinDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            notRedundedEndDateTime.Value = notRedundedEndDateTime.MinDate;

            paypalRefundedStartDateTime.MaxDate = DateTime.Now.Date.AddDays(-1);
            paypalRefundedStartDateTime.Value = paypalRefundedStartDateTime.MaxDate;
            paypalRefundedEndDateTime.MinDate = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
            paypalRefundedEndDateTime.Value = paypalRefundedEndDateTime.MinDate;
        }

        private double getOrdetTotal(string orderID)
        {
            double total = 0;

            OrderLine packageOl = olda.getPackageOrderLine(orderID, Language.getLanguageCode(), conn);
            if (!string.IsNullOrEmpty(packageOl.getProductID()))
            {
                total += ((packageOl.getDiscount() != null) ? packageOl.getUnitPrice() * (0.01 * (100 - packageOl.getDiscount())) : packageOl.getUnitPrice()).Value;
            }

            OrderLine bottleOl = olda.getBottleOrderLine(orderID, Language.getLanguageCode(), conn);
            if (!string.IsNullOrEmpty(bottleOl.getProductID()))
            {
                total += ((bottleOl.getDiscount() != null) ? bottleOl.getUnitPrice() * (0.01 * (100 - bottleOl.getDiscount())) : bottleOl.getUnitPrice()).Value;
            }

            List<OrderLine> perfumeOlList = olda.getPerfumeOrderLine(orderID, Language.getLanguageCode(), conn);
            foreach (OrderLine perfumeOl in perfumeOlList)
            {
                total += ((perfumeOl.getDiscount() != null) ? (perfumeOl.getUnitPrice() * (0.01 * (100 - perfumeOl.getDiscount()))) * perfumeOl.getQty() : perfumeOl.getUnitPrice() * perfumeOl.getQty()).Value;
            }

            return total;
        }

        private void notRedundedDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (((MetroDateTime)sender).Name == "notRedundedStartDateTime")
            {
                notRedundedEndDateTime.MinDate = notRedundedStartDateTime.Value.Date.AddDays(2).AddMilliseconds(-1);
                notRedundedStartDateTime.Value = notRedundedStartDateTime.Value.Date;
            }
            else if (((MetroDateTime)sender).Name == "notRedundedEndDateTime")
            {
                notRedundedStartDateTime.MaxDate = notRedundedEndDateTime.Value.Date.AddDays(-1);
                notRedundedEndDateTime.Value = notRedundedEndDateTime.Value.Date.AddDays(1).AddMilliseconds(-1);
            }
        }

        private void getNonRefundDetailButton_Click(object sender, EventArgs e)
        {

            displayOrderPanel.Enabled = false;
            displayOrderPanel.UseWaitCursor = true;

            paypalNonRefundDataGridView.Rows.Clear();
            paypalNonRefundDataGridView.Refresh();

            List<BackendClassLibrary.Data.Order> allOrders = oda.getAllOrders(conn);
            foreach (BackendClassLibrary.Data.Order order in allOrders)
            {
                Application.DoEvents();

                if (order.getOrderDate()>=notRedundedStartDateTime.Value && order.getOrderDate() <= notRedundedEndDateTime.Value)
                {
                    double total = getOrdetTotal(order.getOrderID());

                    if (!string.IsNullOrWhiteSpace(order.getPayPalPaymentID()))
                    {
                        try
                        {
                            Payment payment = Payment.Get(apiContext, order.getPayPalPaymentID());
                            if (payment.state.Equals("approved"))
                            {
                                List<RelatedResources> relatedResources = payment.transactions.ElementAt(0).related_resources;
                                Sale sale = relatedResources.ElementAt(0).sale;
                                if (sale.state.Equals("completed") && !sale.state.Equals("refunded") && !sale.state.Equals("partially_refunded"))
                                {
                                    paypalNonRefundDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), Convert.ToDateTime(sale.create_time).ToLongDateString(), rs.GetString("paidText"), rs.GetString("hkdText") + total);
                                }
                            }
                            else
                            {
                                paypalNonRefundDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), rs.GetString("naText"), rs.GetString("unpaidText"), rs.GetString("hkdText") + total);
                            }
                        }
                        catch (PayPal.HttpException ex)
                        {
                            if (!ex.StatusCode.ToString().Equals("NotFound"))
                            {
                                paypalNonRefundDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), rs.GetString("naText"), rs.GetString("failGetPaymentStatusMsg"), rs.GetString("hkdText") + total);
                            }
                            else
                            {
                                paypalNonRefundDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), rs.GetString("naText"), rs.GetString("unpaidText"), rs.GetString("hkdText") + total);
                            }

                        }
                        catch (PayPal.ConnectionException)
                        {
                            paypalNonRefundDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), rs.GetString("naText"), rs.GetString("failGetPaymentStatusMsg"), rs.GetString("hkdText") + total);
                        }

                    }
                    else
                    {
                        paypalNonRefundDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), rs.GetString("naText"), rs.GetString("unpaidText"), rs.GetString("hkdText") + total);
                    }

                }

            }

            paypalNonRefundDataGridView.ClearSelection();

            displayOrderPanel.UseWaitCursor = false;
            displayOrderPanel.Enabled = true;
        }

        private void paypalNonRefundDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                paypalRefundedDataGridView.ClearSelection();
                showOrderDetail(paypalNonRefundDataGridView.Rows[e.RowIndex].Cells["nonRefundOrderIDColumn"].Value.ToString());

            }
        }

        private void paypalRefundedDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (((MetroDateTime)sender).Name == "paypalRefundedStartDateTime")
            {
                paypalRefundedEndDateTime.MinDate = paypalRefundedStartDateTime.Value.Date.AddDays(2).AddMilliseconds(-1);
                paypalRefundedStartDateTime.Value = paypalRefundedStartDateTime.Value.Date;
            }
            else if (((MetroDateTime)sender).Name == "paypalRefundedEndDateTime")
            {
                paypalRefundedStartDateTime.MaxDate = paypalRefundedEndDateTime.Value.Date.AddDays(-1);
                paypalRefundedEndDateTime.Value = paypalRefundedEndDateTime.Value.Date.AddDays(1).AddMilliseconds(-1);
            }
        }

        private void getRefundedDetailButton_Click(object sender, EventArgs e)
        {

            displayOrderPanel.Enabled = false;
            displayOrderPanel.UseWaitCursor = true;

            paypalRefundedDataGridView.Rows.Clear();
            paypalRefundedDataGridView.Refresh();

            List<BackendClassLibrary.Data.Order> allOrders = oda.getAllOrders(conn);
            foreach (BackendClassLibrary.Data.Order order in allOrders)
            {
                if (order.getOrderDate() >= paypalRefundedStartDateTime.Value && order.getOrderDate() <= paypalRefundedEndDateTime.Value)
                {

                    double total = getOrdetTotal(order.getOrderID());

                    if (!string.IsNullOrWhiteSpace(order.getPayPalPaymentID()))
                    {
                        try
                        {
                            Payment payment = Payment.Get(apiContext, order.getPayPalPaymentID());
                            if (payment.state.Equals("approved"))
                            {
                                List<RelatedResources> relatedResources = payment.transactions.ElementAt(0).related_resources;
                                Sale sale = relatedResources.ElementAt(0).sale;
                                if (sale.state.Equals("refunded") || sale.state.Equals("partially_refunded"))
                                {
                                    Refund refund = relatedResources.ElementAt(1).refund;
                                    paypalRefundedDataGridView.Rows.Add(order.getOrderID(), order.getOrderDate(), Convert.ToDateTime(sale.create_time).ToLongDateString(), rs.GetString("hkdText") + total, Convert.ToDateTime(refund.create_time), rs.GetString("hkdText") + refund.amount.total);

                                }
                            }
                        }
                        catch (PayPal.HttpException ex)
                        {
                            if (!ex.StatusCode.ToString().Equals("NotFound"))
                            {
                                MessageBox.Show(failConnectPayPalMsg.Text, rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show(failConnectPayPalMsg.Text, rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                    }

                }
            }
            
            paypalRefundedDataGridView.ClearSelection();

            displayOrderPanel.UseWaitCursor = false;
            displayOrderPanel.Enabled = true;
        }

        private void paypalRefundedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex>=0)
            {
                paypalNonRefundDataGridView.ClearSelection();
                showOrderDetail(paypalRefundedDataGridView.Rows[e.RowIndex].Cells["refundOrderIDColumn"].Value.ToString());
            }
        }


        private void barCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            List<BackendClassLibrary.Data.Order> allOrders = oda.getAllOrders(conn);
            foreach (BackendClassLibrary.Data.Order order in allOrders)
            {
                if (order.getBarCode().Equals(barCodeTextBox.Text))
                {
                    showOrderDetail(order.getOrderID());
                    break;
                }
            }
        }

        public void showOrderDetail(string orderID)
        {
            string paymentStatus = null;
            string paymentDate = null;
            string refundedAmount = null;
            string refundedDate = null;
            BackendClassLibrary.Data.Order orderDetail = oda.getOneOrderByID(orderID, conn);
            try
            {
                if (!string.IsNullOrEmpty(orderDetail.getPayPalPaymentID()))
                {
                    Payment payment = Payment.Get(apiContext, orderDetail.getPayPalPaymentID());
                    if (payment.state.Equals("approved"))
                    {
                        List<RelatedResources> relatedResources = payment.transactions.ElementAt(0).related_resources;
                        Sale sale = relatedResources.ElementAt(0).sale;
                        if (sale.state.Equals("completed"))
                        {
                            paymentStatus = rs.GetString("paidText");
                            paymentDate = sale.create_time;
                        }
                        else if (sale.state.Equals("refunded") || sale.state.Equals("partially_refunded"))
                        {
                            Refund refund = relatedResources.ElementAt(1).refund;
                            paymentStatus = rs.GetString("refundedText");
                            paymentDate = sale.create_time;
                            refundedAmount = rs.GetString("hkdText") + refund.amount.total;
                            refundedDate = refund.create_time;
                        }

                    }
                    else
                    {
                        paymentStatus = rs.GetString("unpaidText");
                    }
                }
                else
                {
                    paymentStatus = rs.GetString("unpaidText");
                }

            }
            catch (PayPal.HttpException ex)
            {
                if (!ex.StatusCode.ToString().Equals("NotFound"))
                {
                    paymentStatus = rs.GetString("failGetPaymentStatusMsg");
                }
                else
                {
                    paymentStatus = rs.GetString("unpaidText");
                }

            }
            catch (PayPal.ConnectionException)
            {
                paymentStatus = rs.GetString("failGetPaymentStatusMsg");
            }
            showOrderIdLabel.Text = orderDetail.getOrderID();
            showOrderDateLabel.Text = orderDetail.getOrderDate().Date.ToLongDateString();
            showNameLabel.Text = orderDetail.getCustName();
            showAddressLabel.Text = orderDetail.getCustAddress();
            showEmailLabel.Text = orderDetail.getCustEmail();
            showMobileNoLabel.Text = orderDetail.getCustMobilePhoneNo();
            showApproveDateLabel.Text = (orderDetail.getApprovedDate() == null) ? rs.GetString("naText") : orderDetail.getApprovedDate().Value.Date.ToLongDateString();
            barCodeShowLabel.Text = orderDetail.getBarCode();
            if (orderDetail.getApprovedDate() != null)
                showApproveStatusLabel.Text = "(" + ((orderDetail.getRejected()) ? rs.GetString("rejectedText") : rs.GetString("apporvedBy1Text") + orderDetail.getApprovedBy() + rs.GetString("apporvedBy2Text")) + ")";
            else
                showApproveStatusLabel.Text = " ";
            showPayDateLabel.Text = (paymentDate == null) ? rs.GetString("naText") : Convert.ToDateTime(paymentDate).Date.ToLongDateString();
            showPaymentStatusLabel.Text = "(" + paymentStatus + ")";
            if (refundedDate != null)
            {
                doRefundButton.Enabled = false;
                showRefundDateLabel.Text = Convert.ToDateTime(refundedDate).Date.ToLongDateString();
                showRefundedAmountLabel.Text = refundedAmount;
                refundDateLabel.Visible = true;
                innerPanel4.Visible = true;
            }
            else
            {
                if (refundedDate == null && paymentDate != null)
                    doRefundButton.Enabled = true;
                else
                    doRefundButton.Enabled = false;

                refundDateLabel.Visible = false;
                innerPanel4.Visible = false;
            }

            OrderLine packageOl = olda.getPackageOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);
            double packageSubTotal = 0;
            if (!string.IsNullOrEmpty(packageOl.getProductID()))
            {
                showPackageIdLabel.Text = packageOl.getProductID();
                showPackageNameLabel.Text = packageOl.getProductName();
                showPackageUnitPriceLabel.Text = rs.GetString("hkdText") + packageOl.getUnitPrice().ToString();
                showPackageDiscountLabel.Text = (packageOl.getDiscount() != null) ? packageOl.getDiscount().ToString() + "% OFF" : "";
                packageSubTotal = ((packageOl.getDiscount() != null) ? packageOl.getUnitPrice() * (0.01 * (100 - packageOl.getDiscount())) : packageOl.getUnitPrice()).Value;
                showPackageSubTotalLabel.Text = rs.GetString("hkdText") + packageSubTotal.ToString();
            }
            else
            {
                showPackageIdLabel.Text = " ";
                showPackageNameLabel.Text = " ";
                showPackageUnitPriceLabel.Text = " ";
                showPackageDiscountLabel.Text = " ";
                showPackageSubTotalLabel.Text = " ";
            }

            OrderLine bottleOl = olda.getBottleOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);
            double bottleSubTotal = 0;
            if (!string.IsNullOrEmpty(bottleOl.getProductID()))
            {
                showBottleIdLabel.Text = bottleOl.getProductID();
                showBottleNameLabel.Text = bottleOl.getProductName();
                showBottleCapacityLabel.Text = bottleOl.getBottleCapacity().ToString() + " " + rs.GetString("mlText");
                showBottleUnitPriceLabel.Text = rs.GetString("hkdText") + bottleOl.getUnitPrice().ToString();
                showBottleDiscountLabel.Text = (bottleOl.getDiscount() != null) ? bottleOl.getDiscount().ToString() + "% OFF" : "";
                bottleSubTotal = ((bottleOl.getDiscount() != null) ? bottleOl.getUnitPrice() * (0.01 * (100 - bottleOl.getDiscount())) : bottleOl.getUnitPrice()).Value;
                showBottleSubTotalLabel.Text = rs.GetString("hkdText") + bottleSubTotal.ToString();
            }
            else
            {
                showBottleIdLabel.Text = " ";
                showBottleNameLabel.Text = " ";
                showBottleCapacityLabel.Text = " ";
                showBottleUnitPriceLabel.Text = " ";
                showBottleDiscountLabel.Text = " ";
                showBottleSubTotalLabel.Text = " ";
            }

            List<OrderLine> perfumeOlList = olda.getPerfumeOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);

            double perfumeSubTotal0 = 0;
            if (perfumeOlList.Count > 0)
            {
                showPerfumeId0Label.Text = perfumeOlList.ElementAt(0).getProductID();
                showPerfumeName0Label.Text = perfumeOlList.ElementAt(0).getProductName();
                showPerfumeUnitPrice0Label.Text = rs.GetString("hkdText") + perfumeOlList.ElementAt(0).getUnitPrice().ToString();
                showPerfumeDiscount0Label.Text = (perfumeOlList.ElementAt(0).getDiscount() != null) ? perfumeOlList.ElementAt(0).getDiscount().ToString() + "% OFF" : "";
                showPerfumeNote0Label.Text = rs.GetString(perfumeOlList.ElementAt(0).getNote() + "Text");
                showPerfumeQty0Label.Text = perfumeOlList.ElementAt(0).getQty().ToString();
                perfumeSubTotal0 = ((perfumeOlList.ElementAt(0).getDiscount() != null) ? (perfumeOlList.ElementAt(0).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(0).getDiscount()))) * perfumeOlList.ElementAt(0).getQty() : perfumeOlList.ElementAt(0).getUnitPrice() * perfumeOlList.ElementAt(0).getQty()).Value;
                showPerfumeSubTotal0Label.Text = rs.GetString("hkdText") + perfumeSubTotal0.ToString();
            }
            else
            {
                showPerfumeId0Label.Text = " ";
                showPerfumeName0Label.Text = " ";
                showPerfumeUnitPrice0Label.Text = " ";
                showPerfumeDiscount0Label.Text = " ";
                showPerfumeNote0Label.Text = " ";
                showPerfumeQty0Label.Text = " ";
                showPerfumeSubTotal0Label.Text = " ";
            }

            double perfumeSubTotal1 = 0;
            if (perfumeOlList.Count > 1)
            {
                showPerfumeId1Label.Text = perfumeOlList.ElementAt(1).getProductID();
                showPerfumeName1Label.Text = perfumeOlList.ElementAt(1).getProductName();
                showPerfumeUnitPrice1Label.Text = rs.GetString("hkdText") + perfumeOlList.ElementAt(1).getUnitPrice().ToString();
                showPerfumeDiscount1Label.Text = (perfumeOlList.ElementAt(1).getDiscount() != null) ? perfumeOlList.ElementAt(1).getDiscount().ToString() + "% OFF" : "";
                showPerfumeNote1Label.Text = rs.GetString(perfumeOlList.ElementAt(1).getNote() + "Text");
                showPerfumeQty1Label.Text = perfumeOlList.ElementAt(1).getQty().ToString();
                perfumeSubTotal1 = ((perfumeOlList.ElementAt(1).getDiscount() != null) ? (perfumeOlList.ElementAt(1).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(1).getDiscount()))) * perfumeOlList.ElementAt(1).getQty() : perfumeOlList.ElementAt(1).getUnitPrice() * perfumeOlList.ElementAt(1).getQty()).Value;
                showPerfumeSubTotal1Label.Text = rs.GetString("hkdText") + perfumeSubTotal1.ToString();
            }
            else
            {
                showPerfumeId1Label.Text = " ";
                showPerfumeName1Label.Text = " ";
                showPerfumeUnitPrice1Label.Text = " ";
                showPerfumeDiscount1Label.Text = " ";
                showPerfumeNote1Label.Text = " ";
                showPerfumeQty1Label.Text = " ";
                showPerfumeSubTotal1Label.Text = " ";
            }

            double perfumeSubTotal2 = 0;
            if (perfumeOlList.Count > 2)
            {
                showPerfumeId2Label.Text = perfumeOlList.ElementAt(2).getProductID();
                showPerfumeName2Label.Text = perfumeOlList.ElementAt(2).getProductName();
                showPerfumeUnitPrice2Label.Text = rs.GetString("hkdText") + perfumeOlList.ElementAt(2).getUnitPrice().ToString();
                showPerfumeDiscount2Label.Text = (perfumeOlList.ElementAt(2).getDiscount() != null) ? perfumeOlList.ElementAt(2).getDiscount().ToString() + "% OFF" : "";
                showPerfumeNote2Label.Text = rs.GetString(perfumeOlList.ElementAt(2).getNote() + "Text");
                showPerfumeQty2Label.Text = perfumeOlList.ElementAt(2).getQty().ToString();
                perfumeSubTotal2 = ((perfumeOlList.ElementAt(2).getDiscount() != null) ? (perfumeOlList.ElementAt(2).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(2).getDiscount()))) * perfumeOlList.ElementAt(2).getQty() : perfumeOlList.ElementAt(2).getUnitPrice() * perfumeOlList.ElementAt(2).getQty()).Value;
                showPerfumeSubTotal2Label.Text = rs.GetString("hkdText") + ((perfumeOlList.ElementAt(2).getDiscount() != null) ? ((perfumeOlList.ElementAt(2).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(2).getDiscount()))) * perfumeOlList.ElementAt(2).getQty()).ToString() : (perfumeOlList.ElementAt(2).getUnitPrice() * perfumeOlList.ElementAt(2).getQty()).ToString());
            }
            else
            {
                showPerfumeId2Label.Text = " ";
                showPerfumeName2Label.Text = " ";
                showPerfumeUnitPrice2Label.Text = " ";
                showPerfumeDiscount2Label.Text = " ";
                showPerfumeNote2Label.Text = " ";
                showPerfumeQty2Label.Text = " ";
                showPerfumeSubTotal2Label.Text = " ";
            }

            double perfumeSubTotal3 = 0;
            if (perfumeOlList.Count > 3)
            {
                showPerfumeId3Label.Text = perfumeOlList.ElementAt(3).getProductID();
                showPerfumeName3Label.Text = perfumeOlList.ElementAt(3).getProductName();
                showPerfumeUnitPrice3Label.Text = rs.GetString("hkdText") + perfumeOlList.ElementAt(3).getUnitPrice().ToString();
                showPerfumeDiscount3Label.Text = (perfumeOlList.ElementAt(3).getDiscount() != null) ? perfumeOlList.ElementAt(3).getDiscount().ToString() + "% OFF" : "";
                showPerfumeNote3Label.Text = rs.GetString(perfumeOlList.ElementAt(3).getNote() + "Text");
                showPerfumeQty3Label.Text = perfumeOlList.ElementAt(3).getQty().ToString();
                perfumeSubTotal3 = ((perfumeOlList.ElementAt(3).getDiscount() != null) ? (perfumeOlList.ElementAt(3).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(3).getDiscount()))) * perfumeOlList.ElementAt(3).getQty() : perfumeOlList.ElementAt(3).getUnitPrice() * perfumeOlList.ElementAt(3).getQty()).Value;
                showPerfumeSubTotal3Label.Text = rs.GetString("hkdText") + perfumeSubTotal3.ToString();
            }
            else
            {
                showPerfumeId3Label.Text = " ";
                showPerfumeName3Label.Text = " ";
                showPerfumeUnitPrice3Label.Text = " ";
                showPerfumeDiscount3Label.Text = " ";
                showPerfumeNote3Label.Text = " ";
                showPerfumeQty3Label.Text = " ";
                showPerfumeSubTotal3Label.Text = " ";
            }

            double perfumeSubTotal4 = 0;
            if (perfumeOlList.Count > 4)
            {
                showPerfumeId4Label.Text = perfumeOlList.ElementAt(4).getProductID();
                showPerfumeName4Label.Text = perfumeOlList.ElementAt(4).getProductName();
                showPerfumeUnitPrice4Label.Text = rs.GetString("hkdText") + perfumeOlList.ElementAt(4).getUnitPrice().ToString();
                showPerfumeDiscount4Label.Text = (perfumeOlList.ElementAt(4).getDiscount() != null) ? perfumeOlList.ElementAt(4).getDiscount().ToString() + "% OFF" : "";
                showPerfumeNote4Label.Text = rs.GetString(perfumeOlList.ElementAt(4).getNote() + "Text");
                showPerfumeQty4Label.Text = perfumeOlList.ElementAt(4).getQty().ToString();
                perfumeSubTotal4 = ((perfumeOlList.ElementAt(4).getDiscount() != null) ? (perfumeOlList.ElementAt(4).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(4).getDiscount()))) * perfumeOlList.ElementAt(4).getQty() : perfumeOlList.ElementAt(4).getUnitPrice() * perfumeOlList.ElementAt(4).getQty()).Value;
                showPerfumeSubTotal4Label.Text = rs.GetString("hkdText") + perfumeSubTotal4.ToString();
            }
            else
            {
                showPerfumeId4Label.Text = " ";
                showPerfumeName4Label.Text = " ";
                showPerfumeUnitPrice4Label.Text = " ";
                showPerfumeDiscount4Label.Text = " ";
                showPerfumeNote4Label.Text = " ";
                showPerfumeQty4Label.Text = " ";
                showPerfumeSubTotal4Label.Text = " ";
            }

            double perfumeSubTotal5 = 0;
            if (perfumeOlList.Count > 5)
            {
                showPerfumeId5Label.Text = perfumeOlList.ElementAt(5).getProductID();
                showPerfumeName5Label.Text = perfumeOlList.ElementAt(5).getProductName();
                showPerfumeUnitPrice5Label.Text = rs.GetString("hkdText") + perfumeOlList.ElementAt(5).getUnitPrice().ToString();
                showPerfumeDiscount5Label.Text = (perfumeOlList.ElementAt(5).getDiscount() != null) ? perfumeOlList.ElementAt(5).getDiscount().ToString() + "% OFF" : "";
                showPerfumeNote5Label.Text = rs.GetString(perfumeOlList.ElementAt(5).getNote() + "Text");
                showPerfumeQty5Label.Text = perfumeOlList.ElementAt(5).getQty().ToString();
                perfumeSubTotal5 = ((perfumeOlList.ElementAt(5).getDiscount() != null) ? (perfumeOlList.ElementAt(5).getUnitPrice() * (0.01 * (100 - perfumeOlList.ElementAt(5).getDiscount()))) * perfumeOlList.ElementAt(5).getQty() : perfumeOlList.ElementAt(5).getUnitPrice() * perfumeOlList.ElementAt(5).getQty()).Value;
                showPerfumeSubTotal5Label.Text = rs.GetString("hkdText") + perfumeSubTotal5.ToString();
            }
            else
            {
                showPerfumeId5Label.Text = " ";
                showPerfumeName5Label.Text = " ";
                showPerfumeUnitPrice5Label.Text = " ";
                showPerfumeDiscount5Label.Text = " ";
                showPerfumeNote5Label.Text = " ";
                showPerfumeQty5Label.Text = " ";
                showPerfumeSubTotal5Label.Text = " ";
            }

            double orderTotal = packageSubTotal + bottleSubTotal + perfumeSubTotal0 + perfumeSubTotal1 + perfumeSubTotal2 + perfumeSubTotal3 + perfumeSubTotal4 + perfumeSubTotal5;
            showOrderTotalLabel.Text = rs.GetString("hkdText") + orderTotal.ToString();

            resetButton.Enabled = true;

        }

        private void doRefundButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(rs.GetString("refundYesNoMsg"), rs.GetString("confirmationText"), MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                displayOrderPanel.Enabled = false;
                displayOrderPanel.UseWaitCursor = true;

                doRefundButton.Enabled = false;

                try
                {
                    BackendClassLibrary.Data.Order orderDetail = oda.getOneOrderByID(showOrderIdLabel.Text, conn);
                    if (!string.IsNullOrEmpty(orderDetail.getPayPalPaymentID()))
                    {
                        Payment payment = Payment.Get(apiContext, orderDetail.getPayPalPaymentID());
                        Sale sale = payment.transactions.ElementAt(0).related_resources.ElementAt(0).sale;
                        if (payment.state.Equals("approved") && !sale.state.Equals("refunded") && !sale.state.Equals("partially_refunded"))
                        {
                            string SaleId = sale.id;
                            string paidAmount = sale.amount.total;

                            Amount amount = new Amount()
                            {
                                currency = "HKD",
                                total = paidAmount
                            };

                            Refund refund = new Refund();
                            refund.amount = amount;

                            var response = sale.Refund(apiContext, refund);

                            if (orderDetail.getApprovedDate()==null)
                            {
                                orderDetail.setApprovedDate(DateTime.Now);
                                orderDetail.setRejected(true);
                                oda.update(orderDetail, conn);
                            }

                            showOrderDetail(orderDetail.getPayPalPaymentID());

                            MessageBox.Show(rs.GetString("amountRefundedMsg"));

                        }
                        else
                        {
                            MessageBox.Show(rs.GetString("failRefundMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(rs.GetString("failRefundMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show(rs.GetString("failRefundMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                displayOrderPanel.UseWaitCursor = false;
                displayOrderPanel.Enabled = true;

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            showOrderIdLabel.Text = " ";
            showOrderDateLabel.Text = " ";
            showNameLabel.Text = " ";
            showAddressLabel.Text = " ";
            showEmailLabel.Text = " ";
            showMobileNoLabel.Text = " ";
            showApproveDateLabel.Text = " ";
            barCodeShowLabel.Text = " ";
            showPayDateLabel.Text = " ";
            showPaymentStatusLabel.Text = " ";
            showApproveStatusLabel.Text = " ";

            showPackageIdLabel.Text = " ";
            showPackageNameLabel.Text = " ";
            showPackageUnitPriceLabel.Text = " ";
            showPackageDiscountLabel.Text = " ";
            showPackageSubTotalLabel.Text = " ";

            showBottleIdLabel.Text = " ";
            showBottleNameLabel.Text = " ";
            showBottleCapacityLabel.Text = " ";
            showBottleUnitPriceLabel.Text = " ";
            showBottleDiscountLabel.Text = " ";
            showBottleSubTotalLabel.Text = " ";

            showPerfumeId0Label.Text = " ";
            showPerfumeName0Label.Text = " ";
            showPerfumeUnitPrice0Label.Text = " ";
            showPerfumeDiscount0Label.Text = " ";
            showPerfumeNote0Label.Text = " ";
            showPerfumeQty0Label.Text = " ";
            showPerfumeSubTotal0Label.Text = " ";

            showPerfumeId1Label.Text = " ";
            showPerfumeName1Label.Text = " ";
            showPerfumeUnitPrice1Label.Text = " ";
            showPerfumeDiscount1Label.Text = " ";
            showPerfumeNote1Label.Text = " ";
            showPerfumeQty1Label.Text = " ";
            showPerfumeSubTotal1Label.Text = " ";

            showPerfumeId2Label.Text = " ";
            showPerfumeName2Label.Text = " ";
            showPerfumeUnitPrice2Label.Text = " ";
            showPerfumeDiscount2Label.Text = " ";
            showPerfumeNote2Label.Text = " ";
            showPerfumeQty2Label.Text = " ";
            showPerfumeSubTotal2Label.Text = " ";

            showPerfumeId3Label.Text = " ";
            showPerfumeName3Label.Text = " ";
            showPerfumeUnitPrice3Label.Text = " ";
            showPerfumeDiscount3Label.Text = " ";
            showPerfumeNote3Label.Text = " ";
            showPerfumeQty3Label.Text = " ";
            showPerfumeSubTotal3Label.Text = " ";

            showPerfumeId4Label.Text = " ";
            showPerfumeName4Label.Text = " ";
            showPerfumeUnitPrice4Label.Text = " ";
            showPerfumeDiscount4Label.Text = " ";
            showPerfumeNote4Label.Text = " ";
            showPerfumeQty4Label.Text = " ";
            showPerfumeSubTotal4Label.Text = " ";

            showPerfumeId5Label.Text = " ";
            showPerfumeName5Label.Text = " ";
            showPerfumeUnitPrice5Label.Text = " ";
            showPerfumeDiscount5Label.Text = " ";
            showPerfumeNote5Label.Text = " ";
            showPerfumeQty5Label.Text = " ";
            showPerfumeSubTotal5Label.Text = " ";

            refundDateLabel.Visible = false;
            innerPanel4.Visible = false;

            doRefundButton.Enabled = false;
            resetButton.Enabled = false;

            paypalNonRefundDataGridView.ClearSelection();
            paypalRefundedDataGridView.ClearSelection();
        }
    }
}
