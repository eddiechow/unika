namespace BackendForCompany.StaffForm
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
            this.reportProblemLabel = new MetroFramework.Controls.MetroLabel();
            this.reportProblemIcon = new System.Windows.Forms.PictureBox();
            this.logoutLabel = new MetroFramework.Controls.MetroLabel();
            this.resetPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.approveRejectOrderLabel = new MetroFramework.Controls.MetroLabel();
            this.homeLabel = new MetroFramework.Controls.MetroLabel();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.resetPasswordIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.approveRejectOrderIcon = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportProblemIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approveRejectOrderIcon)).BeginInit();
            this.menuPanel.SuspendLayout();
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
            // reportProblemLabel
            // 
            resources.ApplyResources(this.reportProblemLabel, "reportProblemLabel");
            this.reportProblemLabel.Name = "reportProblemLabel";
            this.reportProblemLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.reportProblemLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.reportProblemLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // reportProblemIcon
            // 
            resources.ApplyResources(this.reportProblemIcon, "reportProblemIcon");
            this.reportProblemIcon.BackColor = System.Drawing.Color.Transparent;
            this.reportProblemIcon.Image = global::BackendForCompany.Properties.Resources.alert;
            this.reportProblemIcon.Name = "reportProblemIcon";
            this.reportProblemIcon.TabStop = false;
            this.reportProblemIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.reportProblemIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.reportProblemIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.logoutLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.logoutLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // resetPasswordLabel
            // 
            resources.ApplyResources(this.resetPasswordLabel, "resetPasswordLabel");
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.resetPasswordLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.resetPasswordLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // approveRejectOrderLabel
            // 
            resources.ApplyResources(this.approveRejectOrderLabel, "approveRejectOrderLabel");
            this.approveRejectOrderLabel.Name = "approveRejectOrderLabel";
            this.approveRejectOrderLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.approveRejectOrderLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.approveRejectOrderLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // homeLabel
            // 
            resources.ApplyResources(this.homeLabel, "homeLabel");
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Click += new System.EventHandler(this.loadUserContorl);
            this.homeLabel.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.homeLabel.MouseHover += new System.EventHandler(this.menu_MouseHover);
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
            // approveRejectOrderIcon
            // 
            resources.ApplyResources(this.approveRejectOrderIcon, "approveRejectOrderIcon");
            this.approveRejectOrderIcon.Image = global::BackendForCompany.Properties.Resources.approve;
            this.approveRejectOrderIcon.Name = "approveRejectOrderIcon";
            this.approveRejectOrderIcon.TabStop = false;
            this.approveRejectOrderIcon.Click += new System.EventHandler(this.loadUserContorl);
            this.approveRejectOrderIcon.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            this.approveRejectOrderIcon.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.approveRejectOrderIcon, 1, 0);
            this.menuPanel.Controls.Add(this.reportProblemLabel, 2, 1);
            this.menuPanel.Controls.Add(this.reportProblemIcon, 2, 0);
            this.menuPanel.Controls.Add(this.resetPasswordLabel, 3, 1);
            this.menuPanel.Controls.Add(this.logoutIcon, 4, 0);
            this.menuPanel.Controls.Add(this.homeIcon, 0, 0);
            this.menuPanel.Controls.Add(this.approveRejectOrderLabel, 1, 1);
            this.menuPanel.Controls.Add(this.resetPasswordIcon, 3, 0);
            this.menuPanel.Controls.Add(this.homeLabel, 0, 1);
            this.menuPanel.Controls.Add(this.logoutLabel, 4, 1);
            this.menuPanel.Name = "menuPanel";
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
            ((System.ComponentModel.ISupportInitialize)(this.reportProblemIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approveRejectOrderIcon)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private MetroFramework.Controls.MetroComboBox languageComboBox;
        private MetroFramework.Controls.MetroLabel reportProblemLabel;
        private System.Windows.Forms.PictureBox reportProblemIcon;
        private MetroFramework.Controls.MetroLabel logoutLabel;
        private MetroFramework.Controls.MetroLabel resetPasswordLabel;
        private MetroFramework.Controls.MetroLabel approveRejectOrderLabel;
        private MetroFramework.Controls.MetroLabel homeLabel;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.PictureBox resetPasswordIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox approveRejectOrderIcon;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}