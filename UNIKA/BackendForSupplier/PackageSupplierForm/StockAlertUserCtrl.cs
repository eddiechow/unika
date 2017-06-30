using System;
using MetroFramework.Controls;

namespace BackendForSupplier.PackageSupplierForm
{
    public partial class StockAlertUserCtrl : MetroUserControl
    {
        private Properties.Settings setting = Properties.Settings.Default;

        private string supplierID = null;

        public StockAlertUserCtrl(string supplierID)
        {
            InitializeComponent();

            this.supplierID = supplierID;

            if (setting.stockAlert)
                yesRadioButton.Checked = true;
            else
                noRadioButton.Checked = true;

            changeMsgLabel.Visible = false;
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            changeMsgLabel.Visible = true;
            setting.stockAlert = true;
            setting.Save();
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            changeMsgLabel.Visible = true;
            setting.stockAlert = false;
            setting.Save();
        }
    }
}
