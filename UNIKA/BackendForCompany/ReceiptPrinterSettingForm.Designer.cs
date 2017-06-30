namespace BackendForCompany
{
    partial class ReceiptPrinterSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptPrinterSettingForm));
            this.headerLabel = new MetroFramework.Controls.MetroLabel();
            this.printerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.selectLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            resources.ApplyResources(this.headerLabel, "headerLabel");
            this.headerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.headerLabel.Name = "headerLabel";
            // 
            // printerComboBox
            // 
            this.printerComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.printerComboBox, "printerComboBox");
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.printerComboBox.UseCustomForeColor = true;
            this.printerComboBox.UseSelectable = true;
            // 
            // okButton
            // 
            this.okButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.okButton.Highlight = true;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Highlight = true;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectLabel
            // 
            resources.ApplyResources(this.selectLabel, "selectLabel");
            this.selectLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.selectLabel.Name = "selectLabel";
            // 
            // ReceiptPrinterSettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.printerComboBox);
            this.Controls.Add(this.headerLabel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ReceiptPrinterSettingForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel headerLabel;
        private MetroFramework.Controls.MetroComboBox printerComboBox;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel selectLabel;
    }
}