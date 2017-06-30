using MetroFramework.Forms;
using System;
using System.Drawing.Printing;

namespace BackendForCompany
{
    public partial class ReceiptPrinterSettingForm : MetroForm
    {
        Properties.Settings setting = Properties.Settings.Default;

        public ReceiptPrinterSettingForm()
        {
            InitializeComponent();

            foreach(string printer in PrinterSettings.InstalledPrinters)
                printerComboBox.Items.Add(printer);

            printerComboBox.Text = setting.receiptPrinter;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            setting.receiptPrinter = printerComboBox.Text;
            setting.Save();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
