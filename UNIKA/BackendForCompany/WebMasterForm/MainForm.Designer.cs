namespace BackendForCompany.WebMasterForm
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
            this.languageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.logoutLabel = new MetroFramework.Controls.MetroLabel();
            this.resetPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierManagementLabel = new MetroFramework.Controls.MetroLabel();
            this.staffManagementLabel = new MetroFramework.Controls.MetroLabel();
            this.loginLogLabel = new MetroFramework.Controls.MetroLabel();
            this.homeLabel = new MetroFramework.Controls.MetroLabel();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.resetPasswordIcon = new System.Windows.Forms.PictureBox();
            this.supplierManagementIcon = new System.Windows.Forms.PictureBox();
            this.staffManagementIcon = new System.Windows.Forms.PictureBox();
            this.loginLogIcon = new System.Windows.Forms.PictureBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.recycleBinLabel = new MetroFramework.Controls.MetroLabel();
            this.recycleBinIcon = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBinIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Image = global::BackendForCompany.Properties.Resources.unika;
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
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
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.logoutLabel.MouseLeave += new System.EventHandler(this.menu_MouseHover);
            this.logoutLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menu_MouseLeave);
            // 
            // resetPasswordLabel
            // 
            resources.ApplyResources(this.resetPasswordLabel, "resetPasswordLabel");
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.resetPasswordLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.resetPasswordLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // supplierManagementLabel
            // 
            resources.ApplyResources(this.supplierManagementLabel, "supplierManagementLabel");
            this.supplierManagementLabel.Name = "supplierManagementLabel";
            this.supplierManagementLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.supplierManagementLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.supplierManagementLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // staffManagementLabel
            // 
            resources.ApplyResources(this.staffManagementLabel, "staffManagementLabel");
            this.staffManagementLabel.Name = "staffManagementLabel";
            this.staffManagementLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.staffManagementLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.staffManagementLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // loginLogLabel
            // 
            resources.ApplyResources(this.loginLogLabel, "loginLogLabel");
            this.loginLogLabel.Name = "loginLogLabel";
            this.loginLogLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.loginLogLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.loginLogLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // homeLabel
            // 
            resources.ApplyResources(this.homeLabel, "homeLabel");
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.homeLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.homeLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
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
            // supplierManagementIcon
            // 
            resources.ApplyResources(this.supplierManagementIcon, "supplierManagementIcon");
            this.supplierManagementIcon.BackColor = System.Drawing.Color.Transparent;
            this.supplierManagementIcon.Image = global::BackendForCompany.Properties.Resources.package;
            this.supplierManagementIcon.Name = "supplierManagementIcon";
            this.supplierManagementIcon.TabStop = false;
            this.supplierManagementIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.supplierManagementIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.supplierManagementIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // staffManagementIcon
            // 
            resources.ApplyResources(this.staffManagementIcon, "staffManagementIcon");
            this.staffManagementIcon.BackColor = System.Drawing.Color.Transparent;
            this.staffManagementIcon.Image = global::BackendForCompany.Properties.Resources.add;
            this.staffManagementIcon.Name = "staffManagementIcon";
            this.staffManagementIcon.TabStop = false;
            this.staffManagementIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.staffManagementIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.staffManagementIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // loginLogIcon
            // 
            resources.ApplyResources(this.loginLogIcon, "loginLogIcon");
            this.loginLogIcon.BackColor = System.Drawing.Color.Transparent;
            this.loginLogIcon.Image = global::BackendForCompany.Properties.Resources.note;
            this.loginLogIcon.Name = "loginLogIcon";
            this.loginLogIcon.TabStop = false;
            this.loginLogIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.loginLogIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.loginLogIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
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
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.recycleBinLabel, 5, 1);
            this.menuPanel.Controls.Add(this.resetPasswordLabel, 4, 1);
            this.menuPanel.Controls.Add(this.supplierManagementLabel, 3, 1);
            this.menuPanel.Controls.Add(this.staffManagementLabel, 2, 1);
            this.menuPanel.Controls.Add(this.loginLogLabel, 1, 1);
            this.menuPanel.Controls.Add(this.homeLabel, 0, 1);
            this.menuPanel.Controls.Add(this.loginLogIcon, 1, 0);
            this.menuPanel.Controls.Add(this.resetPasswordIcon, 4, 0);
            this.menuPanel.Controls.Add(this.staffManagementIcon, 2, 0);
            this.menuPanel.Controls.Add(this.supplierManagementIcon, 3, 0);
            this.menuPanel.Controls.Add(this.homeIcon, 0, 0);
            this.menuPanel.Controls.Add(this.logoutIcon, 6, 0);
            this.menuPanel.Controls.Add(this.logoutLabel, 6, 1);
            this.menuPanel.Controls.Add(this.recycleBinIcon, 5, 0);
            this.menuPanel.Name = "menuPanel";
            // 
            // recycleBinLabel
            // 
            resources.ApplyResources(this.recycleBinLabel, "recycleBinLabel");
            this.recycleBinLabel.Name = "recycleBinLabel";
            this.recycleBinLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.recycleBinLabel.MouseLeave += new System.EventHandler(this.menu_MouseHover);
            this.recycleBinLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menu_MouseLeave);
            // 
            // recycleBinIcon
            // 
            resources.ApplyResources(this.recycleBinIcon, "recycleBinIcon");
            this.recycleBinIcon.BackColor = System.Drawing.Color.Transparent;
            this.recycleBinIcon.Name = "recycleBinIcon";
            this.recycleBinIcon.TabStop = false;
            this.recycleBinIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.recycleBinIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.recycleBinIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
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
            this.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.MouseHover += new System.EventHandler(this.menu_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBinIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private MetroFramework.Controls.MetroComboBox languageComboBox;
        private MetroFramework.Controls.MetroLabel logoutLabel;
        private MetroFramework.Controls.MetroLabel resetPasswordLabel;
        private MetroFramework.Controls.MetroLabel supplierManagementLabel;
        private MetroFramework.Controls.MetroLabel staffManagementLabel;
        private MetroFramework.Controls.MetroLabel loginLogLabel;
        private MetroFramework.Controls.MetroLabel homeLabel;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox resetPasswordIcon;
        private System.Windows.Forms.PictureBox supplierManagementIcon;
        private System.Windows.Forms.PictureBox staffManagementIcon;
        private System.Windows.Forms.PictureBox loginLogIcon;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private MetroFramework.Controls.MetroLabel recycleBinLabel;
        private System.Windows.Forms.PictureBox recycleBinIcon;
    }
}