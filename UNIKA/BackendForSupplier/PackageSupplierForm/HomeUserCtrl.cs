using System.Collections.Generic;
using System.Linq;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using BackendClassLibrary.Data;
using BackendClassLibrary.DataAccess;
using System.Resources;
using System;

namespace BackendForSupplier.PackageSupplierForm
{
    public partial class HomeUserCtrl : MetroUserControl
    {
        private MySqlConnection conn = Database.getConnection();
        private ResourceManager rs = new ResourceManager("BackendForSupplier.Properties.Resources", typeof(HomeUserCtrl).Assembly);

        private Properties.Settings setting = Properties.Settings.Default;

        private string supplierID = null;

        public HomeUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;

            showLoginLog();
            showProfile();
            showStockAlert();
            showRecycleBinAlert();
        }

        private void showLoginLog()
        {
            SupplierLoginLogDA slda = new SupplierLoginLogDA();
            List<LoginLog> list = slda.searchLogs(null, null, supplierID, null, conn);
            for (int i = list.Count - 1; i >= 0; i--)
            {
                loginLogDataGridView.Rows.Add(
                        list.ElementAt(i).getTime(),
                        list.ElementAt(i).getStatus());
            }
        }

        private void showStockAlert()
        {
            if (setting.stockAlert)
            {
                string alertMessage = null;

                ProductPackageDA ppda = new ProductPackageDA();
                List<Package> pList = ppda.findProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);
                foreach (Package p in pList)
                    if (p.getQtyInStock() < 1)
                            alertMessage += "\n - " + p.getProductName();

                if (alertMessage != null)
                {
                    alertMessage = rs.GetString("stockAlertNoItemMsg") + alertMessage + "\n";
                    stockAlertLabel.Text = alertMessage;
                    stockAlertGroupBox.Visible = true;
                }
            }
        }

        private void showRecycleBinAlert()
        {
            string alertMessage = null;

            ProductPackageDA ppda = new ProductPackageDA();
            List<Package> pList = ppda.findDeletedProductPackagesBySupplierID(supplierID, Language.getLanguageCode(), conn);
            foreach (Package p in pList)
                if (p.getDateDeleted().Date <= DateTime.Now.Date.AddYears(-1))
                    alertMessage += "\n - " + p.getProductName();

            if (alertMessage != null)
            {
                alertMessage = rs.GetString("recycleBinAlertMsg") + alertMessage + "\n";
                recycleBinAlertLabel.Text = alertMessage;
                recycleBinAlertGroupBox.Visible = true;
            }
        }

        private void showProfile()
        {
            SupplierDA sda = new SupplierDA();
            Supplier s = sda.getOneSupplierByID(supplierID, conn);
            showSupplierIdLabel.Text = s.getSupplierID();
            showNameLabel.Text = s.getSupplierName();
            showContectNoLabel.Text = s.getContectNo();
            showEmailLabel.Text = s.getEmail();
            if (s.getProductCategory().Equals("Bottle"))
                showCategoryLabel.Text = rs.GetString("bottleText");
            else if (s.getProductCategory().Equals("Package"))
                showCategoryLabel.Text = rs.GetString("packageText");
            else if (s.getProductCategory().Equals("Perfume"))
                showCategoryLabel.Text = rs.GetString("perfumeText");
            showAddressLabel.Text = s.getAddress();
        }
    }
}
