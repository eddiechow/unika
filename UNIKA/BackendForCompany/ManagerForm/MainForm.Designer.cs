namespace BackendForCompany.ManagerForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.handleCustomerAccountLabel = new MetroFramework.Controls.MetroLabel();
            this.homeLabel = new MetroFramework.Controls.MetroLabel();
            this.setPromotionLabel = new MetroFramework.Controls.MetroLabel();
            this.handleCustomerAccountIcon = new System.Windows.Forms.PictureBox();
            this.resetPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.generateSalesReportIcon = new System.Windows.Forms.PictureBox();
            this.handleEcommerceContentIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.setPromotionIcon = new System.Windows.Forms.PictureBox();
            this.handleEcommerceContentLabel = new MetroFramework.Controls.MetroLabel();
            this.generateSalesReportLabel = new MetroFramework.Controls.MetroLabel();
            this.refundIcon = new System.Windows.Forms.PictureBox();
            this.refundLabel = new MetroFramework.Controls.MetroLabel();
            this.recycleBinLabel = new MetroFramework.Controls.MetroLabel();
            this.recycleBinIcon = new System.Windows.Forms.PictureBox();
            this.resetPasswordIcon = new System.Windows.Forms.PictureBox();
            this.logoutLabel = new MetroFramework.Controls.MetroLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.languageComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handleCustomerAccountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateSalesReportIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleEcommerceContentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPromotionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBinIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Image = global::BackendForCompany.Properties.Resources.unika;
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.handleCustomerAccountLabel, 4, 1);
            this.menuPanel.Controls.Add(this.homeLabel, 0, 1);
            this.menuPanel.Controls.Add(this.setPromotionLabel, 1, 1);
            this.menuPanel.Controls.Add(this.handleCustomerAccountIcon, 4, 0);
            this.menuPanel.Controls.Add(this.resetPasswordLabel, 6, 1);
            this.menuPanel.Controls.Add(this.logoutIcon, 8, 0);
            this.menuPanel.Controls.Add(this.generateSalesReportIcon, 3, 0);
            this.menuPanel.Controls.Add(this.handleEcommerceContentIcon, 2, 0);
            this.menuPanel.Controls.Add(this.homeIcon, 0, 0);
            this.menuPanel.Controls.Add(this.setPromotionIcon, 1, 0);
            this.menuPanel.Controls.Add(this.handleEcommerceContentLabel, 2, 1);
            this.menuPanel.Controls.Add(this.generateSalesReportLabel, 3, 1);
            this.menuPanel.Controls.Add(this.refundIcon, 5, 0);
            this.menuPanel.Controls.Add(this.refundLabel, 5, 1);
            this.menuPanel.Controls.Add(this.recycleBinLabel, 7, 1);
            this.menuPanel.Controls.Add(this.recycleBinIcon, 7, 0);
            this.menuPanel.Controls.Add(this.resetPasswordIcon, 6, 0);
            this.menuPanel.Controls.Add(this.logoutLabel, 8, 1);
            this.menuPanel.Name = "menuPanel";
            // 
            // handleCustomerAccountLabel
            // 
            resources.ApplyResources(this.handleCustomerAccountLabel, "handleCustomerAccountLabel");
            this.handleCustomerAccountLabel.Name = "handleCustomerAccountLabel";
            this.handleCustomerAccountLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.handleCustomerAccountLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.handleCustomerAccountLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // homeLabel
            // 
            resources.ApplyResources(this.homeLabel, "homeLabel");
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.homeLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.homeLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // setPromotionLabel
            // 
            resources.ApplyResources(this.setPromotionLabel, "setPromotionLabel");
            this.setPromotionLabel.Name = "setPromotionLabel";
            this.setPromotionLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.setPromotionLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.setPromotionLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // handleCustomerAccountIcon
            // 
            resources.ApplyResources(this.handleCustomerAccountIcon, "handleCustomerAccountIcon");
            this.handleCustomerAccountIcon.BackColor = System.Drawing.Color.Transparent;
            this.handleCustomerAccountIcon.Image = global::BackendForCompany.Properties.Resources.customer;
            this.handleCustomerAccountIcon.Name = "handleCustomerAccountIcon";
            this.handleCustomerAccountIcon.TabStop = false;
            this.handleCustomerAccountIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.handleCustomerAccountIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.handleCustomerAccountIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // resetPasswordLabel
            // 
            resources.ApplyResources(this.resetPasswordLabel, "resetPasswordLabel");
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.resetPasswordLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.resetPasswordLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // logoutIcon
            // 
            resources.ApplyResources(this.logoutIcon, "logoutIcon");
            this.logoutIcon.BackColor = System.Drawing.Color.Transparent;
            this.logoutIcon.Image = global::BackendForCompany.Properties.Resources.logout;
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.logoutIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.logoutIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // generateSalesReportIcon
            // 
            resources.ApplyResources(this.generateSalesReportIcon, "generateSalesReportIcon");
            this.generateSalesReportIcon.BackColor = System.Drawing.Color.Transparent;
            this.generateSalesReportIcon.Image = global::BackendForCompany.Properties.Resources.report;
            this.generateSalesReportIcon.Name = "generateSalesReportIcon";
            this.generateSalesReportIcon.TabStop = false;
            this.generateSalesReportIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.generateSalesReportIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.generateSalesReportIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // handleEcommerceContentIcon
            // 
            resources.ApplyResources(this.handleEcommerceContentIcon, "handleEcommerceContentIcon");
            this.handleEcommerceContentIcon.BackColor = System.Drawing.Color.Transparent;
            this.handleEcommerceContentIcon.Image = global::BackendForCompany.Properties.Resources.handle;
            this.handleEcommerceContentIcon.Name = "handleEcommerceContentIcon";
            this.handleEcommerceContentIcon.TabStop = false;
            this.handleEcommerceContentIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.handleEcommerceContentIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.handleEcommerceContentIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // homeIcon
            // 
            resources.ApplyResources(this.homeIcon, "homeIcon");
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.Image = global::BackendForCompany.Properties.Resources.home;
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.homeIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.homeIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // setPromotionIcon
            // 
            resources.ApplyResources(this.setPromotionIcon, "setPromotionIcon");
            this.setPromotionIcon.BackColor = System.Drawing.Color.Transparent;
            this.setPromotionIcon.Image = global::BackendForCompany.Properties.Resources.discount;
            this.setPromotionIcon.Name = "setPromotionIcon";
            this.setPromotionIcon.TabStop = false;
            this.setPromotionIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.setPromotionIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.setPromotionIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // handleEcommerceContentLabel
            // 
            resources.ApplyResources(this.handleEcommerceContentLabel, "handleEcommerceContentLabel");
            this.handleEcommerceContentLabel.Name = "handleEcommerceContentLabel";
            this.handleEcommerceContentLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.handleEcommerceContentLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.handleEcommerceContentLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // generateSalesReportLabel
            // 
            resources.ApplyResources(this.generateSalesReportLabel, "generateSalesReportLabel");
            this.generateSalesReportLabel.Name = "generateSalesReportLabel";
            this.generateSalesReportLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.generateSalesReportLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.generateSalesReportLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // refundIcon
            // 
            resources.ApplyResources(this.refundIcon, "refundIcon");
            this.refundIcon.BackColor = System.Drawing.Color.Transparent;
            this.refundIcon.Image = global::BackendForCompany.Properties.Resources.refund;
            this.refundIcon.Name = "refundIcon";
            this.refundIcon.TabStop = false;
            this.refundIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.refundIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.refundIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // refundLabel
            // 
            resources.ApplyResources(this.refundLabel, "refundLabel");
            this.refundLabel.Name = "refundLabel";
            this.refundLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.refundLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.refundLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // recycleBinLabel
            // 
            resources.ApplyResources(this.recycleBinLabel, "recycleBinLabel");
            this.recycleBinLabel.Name = "recycleBinLabel";
            this.recycleBinLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.recycleBinLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // recycleBinIcon
            // 
            resources.ApplyResources(this.recycleBinIcon, "recycleBinIcon");
            this.recycleBinIcon.BackColor = System.Drawing.Color.Transparent;
            this.recycleBinIcon.Name = "recycleBinIcon";
            this.recycleBinIcon.TabStop = false;
            this.recycleBinIcon.Click += new System.EventHandler(this.loadUserContorl);
            // 
            // resetPasswordIcon
            // 
            resources.ApplyResources(this.resetPasswordIcon, "resetPasswordIcon");
            this.resetPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.resetPasswordIcon.Image = global::BackendForCompany.Properties.Resources.key;
            this.resetPasswordIcon.Name = "resetPasswordIcon";
            this.resetPasswordIcon.TabStop = false;
            this.resetPasswordIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.resetPasswordIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.resetPasswordIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.logoutLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.languageComboBox.UseSelectable = true;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.Logo);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.handleCustomerAccountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateSalesReportIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleEcommerceContentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setPromotionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBinIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.PictureBox resetPasswordIcon;
        private System.Windows.Forms.PictureBox handleCustomerAccountIcon;
        private System.Windows.Forms.PictureBox generateSalesReportIcon;
        private System.Windows.Forms.PictureBox handleEcommerceContentIcon;
        private System.Windows.Forms.PictureBox setPromotionIcon;
        private MetroFramework.Controls.MetroLabel logoutLabel;
        private MetroFramework.Controls.MetroLabel resetPasswordLabel;
        private MetroFramework.Controls.MetroLabel handleCustomerAccountLabel;
        private MetroFramework.Controls.MetroLabel generateSalesReportLabel;
        private MetroFramework.Controls.MetroLabel handleEcommerceContentLabel;
        private MetroFramework.Controls.MetroLabel setPromotionLabel;
        private MetroFramework.Controls.MetroLabel homeLabel;
        private MetroFramework.Controls.MetroComboBox languageComboBox;
        private System.Windows.Forms.PictureBox recycleBinIcon;
        private MetroFramework.Controls.MetroLabel recycleBinLabel;
        private MetroFramework.Controls.MetroLabel refundLabel;
        private System.Windows.Forms.PictureBox refundIcon;
    }
}