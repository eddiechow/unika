using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using PayPal.Api;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace BackendForCompany.StaffForm
{
    public partial class ApproveRejectOrderUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForCompany.Properties.Resources", typeof(ApproveRejectOrderUserCtrl).Assembly);

        private APIContext apiContext = null;

        private ProductBottleDA pbda = new ProductBottleDA();
        private ProductPackageDA ppgda = new ProductPackageDA();
        private ProductPerfumeDA ppda = new ProductPerfumeDA();
        private OrderDA oda = new OrderDA();
        private BackendClassLibrary.Data.Order orderDetail = null;

        private OrderLineDA olda = new OrderLineDA();
        private OrderLine packageOl = null;
        private OrderLine bottleOl = null;
        private List<OrderLine> perfumeOlList = null;

        private string comboxCurrentSelectedPerfumeCategory = "";

        private double? orderTotal = null;

        private string staffID = null;

        public ApproveRejectOrderUserCtrl(string staffID)
        {
            this.staffID = staffID;

            InitializeComponent();

            setOrderTypeComboBox();
            setProductCategoriesComboBox();
            setPerfumeCategoriesComboBox();

            productCategoriesComboBox_SelectedIndexChanged(null, null);
            orderTypeComboBox_SelectedIndexChanged(null, null);
            try
            {
                apiContext = PayPalAPI.getApiContext();
            }
            catch (PayPal.ConnectionException)
            {
                displayOrderPanel.Visible = false;
                failConnectPayPalMsg.Visible = true;
            }
            
        }

        public void setOrderTypeComboBox()
        {
            //Create a Categories list
            BindingList<KeyValuePair<string, string>> list = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            orderTypeComboBox.DataSource = null;
            orderTypeComboBox.Items.Clear();

            //Bind the combobox
            orderTypeComboBox.DisplayMember = "Key";
            orderTypeComboBox.ValueMember = "Value";
            orderTypeComboBox.DataSource = list;

            list.Add(new KeyValuePair<string, string>(rs.GetString("newOrderText"), "newOrder"));
            list.Add(new KeyValuePair<string, string>(rs.GetString("approvalOrderText"), "approvalOrder"));
            list.Add(new KeyValuePair<string, string>(rs.GetString("rejectOrderText"), "rejectOrder"));

            orderTypeComboBox.SelectedValue = "newOrder";
        }

        public void setProductCategoriesComboBox()
        {
            //Create a Categories list
            BindingList<KeyValuePair<string, string>> categoriesList = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            productCategoriesComboBox.DataSource = null;
            productCategoriesComboBox.Items.Clear();

            //Bind the combobox
            productCategoriesComboBox.DisplayMember = "Key";
            productCategoriesComboBox.ValueMember = "Value";
            productCategoriesComboBox.DataSource = categoriesList;

            //Set Product Categories
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("perfumeText"), "perfume"));
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("bottleText"), "bottle"));
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("packageText"), "package"));

            productCategoriesComboBox.SelectedValue = "perfume";
        }

        public void setPerfumeCategoriesComboBox()
        {
            //Create a Categories list
            BindingList<KeyValuePair<string, string>> categoriesList = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            perfumeCategoriesComboBox.DataSource = null;
            perfumeCategoriesComboBox.Items.Clear();

            //Bind the combobox
            perfumeCategoriesComboBox.DisplayMember = "Key";
            perfumeCategoriesComboBox.ValueMember = "Value";
            perfumeCategoriesComboBox.DataSource = categoriesList;

            //Get Categories form Database
            categoriesList.Add(new KeyValuePair<string, string>(rs.GetString("allText"), ""));

            Dictionary<string, string> categoriesMap = ppda.getAllCategories(Language.getLanguageCode(), conn);
            foreach (var pair in categoriesMap)
                categoriesList.Add(new KeyValuePair<string, string>(pair.Key, pair.Value));

            perfumeCategoriesComboBox.SelectedValue = "";
        }

        public void showOrderDetail(string orderID)
        {
            receiptButton.Enabled = false;
            invoiceButton.Enabled = false;

            refundButton.Visible = false;
            string paymentStatus = null;
            string paymentDate = null;
            string refundedAmount = null;
            string refundedDate = null;
            bool disableApprovalButton = false;
            orderDetail = null;
            orderDetail = oda.getOneOrderByID(orderID, conn);
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
                        else if(sale.state.Equals("refunded") || sale.state.Equals("partially_refunded"))
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
                        disableApprovalButton = true;
                    }
                }
                else
                {
                    paymentStatus = rs.GetString("unpaidText");
                    disableApprovalButton = true;
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
                disableApprovalButton = true;

            }
            catch (PayPal.ConnectionException)
            {
                paymentStatus = rs.GetString("failGetPaymentStatusMsg");
                disableApprovalButton = true;
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

            if (!orderDetail.getRejected() && orderDetail.getApprovedDate()!=null)
            {
                receiptButton.Enabled = true;
                invoiceButton.Enabled = true;
            }
            showPayDateLabel.Text = (paymentDate == null) ? rs.GetString("naText") : Convert.ToDateTime(paymentDate).Date.ToLongDateString();
            showPaymentStatusLabel.Text = "(" + paymentStatus + ")";
            if (refundedDate != null)
            {
                showRefundDateLabel.Text = Convert.ToDateTime(refundedDate).Date.ToLongDateString();
                showRefundedAmountLabel.Text = refundedAmount;
                refundDateLabel.Visible = true;
                innerPanel4.Visible = true;
            }
            else
            {
                if(orderDetail.getRejected() && refundedDate == null && paymentDate != null)
                    refundButton.Visible = true;
                refundDateLabel.Visible = false;
                innerPanel4.Visible = false;
            }

            packageOl = null;
            packageOl = olda.getPackageOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);
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

            bottleOl = null;
            bottleOl = olda.getBottleOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);
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

            perfumeOlList = null;
            perfumeOlList = olda.getPerfumeOrderLine(showOrderIdLabel.Text, Language.getLanguageCode(), conn);

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

            orderTotal = null;
            orderTotal = packageSubTotal + bottleSubTotal + perfumeSubTotal0 + perfumeSubTotal1 + perfumeSubTotal2 + perfumeSubTotal3 + perfumeSubTotal4 + perfumeSubTotal5;
            showOrderTotalLabel.Text = rs.GetString("hkdText") + orderTotal.Value.ToString();

            if (orderDetail.getApprovedDate() == null)
            {
                if(disableApprovalButton)
                    approvalButton.Enabled = false;
                else
                    approvalButton.Enabled = true;
                rejectButton.Enabled = true;
            }
            else
            {
                approvalButton.Enabled = false;
                rejectButton.Enabled = false;
            }
        }

        private void productCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productCategoriesComboBox.SelectedValue.Equals("perfume"))
            {
                perfumeCategoriesComboBox.SelectedValue = comboxCurrentSelectedPerfumeCategory;
                perfumeCategoryLabel.Enabled = true;
                perfumeCategoriesComboBox.Enabled = true;
                perfumeCategoriesComboBox_SelectedIndexChanged(null, null);
            }
            else
            {
                perfumeCategoriesComboBox.SelectedValue = "";
                perfumeCategoryLabel.Enabled = false;
                perfumeCategoriesComboBox.Enabled = false;

                productDataGridView.Rows.Clear();
                productDataGridView.Refresh();

                if (productCategoriesComboBox.SelectedValue.Equals("bottle"))
                {
                    List<Bottle> list = pbda.getAllProductBottles(Language.getLanguageCode(), conn);
                    foreach (Bottle bottle in list)
                        productDataGridView.Rows.Add(
                            bottle.getProductID(),
                            bottle.getProductName(),
                            bottle.getQtyInStock());
                }
                else if (productCategoriesComboBox.SelectedValue.Equals("package"))
                {
                    List<Package> list = ppgda.getAllProductPackages(Language.getLanguageCode(), conn);
                    foreach (Package package in list)
                        productDataGridView.Rows.Add(
                            package.getProductID(),
                            package.getProductName(),
                            package.getQtyInStock());
                }

                productDataGridView.ClearSelection();
            }

        }

        private void perfumeCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productCategoriesComboBox.SelectedValue.Equals("perfume"))
                comboxCurrentSelectedPerfumeCategory = (string)perfumeCategoriesComboBox.SelectedValue;

            productDataGridView.Rows.Clear();
            productDataGridView.Refresh();

            List<Perfume> list = ppda.getAllProductPerfume(Language.getLanguageCode(), conn);
            foreach (Perfume perfume in list)
                if (perfumeCategoriesComboBox.SelectedValue.Equals("") || perfume.getCategory().Equals(perfumeCategoriesComboBox.Text))
                {
                    productDataGridView.Rows.Add(
                        perfume.getProductID(),
                        perfume.getProductName(),
                        perfume.getQtyInStock());
                }

            productDataGridView.ClearSelection();
        }

        private void orderTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(orderTypeComboBox.Text))
            {
                orderDataGridView.Rows.Clear();
                orderDataGridView.Refresh();

                List<BackendClassLibrary.Data.Order> list = oda.getAllOrders(conn);
                foreach (BackendClassLibrary.Data.Order order in list)
                    if ((orderTypeComboBox.SelectedValue.Equals("newOrder") && order.getApprovedDate() == null) ||
                        (orderTypeComboBox.SelectedValue.Equals("approvalOrder") && order.getApprovedDate() != null && !order.getRejected() && order.getApprovedByEmpID().Equals(staffID)) ||
                        (orderTypeComboBox.SelectedValue.Equals("rejectOrder") && order.getApprovedDate() != null && order.getRejected()))
                    {
                        orderDataGridView.Rows.Add(
                            order.getOrderID(),
                            order.getOrderDate(),
                            order.getCustName());
                    }

                orderDataGridView.ClearSelection();
                foreach (DataGridViewRow row in orderDataGridView.Rows)
                {
                    if (showOrderIdLabel.Text.Equals(row.Cells["orderIdColumn"].Value.ToString()))
                        row.Selected = true;
                }
            }
            approvalButton.Enabled = false;
            rejectButton.Enabled = false;
        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                showOrderDetail(orderDataGridView.Rows[e.RowIndex].Cells["orderIdColumn"].Value.ToString());
            }
        }

        private void approvalButton_Click(object sender, EventArgs e)
        {
            bool qtyBelow50 = false;

            if (!qtyBelow50)
            {
                Package package = ppgda.getOneProductPackageByID(packageOl.getProductID(), Language.getLanguageCode(), conn);
                if (package.getQtyInStock()<1)
                    qtyBelow50 = true;
            }

            if (!qtyBelow50)
            {
                Bottle bottle = pbda.getOneProductBottleByID(bottleOl.getProductID(), Language.getLanguageCode(), conn);
                if (bottle.getQtyInStock() < 1)
                    qtyBelow50 = true;
            }

            if (!qtyBelow50)
            {
                foreach (OrderLine perfumeOl in perfumeOlList)
                {
                    Perfume perfume = ppda.getOneProductPerfumeByID(perfumeOl.getProductID(), Language.getLanguageCode(), conn);
                    if (perfume.getQtyInStock() < 50)
                    {
                        qtyBelow50 = true;
                        break;
                    }
                }
            }

            if (qtyBelow50)
            {
                rejectButton_Click(null, null);
            }
            else
            {
                Package package = ppgda.getOneProductPackageByID(packageOl.getProductID(), Language.getLanguageCode(), conn);
                package.setQtyInStock(package.getQtyInStock()-1);
                ppgda.update(package, conn);

                Bottle bottle = pbda.getOneProductBottleByID(bottleOl.getProductID(), Language.getLanguageCode(), conn);
                bottle.setQtyInStock(bottle.getQtyInStock() - 1);
                pbda.update(bottle, conn);

                foreach (OrderLine perfumeOl in perfumeOlList)
                {
                    Perfume perfume = ppda.getOneProductPerfumeByID(perfumeOl.getProductID(), Language.getLanguageCode(), conn);
                    perfume.setQtyInStock(perfume.getQtyInStock() - perfumeOl.getQty());
                    ppda.update(perfume, conn);
                }

                productCategoriesComboBox_SelectedIndexChanged(null, null);

                orderDetail.setApprovedDate(DateTime.Now.Date);
                orderDetail.setRejected(false);
                orderDetail.setApprovedByEmpID(staffID);

                if(oda.update(orderDetail, conn) > 0)
                {
                    MessageBox.Show(rs.GetString("orderApprovalMsg"));
                }
                else
                    MessageBox.Show(rs.GetString("failToUpdateMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            approvalButton.Enabled = false;
            rejectButton.Enabled = false;

            showOrderDetail(orderDetail.getOrderID());

            for (int i = orderDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (orderDataGridView.Rows[i].Cells["orderIdColumn"].Value.Equals(orderDetail.getOrderID()))
                {
                    orderDataGridView.Rows.Remove(orderDataGridView.Rows[i]);
                }
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            orderDetail.setApprovedDate(DateTime.Now.Date);
            orderDetail.setRejected(true);
            if (oda.update(orderDetail, conn) > 0)
            {
                MessageBox.Show(rs.GetString("orderRejectMsg"));
                refundButton_Click(null, null);
            }
            else
                MessageBox.Show(rs.GetString("failToUpdateMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            approvalButton.Enabled = false;
            rejectButton.Enabled = false;

            showOrderDetail(orderDetail.getOrderID().ToString());

            for (int i = orderDataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (orderDataGridView.Rows[i].Cells["orderIdColumn"].Value.Equals(orderDetail.getOrderID()))
                {
                    orderDataGridView.Rows.Remove(orderDataGridView.Rows[i]);
                }
            }
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            try
            {
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

                        MessageBox.Show(rs.GetString("amountRefundedMsg"));

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
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            if (!orderDetail.getRejected() && orderDetail.getApprovedDate() != null)
            {

                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);

                string locat = locat = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + showOrderIdLabel.Text + "INVOICE.pdf";
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(locat, FileMode.Create));

                doc.Open();

                //logo part
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("logo_small.png");
                logo.ScalePercent(10);
                logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);

                var invoice = new Phrase(new Chunk("INVOICE", boldFont));
                Paragraph para0 = new Paragraph(invoice);
                para0.Alignment = Element.ALIGN_CENTER;
                doc.Add(para0);

                var orderno = new Phrase(new Chunk("Order ID:" + showOrderIdLabel.Text, boldFont));
                Paragraph para = new Paragraph(orderno);
                para.Alignment = Element.ALIGN_LEFT;
                doc.Add(para);

                var date1 = new Phrase(new Chunk("Date:" + showOrderDateLabel.Text, boldFont));
                Paragraph para1 = new Paragraph(date1);
                para1.Alignment = Element.ALIGN_LEFT;
                doc.Add(para1);
                var billTo = new Phrase(new Chunk("Bill To:" + showNameLabel.Text, boldFont));
                Paragraph para2 = new Paragraph(billTo);
                para2.Alignment = Element.ALIGN_LEFT;
                doc.Add(para2);
                var address = new Phrase(new Chunk(showAddressLabel.Text, boldFont));
                Paragraph para3 = new Paragraph(address);
                para3.Alignment = Element.ALIGN_LEFT;
                doc.Add(para3);
                var sp = new Phrase(new Chunk(" ", boldFont));
                Paragraph para4 = new Paragraph(sp);
                para4.Alignment = Element.ALIGN_LEFT;
                doc.Add(para4);
                DataTable dt = new DataTable();

                dt.Columns.Add("Product ID");
                dt.Columns.Add("Product Name");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Amount(" + rs.GetString("hkdText") + ")");
                dt.Rows.Add(showPackageIdLabel.Text, showPackageNameLabel.Text, "1", showPackageSubTotalLabel.Text);
                dt.Rows.Add(showBottleIdLabel.Text, showBottleNameLabel.Text, "1", showBottleSubTotalLabel.Text);
                dt.Rows.Add(showPerfumeId0Label.Text, showPerfumeName0Label.Text, showPerfumeQty0Label.Text, showPerfumeSubTotal0Label.Text);
                dt.Rows.Add(showPerfumeId1Label.Text, showPerfumeName1Label.Text, showPerfumeQty1Label.Text, showPerfumeSubTotal1Label.Text);
                dt.Rows.Add(showPerfumeId2Label.Text, showPerfumeName2Label.Text, showPerfumeQty2Label.Text, showPerfumeSubTotal2Label.Text);
                if (showPerfumeId3Label.Text != null)
                {
                    dt.Rows.Add(showPerfumeId3Label.Text, showPerfumeName3Label.Text, showPerfumeQty3Label.Text, showPerfumeSubTotal3Label.Text);
                }
                if (showPerfumeId4Label.Text != null)
                {
                    dt.Rows.Add(showPerfumeId4Label.Text, showPerfumeName4Label.Text, showPerfumeQty4Label.Text, showPerfumeSubTotal4Label.Text);
                }
                if (showPerfumeId5Label.Text != null)
                {
                    dt.Rows.Add(showPerfumeId5Label.Text, showPerfumeName5Label.Text, showPerfumeQty5Label.Text, showPerfumeSubTotal5Label.Text);
                }
                dt.Rows.Add("", "", "Total", showOrderTotalLabel.Text);
                PdfPTable table = new PdfPTable(dt.Columns.Count);

                foreach (DataColumn c in dt.Columns)
                {
                    table.AddCell(new Phrase(c.ColumnName));
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (dt.Rows[i][j].ToString() != null)
                            table.AddCell(new Phrase(dt.Rows[i][j].ToString()));
                    }
                }

                doc.Add(table);


                doc.Close();
                MessageBox.Show(rs.GetString("invoiceGeneratedMsg"));
            }

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Properties.Settings setting = Properties.Settings.Default;
            if (!string.IsNullOrWhiteSpace(setting.receiptPrinter))
            {
                PrinterSettings ps = new PrinterSettings();
                ps.PrinterName = setting.receiptPrinter;
                printReceipt.PrinterSettings = ps;
                if (printReceipt.PrinterSettings.IsValid == true)
                {
                    if (!orderDetail.getRejected() && orderDetail.getApprovedDate() != null)
                    {
                        printReceipt.Print();
                    }
                }
                else
                {
                    MessageBox.Show(rs.GetString("nonSelectReceiptPrinterMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(rs.GetString("selectReceiptPrinterMsg"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReceiptPrinterSettingForm fm = new ReceiptPrinterSettingForm();
                fm.FormClosed += new FormClosedEventHandler(fm_Closed);
                fm.ShowDialog();
            }
        }

        private void fm_Closed(object sender, EventArgs e)
        {
            Properties.Settings setting = Properties.Settings.Default;
            if (!string.IsNullOrWhiteSpace(setting.receiptPrinter))
            {
                MessageBox.Show(rs.GetString("nonSelectReceiptPrinterMsg"), rs.GetString("errorText"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                receiptButton_Click(null, null);
            }
        }

        private void printReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {

            float x = 10.0F;
            float y = 5;
            float width = 195.0F; // max width I found through trial and error
            float height = 20.0F;
            System.Drawing.Font drawFontArial12Bold = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            System.Drawing.Font drawFontArial10Regular = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.
            StringFormat drawFormatCenter = new StringFormat();
            drawFormatCenter.Alignment = StringAlignment.Center;
            StringFormat drawFormatRight = new StringFormat(StringFormatFlags.DirectionRightToLeft);



            string date = string.Format("{0:f}", DateTime.Now);
            // Draw string to screen.
            string text = "      ";
            e.Graphics.DrawString("UNIKA", drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;


            e.Graphics.DrawString("   ", drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            x = 10;

            e.Graphics.DrawString(date, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;


            e.Graphics.DrawString("------------------------------------------------------", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            e.Graphics.DrawString(productGroupBox.Text + ": ", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;


            e.Graphics.DrawString(showPackageNameLabel.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            e.Graphics.DrawString(showPackageSubTotalLabel.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            e.Graphics.DrawString(showBottleNameLabel.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            e.Graphics.DrawString(showBottleSubTotalLabel.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            e.Graphics.DrawString(showPerfumeName0Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            e.Graphics.DrawString(showPerfumeSubTotal0Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            e.Graphics.DrawString(showPerfumeName1Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            e.Graphics.DrawString(showPerfumeSubTotal1Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            e.Graphics.DrawString(showPerfumeName2Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
            e.Graphics.DrawString(showPerfumeSubTotal2Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;


            if (!string.IsNullOrWhiteSpace(showPerfumeId3Label.Text))
            {
                e.Graphics.DrawString(showPerfumeName3Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
                e.Graphics.DrawString(showPerfumeSubTotal3Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            }

            if (!string.IsNullOrWhiteSpace(showPerfumeName4Label.Text))
            {
                e.Graphics.DrawString(showPerfumeName4Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
                e.Graphics.DrawString(showPerfumeSubTotal4Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            }

            if (!string.IsNullOrWhiteSpace(showPerfumeName5Label.Text))
            {
                e.Graphics.DrawString(showPerfumeName5Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
                e.Graphics.DrawString(showPerfumeSubTotal5Label.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            }
            else
            {
                e.Graphics.DrawString("------------------------------------------------------", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
                e.Graphics.DrawString("", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;


                e.Graphics.DrawString("   ", drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
                e.Graphics.DrawString(orderTotalLabel.Text + " " + showOrderTotalLabel.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

                e.Graphics.DrawString(barCodeShowLabel.Text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height));
                y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;
            }
        }
    }
}
