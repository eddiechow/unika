﻿namespace BackendForSupplier.PackageSupplierForm
{
    partial class HomeUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserCtrl));
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.loginLogDataGridView = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePanel = new System.Windows.Forms.TableLayoutPanel();
            this.showAddressLabel = new MetroFramework.Controls.MetroLabel();
            this.showCategoryLabel = new MetroFramework.Controls.MetroLabel();
            this.categoryLabel = new MetroFramework.Controls.MetroLabel();
            this.showEmailLabel = new MetroFramework.Controls.MetroLabel();
            this.showContectNoLabel = new MetroFramework.Controls.MetroLabel();
            this.showNameLabel = new MetroFramework.Controls.MetroLabel();
            this.showSupplierIdLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierIdLabel = new MetroFramework.Controls.MetroLabel();
            this.contectNoLabel = new MetroFramework.Controls.MetroLabel();
            this.addressLabel = new MetroFramework.Controls.MetroLabel();
            this.stockAlertPanel = new System.Windows.Forms.Panel();
            this.stockAlertLabel = new MetroFramework.Controls.MetroLabel();
            this.recycleBinAlertPanel = new System.Windows.Forms.Panel();
            this.recycleBinAlertLabel = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.recycleBinAlertGroupBox = new System.Windows.Forms.GroupBox();
            this.stockAlertGroupBox = new System.Windows.Forms.GroupBox();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.loginLogGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogDataGridView)).BeginInit();
            this.profilePanel.SuspendLayout();
            this.stockAlertPanel.SuspendLayout();
            this.recycleBinAlertPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.recycleBinAlertGroupBox.SuspendLayout();
            this.stockAlertGroupBox.SuspendLayout();
            this.profileGroupBox.SuspendLayout();
            this.loginLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // loginLogDataGridView
            // 
            this.loginLogDataGridView.AllowUserToAddRows = false;
            this.loginLogDataGridView.AllowUserToDeleteRows = false;
            this.loginLogDataGridView.AllowUserToOrderColumns = true;
            this.loginLogDataGridView.AllowUserToResizeColumns = false;
            this.loginLogDataGridView.AllowUserToResizeRows = false;
            this.loginLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loginLogDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.loginLogDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.loginLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.loginLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.statusColumn});
            resources.ApplyResources(this.loginLogDataGridView, "loginLogDataGridView");
            this.loginLogDataGridView.Name = "loginLogDataGridView";
            this.loginLogDataGridView.RowHeadersVisible = false;
            this.loginLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dateColumn
            // 
            this.dateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.dateColumn, "dateColumn");
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.statusColumn, "statusColumn");
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // profilePanel
            // 
            resources.ApplyResources(this.profilePanel, "profilePanel");
            this.profilePanel.Controls.Add(this.showAddressLabel, 1, 5);
            this.profilePanel.Controls.Add(this.showCategoryLabel, 1, 4);
            this.profilePanel.Controls.Add(this.categoryLabel, 0, 4);
            this.profilePanel.Controls.Add(this.showEmailLabel, 1, 3);
            this.profilePanel.Controls.Add(this.showContectNoLabel, 1, 2);
            this.profilePanel.Controls.Add(this.showNameLabel, 1, 1);
            this.profilePanel.Controls.Add(this.showSupplierIdLabel, 1, 0);
            this.profilePanel.Controls.Add(this.emailLabel, 0, 3);
            this.profilePanel.Controls.Add(this.nameLabel, 0, 1);
            this.profilePanel.Controls.Add(this.supplierIdLabel, 0, 0);
            this.profilePanel.Controls.Add(this.contectNoLabel, 0, 2);
            this.profilePanel.Controls.Add(this.addressLabel, 0, 5);
            this.profilePanel.Name = "profilePanel";
            // 
            // showAddressLabel
            // 
            resources.ApplyResources(this.showAddressLabel, "showAddressLabel");
            this.showAddressLabel.Name = "showAddressLabel";
            this.showAddressLabel.WrapToLine = true;
            // 
            // showCategoryLabel
            // 
            resources.ApplyResources(this.showCategoryLabel, "showCategoryLabel");
            this.showCategoryLabel.Name = "showCategoryLabel";
            // 
            // categoryLabel
            // 
            resources.ApplyResources(this.categoryLabel, "categoryLabel");
            this.categoryLabel.Name = "categoryLabel";
            // 
            // showEmailLabel
            // 
            resources.ApplyResources(this.showEmailLabel, "showEmailLabel");
            this.showEmailLabel.Name = "showEmailLabel";
            // 
            // showContectNoLabel
            // 
            resources.ApplyResources(this.showContectNoLabel, "showContectNoLabel");
            this.showContectNoLabel.Name = "showContectNoLabel";
            // 
            // showNameLabel
            // 
            resources.ApplyResources(this.showNameLabel, "showNameLabel");
            this.showNameLabel.Name = "showNameLabel";
            // 
            // showSupplierIdLabel
            // 
            resources.ApplyResources(this.showSupplierIdLabel, "showSupplierIdLabel");
            this.showSupplierIdLabel.Name = "showSupplierIdLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // supplierIdLabel
            // 
            resources.ApplyResources(this.supplierIdLabel, "supplierIdLabel");
            this.supplierIdLabel.Name = "supplierIdLabel";
            // 
            // contectNoLabel
            // 
            resources.ApplyResources(this.contectNoLabel, "contectNoLabel");
            this.contectNoLabel.Name = "contectNoLabel";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // stockAlertPanel
            // 
            resources.ApplyResources(this.stockAlertPanel, "stockAlertPanel");
            this.stockAlertPanel.Controls.Add(this.stockAlertLabel);
            this.stockAlertPanel.Name = "stockAlertPanel";
            // 
            // stockAlertLabel
            // 
            resources.ApplyResources(this.stockAlertLabel, "stockAlertLabel");
            this.stockAlertLabel.Name = "stockAlertLabel";
            this.stockAlertLabel.WrapToLine = true;
            // 
            // recycleBinAlertPanel
            // 
            resources.ApplyResources(this.recycleBinAlertPanel, "recycleBinAlertPanel");
            this.recycleBinAlertPanel.Controls.Add(this.recycleBinAlertLabel);
            this.recycleBinAlertPanel.Name = "recycleBinAlertPanel";
            // 
            // recycleBinAlertLabel
            // 
            resources.ApplyResources(this.recycleBinAlertLabel, "recycleBinAlertLabel");
            this.recycleBinAlertLabel.Name = "recycleBinAlertLabel";
            this.recycleBinAlertLabel.WrapToLine = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loginLogGroupBox, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.recycleBinAlertGroupBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.stockAlertGroupBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.profileGroupBox, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // recycleBinAlertGroupBox
            // 
            this.recycleBinAlertGroupBox.Controls.Add(this.recycleBinAlertPanel);
            resources.ApplyResources(this.recycleBinAlertGroupBox, "recycleBinAlertGroupBox");
            this.recycleBinAlertGroupBox.Name = "recycleBinAlertGroupBox";
            this.recycleBinAlertGroupBox.TabStop = false;
            // 
            // stockAlertGroupBox
            // 
            this.stockAlertGroupBox.Controls.Add(this.stockAlertPanel);
            resources.ApplyResources(this.stockAlertGroupBox, "stockAlertGroupBox");
            this.stockAlertGroupBox.Name = "stockAlertGroupBox";
            this.stockAlertGroupBox.TabStop = false;
            // 
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.profilePanel);
            resources.ApplyResources(this.profileGroupBox, "profileGroupBox");
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.TabStop = false;
            // 
            // loginLogGroupBox
            // 
            this.loginLogGroupBox.Controls.Add(this.loginLogDataGridView);
            resources.ApplyResources(this.loginLogGroupBox, "loginLogGroupBox");
            this.loginLogGroupBox.Name = "loginLogGroupBox";
            this.loginLogGroupBox.TabStop = false;
            // 
            // HomeUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "HomeUserCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.loginLogDataGridView)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.stockAlertPanel.ResumeLayout(false);
            this.stockAlertPanel.PerformLayout();
            this.recycleBinAlertPanel.ResumeLayout(false);
            this.recycleBinAlertPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.recycleBinAlertGroupBox.ResumeLayout(false);
            this.stockAlertGroupBox.ResumeLayout(false);
            this.profileGroupBox.ResumeLayout(false);
            this.loginLogGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel welcomeLabel;
        private System.Windows.Forms.DataGridView loginLogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.TableLayoutPanel profilePanel;
        private MetroFramework.Controls.MetroLabel showCategoryLabel;
        private MetroFramework.Controls.MetroLabel categoryLabel;
        private MetroFramework.Controls.MetroLabel showEmailLabel;
        private MetroFramework.Controls.MetroLabel showContectNoLabel;
        private MetroFramework.Controls.MetroLabel showNameLabel;
        private MetroFramework.Controls.MetroLabel showSupplierIdLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel supplierIdLabel;
        private MetroFramework.Controls.MetroLabel contectNoLabel;
        private MetroFramework.Controls.MetroLabel addressLabel;
        private MetroFramework.Controls.MetroLabel showAddressLabel;
        private System.Windows.Forms.Panel stockAlertPanel;
        private MetroFramework.Controls.MetroLabel stockAlertLabel;
        private System.Windows.Forms.Panel recycleBinAlertPanel;
        private MetroFramework.Controls.MetroLabel recycleBinAlertLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox recycleBinAlertGroupBox;
        private System.Windows.Forms.GroupBox stockAlertGroupBox;
        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.GroupBox loginLogGroupBox;
    }
}
