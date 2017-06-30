namespace BackendForSupplier.PerfumeSupplierForm
{
    partial class StockAlertUserCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAlertUserCtrl));
            this.yesRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.noRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.loginLogGroupBox = new System.Windows.Forms.GroupBox();
            this.showAlertAfterLoginLabel = new MetroFramework.Controls.MetroLabel();
            this.changeMsgLabel = new MetroFramework.Controls.MetroLabel();
            this.loginLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // yesRadioButton
            // 
            resources.ApplyResources(this.yesRadioButton, "yesRadioButton");
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.yesRadioButton.UseSelectable = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // noRadioButton
            // 
            resources.ApplyResources(this.noRadioButton, "noRadioButton");
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.noRadioButton.UseSelectable = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // loginLogGroupBox
            // 
            this.loginLogGroupBox.Controls.Add(this.changeMsgLabel);
            this.loginLogGroupBox.Controls.Add(this.showAlertAfterLoginLabel);
            this.loginLogGroupBox.Controls.Add(this.noRadioButton);
            this.loginLogGroupBox.Controls.Add(this.yesRadioButton);
            resources.ApplyResources(this.loginLogGroupBox, "loginLogGroupBox");
            this.loginLogGroupBox.Name = "loginLogGroupBox";
            this.loginLogGroupBox.TabStop = false;
            // 
            // showAlertAfterLoginLabel
            // 
            resources.ApplyResources(this.showAlertAfterLoginLabel, "showAlertAfterLoginLabel");
            this.showAlertAfterLoginLabel.Name = "showAlertAfterLoginLabel";
            // 
            // changeMsgLabel
            // 
            resources.ApplyResources(this.changeMsgLabel, "changeMsgLabel");
            this.changeMsgLabel.ForeColor = System.Drawing.Color.Blue;
            this.changeMsgLabel.Name = "changeMsgLabel";
            this.changeMsgLabel.UseCustomForeColor = true;
            // 
            // StockAlertUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginLogGroupBox);
            this.Name = "StockAlertUserCtrl";
            this.loginLogGroupBox.ResumeLayout(false);
            this.loginLogGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton yesRadioButton;
        private MetroFramework.Controls.MetroRadioButton noRadioButton;
        private System.Windows.Forms.GroupBox loginLogGroupBox;
        private MetroFramework.Controls.MetroLabel showAlertAfterLoginLabel;
        private MetroFramework.Controls.MetroLabel changeMsgLabel;
    }
}
