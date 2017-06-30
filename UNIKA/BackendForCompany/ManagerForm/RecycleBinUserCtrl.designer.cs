namespace BackendForCompany.ManagerForm
{
    partial class RecycleBinUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBinUserCtrl));
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.customerGivenNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.customerGivenNameLabel = new MetroFramework.Controls.MetroLabel();
            this.customerSurnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.customerSurnameLabel = new MetroFramework.Controls.MetroLabel();
            this.customerIdLabel = new MetroFramework.Controls.MetroLabel();
            this.customerIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.customerListDataGridView = new System.Windows.Forms.DataGridView();
            this.recoverButton = new MetroFramework.Controls.MetroButton();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.permanentlyDeleteButton = new MetroFramework.Controls.MetroButton();
            this.selectedCustomerColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMobilePhoneNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.resetButton, 8, 0);
            this.tableLayoutPanel6.Controls.Add(this.emailTextBox, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.emailLabel, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.customerGivenNameTextBox, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.customerGivenNameLabel, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.customerSurnameTextBox, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.customerSurnameLabel, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.customerIdLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.customerIdTextBox, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Highlight = true;
            this.resetButton.Name = "resetButton";
            this.resetButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.emailTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.emailTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.MaxLength = 8;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.UseStyleColors = true;
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.emailTextBox.TextChanged += new System.EventHandler(this.input_searchChanged);
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.emailLabel.Name = "emailLabel";
            // 
            // customerGivenNameTextBox
            // 
            resources.ApplyResources(this.customerGivenNameTextBox, "customerGivenNameTextBox");
            // 
            // 
            // 
            this.customerGivenNameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.customerGivenNameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.customerGivenNameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.customerGivenNameTextBox.CustomButton.Name = "";
            this.customerGivenNameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.customerGivenNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customerGivenNameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.customerGivenNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerGivenNameTextBox.CustomButton.UseSelectable = true;
            this.customerGivenNameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.customerGivenNameTextBox.Lines = new string[0];
            this.customerGivenNameTextBox.MaxLength = 32767;
            this.customerGivenNameTextBox.Name = "customerGivenNameTextBox";
            this.customerGivenNameTextBox.PasswordChar = '\0';
            this.customerGivenNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerGivenNameTextBox.SelectedText = "";
            this.customerGivenNameTextBox.SelectionLength = 0;
            this.customerGivenNameTextBox.SelectionStart = 0;
            this.customerGivenNameTextBox.ShortcutsEnabled = true;
            this.customerGivenNameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.customerGivenNameTextBox.UseSelectable = true;
            this.customerGivenNameTextBox.UseStyleColors = true;
            this.customerGivenNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customerGivenNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customerGivenNameTextBox.TextChanged += new System.EventHandler(this.input_searchChanged);
            // 
            // customerGivenNameLabel
            // 
            resources.ApplyResources(this.customerGivenNameLabel, "customerGivenNameLabel");
            this.customerGivenNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.customerGivenNameLabel.Name = "customerGivenNameLabel";
            // 
            // customerSurnameTextBox
            // 
            resources.ApplyResources(this.customerSurnameTextBox, "customerSurnameTextBox");
            // 
            // 
            // 
            this.customerSurnameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.customerSurnameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.customerSurnameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.customerSurnameTextBox.CustomButton.Name = "";
            this.customerSurnameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.customerSurnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customerSurnameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.customerSurnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerSurnameTextBox.CustomButton.UseSelectable = true;
            this.customerSurnameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.customerSurnameTextBox.Lines = new string[0];
            this.customerSurnameTextBox.MaxLength = 32767;
            this.customerSurnameTextBox.Name = "customerSurnameTextBox";
            this.customerSurnameTextBox.PasswordChar = '\0';
            this.customerSurnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerSurnameTextBox.SelectedText = "";
            this.customerSurnameTextBox.SelectionLength = 0;
            this.customerSurnameTextBox.SelectionStart = 0;
            this.customerSurnameTextBox.ShortcutsEnabled = true;
            this.customerSurnameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.customerSurnameTextBox.UseSelectable = true;
            this.customerSurnameTextBox.UseStyleColors = true;
            this.customerSurnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customerSurnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customerSurnameTextBox.TextChanged += new System.EventHandler(this.input_searchChanged);
            // 
            // customerSurnameLabel
            // 
            resources.ApplyResources(this.customerSurnameLabel, "customerSurnameLabel");
            this.customerSurnameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.customerSurnameLabel.Name = "customerSurnameLabel";
            // 
            // customerIdLabel
            // 
            resources.ApplyResources(this.customerIdLabel, "customerIdLabel");
            this.customerIdLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.customerIdLabel.Name = "customerIdLabel";
            // 
            // customerIdTextBox
            // 
            resources.ApplyResources(this.customerIdTextBox, "customerIdTextBox");
            // 
            // 
            // 
            this.customerIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.customerIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.customerIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.customerIdTextBox.CustomButton.Name = "";
            this.customerIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.customerIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customerIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.customerIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customerIdTextBox.CustomButton.UseSelectable = true;
            this.customerIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.customerIdTextBox.Lines = new string[0];
            this.customerIdTextBox.MaxLength = 32767;
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.PasswordChar = '\0';
            this.customerIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customerIdTextBox.SelectedText = "";
            this.customerIdTextBox.SelectionLength = 0;
            this.customerIdTextBox.SelectionStart = 0;
            this.customerIdTextBox.ShortcutsEnabled = true;
            this.customerIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.customerIdTextBox.UseSelectable = true;
            this.customerIdTextBox.UseStyleColors = true;
            this.customerIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customerIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customerIdTextBox.TextChanged += new System.EventHandler(this.input_searchChanged);
            // 
            // customerListDataGridView
            // 
            this.customerListDataGridView.AllowUserToAddRows = false;
            this.customerListDataGridView.AllowUserToDeleteRows = false;
            this.customerListDataGridView.AllowUserToOrderColumns = true;
            this.customerListDataGridView.AllowUserToResizeColumns = false;
            this.customerListDataGridView.AllowUserToResizeRows = false;
            this.customerListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedCustomerColumn,
            this.customerIDColumn,
            this.customerNameColumn,
            this.customerEmailColumn,
            this.customerAgeColumn,
            this.genderColumn,
            this.customerMobilePhoneNoColumn,
            this.customerAddressColumn});
            resources.ApplyResources(this.customerListDataGridView, "customerListDataGridView");
            this.customerListDataGridView.MultiSelect = false;
            this.customerListDataGridView.Name = "customerListDataGridView";
            this.customerListDataGridView.RowHeadersVisible = false;
            this.customerListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // recoverButton
            // 
            resources.ApplyResources(this.recoverButton, "recoverButton");
            this.recoverButton.Highlight = true;
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.recoverButton.UseSelectable = true;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // selectAllButton
            // 
            resources.ApplyResources(this.selectAllButton, "selectAllButton");
            this.selectAllButton.Highlight = true;
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.selectAllButton.UseSelectable = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllButton
            // 
            resources.ApplyResources(this.deselectAllButton, "deselectAllButton");
            this.deselectAllButton.Highlight = true;
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deselectAllButton.UseSelectable = true;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // permanentlyDeleteButton
            // 
            resources.ApplyResources(this.permanentlyDeleteButton, "permanentlyDeleteButton");
            this.permanentlyDeleteButton.Highlight = true;
            this.permanentlyDeleteButton.Name = "permanentlyDeleteButton";
            this.permanentlyDeleteButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.permanentlyDeleteButton.UseSelectable = true;
            this.permanentlyDeleteButton.Click += new System.EventHandler(this.permanentlyDeleteButton_Click);
            // 
            // selectedCustomerColumn
            // 
            this.selectedCustomerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedCustomerColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedCustomerColumn, "selectedCustomerColumn");
            this.selectedCustomerColumn.Name = "selectedCustomerColumn";
            // 
            // customerIDColumn
            // 
            this.customerIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerIDColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.customerIDColumn, "customerIDColumn");
            this.customerIDColumn.Name = "customerIDColumn";
            this.customerIDColumn.ReadOnly = true;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.customerNameColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.customerNameColumn, "customerNameColumn");
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            // 
            // customerEmailColumn
            // 
            this.customerEmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerEmailColumn.FillWeight = 83.48683F;
            resources.ApplyResources(this.customerEmailColumn, "customerEmailColumn");
            this.customerEmailColumn.Name = "customerEmailColumn";
            this.customerEmailColumn.ReadOnly = true;
            // 
            // customerAgeColumn
            // 
            this.customerAgeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.customerAgeColumn, "customerAgeColumn");
            this.customerAgeColumn.Name = "customerAgeColumn";
            this.customerAgeColumn.ReadOnly = true;
            // 
            // genderColumn
            // 
            this.genderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.genderColumn, "genderColumn");
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            // 
            // customerMobilePhoneNoColumn
            // 
            this.customerMobilePhoneNoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.customerMobilePhoneNoColumn, "customerMobilePhoneNoColumn");
            this.customerMobilePhoneNoColumn.Name = "customerMobilePhoneNoColumn";
            this.customerMobilePhoneNoColumn.ReadOnly = true;
            // 
            // customerAddressColumn
            // 
            this.customerAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.customerAddressColumn, "customerAddressColumn");
            this.customerAddressColumn.Name = "customerAddressColumn";
            this.customerAddressColumn.ReadOnly = true;
            // 
            // RecycleBinUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.permanentlyDeleteButton);
            this.Controls.Add(this.customerListDataGridView);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Name = "RecycleBinUserCtrl";
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox customerGivenNameTextBox;
        private MetroFramework.Controls.MetroLabel customerGivenNameLabel;
        private MetroFramework.Controls.MetroTextBox customerSurnameTextBox;
        private MetroFramework.Controls.MetroLabel customerSurnameLabel;
        private MetroFramework.Controls.MetroLabel customerIdLabel;
        private MetroFramework.Controls.MetroTextBox customerIdTextBox;
        private MetroFramework.Controls.MetroButton resetButton;
        private System.Windows.Forms.DataGridView customerListDataGridView;
        private MetroFramework.Controls.MetroButton recoverButton;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private MetroFramework.Controls.MetroButton permanentlyDeleteButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedCustomerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMobilePhoneNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressColumn;
    }
}
