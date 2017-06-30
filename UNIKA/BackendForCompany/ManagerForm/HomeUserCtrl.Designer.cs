namespace BackendForCompany.ManagerForm
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
            this.loginLogGroupBox = new System.Windows.Forms.GroupBox();
            this.loginLogDataGridView = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.profilePanel = new System.Windows.Forms.TableLayoutPanel();
            this.showPositionLabel = new MetroFramework.Controls.MetroLabel();
            this.showNameLabel = new MetroFramework.Controls.MetroLabel();
            this.showStaffIdLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.staffIdLabel = new MetroFramework.Controls.MetroLabel();
            this.positionLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.showEmailLabel = new MetroFramework.Controls.MetroLabel();
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.loginLogGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogDataGridView)).BeginInit();
            this.profileGroupBox.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLogGroupBox
            // 
            this.loginLogGroupBox.Controls.Add(this.loginLogDataGridView);
            resources.ApplyResources(this.loginLogGroupBox, "loginLogGroupBox");
            this.loginLogGroupBox.Name = "loginLogGroupBox";
            this.loginLogGroupBox.TabStop = false;
            this.loginLogGroupBox.Enter += new System.EventHandler(this.loginLogGroupBox_Enter);
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
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.profilePanel);
            resources.ApplyResources(this.profileGroupBox, "profileGroupBox");
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.TabStop = false;
            // 
            // profilePanel
            // 
            resources.ApplyResources(this.profilePanel, "profilePanel");
            this.profilePanel.Controls.Add(this.showPositionLabel, 1, 2);
            this.profilePanel.Controls.Add(this.showNameLabel, 1, 1);
            this.profilePanel.Controls.Add(this.showStaffIdLabel, 1, 0);
            this.profilePanel.Controls.Add(this.nameLabel, 0, 1);
            this.profilePanel.Controls.Add(this.staffIdLabel, 0, 0);
            this.profilePanel.Controls.Add(this.positionLabel, 0, 2);
            this.profilePanel.Controls.Add(this.emailLabel, 0, 3);
            this.profilePanel.Controls.Add(this.showEmailLabel, 1, 3);
            this.profilePanel.Name = "profilePanel";
            // 
            // showPositionLabel
            // 
            resources.ApplyResources(this.showPositionLabel, "showPositionLabel");
            this.showPositionLabel.Name = "showPositionLabel";
            // 
            // showNameLabel
            // 
            resources.ApplyResources(this.showNameLabel, "showNameLabel");
            this.showNameLabel.Name = "showNameLabel";
            // 
            // showStaffIdLabel
            // 
            resources.ApplyResources(this.showStaffIdLabel, "showStaffIdLabel");
            this.showStaffIdLabel.Name = "showStaffIdLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // staffIdLabel
            // 
            resources.ApplyResources(this.staffIdLabel, "staffIdLabel");
            this.staffIdLabel.Name = "staffIdLabel";
            // 
            // positionLabel
            // 
            resources.ApplyResources(this.positionLabel, "positionLabel");
            this.positionLabel.Name = "positionLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // showEmailLabel
            // 
            resources.ApplyResources(this.showEmailLabel, "showEmailLabel");
            this.showEmailLabel.Name = "showEmailLabel";
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeLabel.Name = "welcomeLabel";
            // 
            // HomeUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.profileGroupBox);
            this.Controls.Add(this.loginLogGroupBox);
            this.Name = "HomeUserCtrl";
            this.loginLogGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginLogDataGridView)).EndInit();
            this.profileGroupBox.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.GroupBox loginLogGroupBox;
        private System.Windows.Forms.DataGridView loginLogDataGridView;
        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.TableLayoutPanel profilePanel;
        private MetroFramework.Controls.MetroLabel showEmailLabel;
        private MetroFramework.Controls.MetroLabel showNameLabel;
        private MetroFramework.Controls.MetroLabel showStaffIdLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel staffIdLabel;
        private MetroFramework.Controls.MetroLabel positionLabel;
        private MetroFramework.Controls.MetroLabel showPositionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private MetroFramework.Controls.MetroLabel welcomeLabel;
    }
}
