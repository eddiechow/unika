namespace BackendForSupplier.PackageSupplierForm
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
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.homeLabel = new MetroFramework.Controls.MetroLabel();
            this.stockAlertLabel = new MetroFramework.Controls.MetroLabel();
            this.stockAlertIcon = new System.Windows.Forms.PictureBox();
            this.recycleBinIcon = new System.Windows.Forms.PictureBox();
            this.logoutLabel = new MetroFramework.Controls.MetroLabel();
            this.packageManagementLabel = new MetroFramework.Controls.MetroLabel();
            this.packageManagementIcon = new System.Windows.Forms.PictureBox();
            this.resetPasswordIcon = new System.Windows.Forms.PictureBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.recycleBinLabel = new MetroFramework.Controls.MetroLabel();
            this.resetPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockAlertIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBinIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Image = global::BackendForSupplier.Properties.Resources.unika;
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.languageComboBox.UseSelectable = true;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.homeLabel, 0, 1);
            this.menuPanel.Controls.Add(this.stockAlertLabel, 2, 1);
            this.menuPanel.Controls.Add(this.stockAlertIcon, 2, 0);
            this.menuPanel.Controls.Add(this.recycleBinIcon, 3, 0);
            this.menuPanel.Controls.Add(this.logoutLabel, 5, 1);
            this.menuPanel.Controls.Add(this.packageManagementLabel, 1, 1);
            this.menuPanel.Controls.Add(this.packageManagementIcon, 1, 0);
            this.menuPanel.Controls.Add(this.resetPasswordIcon, 4, 0);
            this.menuPanel.Controls.Add(this.logoutIcon, 5, 0);
            this.menuPanel.Controls.Add(this.homeIcon, 0, 0);
            this.menuPanel.Controls.Add(this.recycleBinLabel, 3, 1);
            this.menuPanel.Controls.Add(this.resetPasswordLabel, 4, 1);
            this.menuPanel.Name = "menuPanel";
            // 
            // homeLabel
            // 
            resources.ApplyResources(this.homeLabel, "homeLabel");
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.homeLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.homeLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // stockAlertLabel
            // 
            resources.ApplyResources(this.stockAlertLabel, "stockAlertLabel");
            this.stockAlertLabel.Name = "stockAlertLabel";
            this.stockAlertLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.stockAlertLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.stockAlertLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // stockAlertIcon
            // 
            resources.ApplyResources(this.stockAlertIcon, "stockAlertIcon");
            this.stockAlertIcon.BackColor = System.Drawing.Color.Transparent;
            this.stockAlertIcon.Image = global::BackendForSupplier.Properties.Resources.alert;
            this.stockAlertIcon.Name = "stockAlertIcon";
            this.stockAlertIcon.TabStop = false;
            this.stockAlertIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.stockAlertIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.stockAlertIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // recycleBinIcon
            // 
            resources.ApplyResources(this.recycleBinIcon, "recycleBinIcon");
            this.recycleBinIcon.BackColor = System.Drawing.Color.Transparent;
            this.recycleBinIcon.Image = global::BackendForSupplier.Properties.Resources.recycle_bin;
            this.recycleBinIcon.Name = "recycleBinIcon";
            this.recycleBinIcon.TabStop = false;
            this.recycleBinIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.recycleBinIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.recycleBinIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.logoutLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.logoutLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // packageManagementLabel
            // 
            resources.ApplyResources(this.packageManagementLabel, "packageManagementLabel");
            this.packageManagementLabel.Name = "packageManagementLabel";
            this.packageManagementLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.packageManagementLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.packageManagementLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // packageManagementIcon
            // 
            resources.ApplyResources(this.packageManagementIcon, "packageManagementIcon");
            this.packageManagementIcon.BackColor = System.Drawing.Color.Transparent;
            this.packageManagementIcon.Image = global::BackendForSupplier.Properties.Resources.package;
            this.packageManagementIcon.Name = "packageManagementIcon";
            this.packageManagementIcon.TabStop = false;
            this.packageManagementIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.packageManagementIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.packageManagementIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // resetPasswordIcon
            // 
            resources.ApplyResources(this.resetPasswordIcon, "resetPasswordIcon");
            this.resetPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.resetPasswordIcon.Image = global::BackendForSupplier.Properties.Resources.key;
            this.resetPasswordIcon.Name = "resetPasswordIcon";
            this.resetPasswordIcon.TabStop = false;
            this.resetPasswordIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.resetPasswordIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.resetPasswordIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // logoutIcon
            // 
            resources.ApplyResources(this.logoutIcon, "logoutIcon");
            this.logoutIcon.BackColor = System.Drawing.Color.Transparent;
            this.logoutIcon.Image = global::BackendForSupplier.Properties.Resources.logout;
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.logoutIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.logoutIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // homeIcon
            // 
            resources.ApplyResources(this.homeIcon, "homeIcon");
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.Image = global::BackendForSupplier.Properties.Resources.home;
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.homeIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.homeIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // recycleBinLabel
            // 
            resources.ApplyResources(this.recycleBinLabel, "recycleBinLabel");
            this.recycleBinLabel.Name = "recycleBinLabel";
            this.recycleBinLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.recycleBinLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.recycleBinLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // resetPasswordLabel
            // 
            resources.ApplyResources(this.resetPasswordLabel, "resetPasswordLabel");
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.resetPasswordLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.resetPasswordLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
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
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockAlertIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleBinIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private MetroFramework.Controls.MetroComboBox languageComboBox;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private MetroFramework.Controls.MetroLabel logoutLabel;
        private MetroFramework.Controls.MetroLabel packageManagementLabel;
        private System.Windows.Forms.PictureBox packageManagementIcon;
        private System.Windows.Forms.PictureBox resetPasswordIcon;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox recycleBinIcon;
        private MetroFramework.Controls.MetroLabel recycleBinLabel;
        private System.Windows.Forms.PictureBox stockAlertIcon;
        private MetroFramework.Controls.MetroLabel stockAlertLabel;
        private MetroFramework.Controls.MetroLabel homeLabel;
        private System.Windows.Forms.Panel mainPanel;
        private MetroFramework.Controls.MetroLabel resetPasswordLabel;
    }
}