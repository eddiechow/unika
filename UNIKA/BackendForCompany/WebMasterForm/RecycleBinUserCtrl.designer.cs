namespace BackendForCompany.WebMasterForm
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
            this.recycleBinTabControl = new MetroFramework.Controls.MetroTabControl();
            this.staffRecycleBinTabPage = new MetroFramework.Controls.MetroTabPage();
            this.staffRecoverButton = new MetroFramework.Controls.MetroButton();
            this.staffSelectAllButton = new MetroFramework.Controls.MetroButton();
            this.staffDeselectAllButton = new MetroFramework.Controls.MetroButton();
            this.sfattSearchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.staffEmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.staffSurnameLabel = new System.Windows.Forms.Label();
            this.staffSurnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.staffGivenNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.staffGivenNameLabel = new System.Windows.Forms.Label();
            this.staffIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.staffIDLabel = new System.Windows.Forms.Label();
            this.staffResetButton = new MetroFramework.Controls.MetroButton();
            this.staffPermanentlyDeleteButton = new MetroFramework.Controls.MetroButton();
            this.staffListDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedStaffColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StaffIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffGivenNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffDateDeletedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierRecycleBinTabPage = new MetroFramework.Controls.MetroTabPage();
            this.supplierRecoverButton = new MetroFramework.Controls.MetroButton();
            this.supplierSelectAllButton = new MetroFramework.Controls.MetroButton();
            this.supplierDeselectAllButton = new MetroFramework.Controls.MetroButton();
            this.supplierPermanentlyDeleteButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierEmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.supplierEmailLabel = new System.Windows.Forms.Label();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.supplierNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.supplierContactNoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.supplierContactNoLabel = new System.Windows.Forms.Label();
            this.supplierIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.supplierIDLabel = new System.Windows.Forms.Label();
            this.supplierResetButton = new MetroFramework.Controls.MetroButton();
            this.supplierListDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedSupplierColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SupplierIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierContactNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDeletedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recycleBinTabControl.SuspendLayout();
            this.staffRecycleBinTabPage.SuspendLayout();
            this.sfattSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffListDataGridView)).BeginInit();
            this.supplierRecycleBinTabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recycleBinTabControl
            // 
            resources.ApplyResources(this.recycleBinTabControl, "recycleBinTabControl");
            this.recycleBinTabControl.Controls.Add(this.staffRecycleBinTabPage);
            this.recycleBinTabControl.Controls.Add(this.supplierRecycleBinTabPage);
            this.recycleBinTabControl.Name = "recycleBinTabControl";
            this.recycleBinTabControl.SelectedIndex = 0;
            this.recycleBinTabControl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.recycleBinTabControl.UseSelectable = true;
            // 
            // staffRecycleBinTabPage
            // 
            resources.ApplyResources(this.staffRecycleBinTabPage, "staffRecycleBinTabPage");
            this.staffRecycleBinTabPage.Controls.Add(this.staffRecoverButton);
            this.staffRecycleBinTabPage.Controls.Add(this.staffSelectAllButton);
            this.staffRecycleBinTabPage.Controls.Add(this.staffDeselectAllButton);
            this.staffRecycleBinTabPage.Controls.Add(this.sfattSearchPanel);
            this.staffRecycleBinTabPage.Controls.Add(this.staffPermanentlyDeleteButton);
            this.staffRecycleBinTabPage.Controls.Add(this.staffListDataGridView);
            this.staffRecycleBinTabPage.HorizontalScrollbarBarColor = true;
            this.staffRecycleBinTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.staffRecycleBinTabPage.HorizontalScrollbarSize = 10;
            this.staffRecycleBinTabPage.Name = "staffRecycleBinTabPage";
            this.staffRecycleBinTabPage.VerticalScrollbarBarColor = true;
            this.staffRecycleBinTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.staffRecycleBinTabPage.VerticalScrollbarSize = 10;
            // 
            // staffRecoverButton
            // 
            resources.ApplyResources(this.staffRecoverButton, "staffRecoverButton");
            this.staffRecoverButton.Highlight = true;
            this.staffRecoverButton.Name = "staffRecoverButton";
            this.staffRecoverButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffRecoverButton.UseSelectable = true;
            this.staffRecoverButton.Click += new System.EventHandler(this.staffRecoverButton_Click);
            // 
            // staffSelectAllButton
            // 
            resources.ApplyResources(this.staffSelectAllButton, "staffSelectAllButton");
            this.staffSelectAllButton.Highlight = true;
            this.staffSelectAllButton.Name = "staffSelectAllButton";
            this.staffSelectAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffSelectAllButton.UseSelectable = true;
            this.staffSelectAllButton.Click += new System.EventHandler(this.staffSelectAllButton_Click);
            // 
            // staffDeselectAllButton
            // 
            resources.ApplyResources(this.staffDeselectAllButton, "staffDeselectAllButton");
            this.staffDeselectAllButton.Highlight = true;
            this.staffDeselectAllButton.Name = "staffDeselectAllButton";
            this.staffDeselectAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffDeselectAllButton.UseSelectable = true;
            this.staffDeselectAllButton.Click += new System.EventHandler(this.staffDeselectAllButton_Click);
            // 
            // sfattSearchPanel
            // 
            resources.ApplyResources(this.sfattSearchPanel, "sfattSearchPanel");
            this.sfattSearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.sfattSearchPanel.Controls.Add(this.staffEmailTextBox, 7, 0);
            this.sfattSearchPanel.Controls.Add(this.label9, 6, 0);
            this.sfattSearchPanel.Controls.Add(this.staffSurnameLabel, 2, 0);
            this.sfattSearchPanel.Controls.Add(this.staffSurnameTextBox, 3, 0);
            this.sfattSearchPanel.Controls.Add(this.staffGivenNameTextBox, 5, 0);
            this.sfattSearchPanel.Controls.Add(this.staffGivenNameLabel, 4, 0);
            this.sfattSearchPanel.Controls.Add(this.staffIdTextBox, 1, 0);
            this.sfattSearchPanel.Controls.Add(this.staffIDLabel, 0, 0);
            this.sfattSearchPanel.Controls.Add(this.staffResetButton, 8, 0);
            this.sfattSearchPanel.Name = "sfattSearchPanel";
            // 
            // staffEmailTextBox
            // 
            resources.ApplyResources(this.staffEmailTextBox, "staffEmailTextBox");
            // 
            // 
            // 
            this.staffEmailTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.staffEmailTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.staffEmailTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.staffEmailTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.staffEmailTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.staffEmailTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.staffEmailTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.staffEmailTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.staffEmailTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.staffEmailTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.staffEmailTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.staffEmailTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.staffEmailTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.staffEmailTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.staffEmailTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.staffEmailTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.staffEmailTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.staffEmailTextBox.CustomButton.Name = "";
            this.staffEmailTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.staffEmailTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.staffEmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.staffEmailTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.staffEmailTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.staffEmailTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.staffEmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.staffEmailTextBox.CustomButton.UseSelectable = true;
            this.staffEmailTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.staffEmailTextBox.Lines = new string[0];
            this.staffEmailTextBox.MaxLength = 32767;
            this.staffEmailTextBox.Name = "staffEmailTextBox";
            this.staffEmailTextBox.PasswordChar = '\0';
            this.staffEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.staffEmailTextBox.SelectedText = "";
            this.staffEmailTextBox.SelectionLength = 0;
            this.staffEmailTextBox.SelectionStart = 0;
            this.staffEmailTextBox.ShortcutsEnabled = true;
            this.staffEmailTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffEmailTextBox.UseSelectable = true;
            this.staffEmailTextBox.UseStyleColors = true;
            this.staffEmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.staffEmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.staffEmailTextBox.TextChanged += new System.EventHandler(this.input_staffSearchChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // staffSurnameLabel
            // 
            resources.ApplyResources(this.staffSurnameLabel, "staffSurnameLabel");
            this.staffSurnameLabel.Name = "staffSurnameLabel";
            // 
            // staffSurnameTextBox
            // 
            resources.ApplyResources(this.staffSurnameTextBox, "staffSurnameTextBox");
            // 
            // 
            // 
            this.staffSurnameTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.staffSurnameTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.staffSurnameTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.staffSurnameTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.staffSurnameTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.staffSurnameTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.staffSurnameTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.staffSurnameTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.staffSurnameTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.staffSurnameTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.staffSurnameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.staffSurnameTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.staffSurnameTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.staffSurnameTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.staffSurnameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.staffSurnameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.staffSurnameTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.staffSurnameTextBox.CustomButton.Name = "";
            this.staffSurnameTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.staffSurnameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.staffSurnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.staffSurnameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.staffSurnameTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.staffSurnameTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.staffSurnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.staffSurnameTextBox.CustomButton.UseSelectable = true;
            this.staffSurnameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.staffSurnameTextBox.Lines = new string[0];
            this.staffSurnameTextBox.MaxLength = 32767;
            this.staffSurnameTextBox.Name = "staffSurnameTextBox";
            this.staffSurnameTextBox.PasswordChar = '\0';
            this.staffSurnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.staffSurnameTextBox.SelectedText = "";
            this.staffSurnameTextBox.SelectionLength = 0;
            this.staffSurnameTextBox.SelectionStart = 0;
            this.staffSurnameTextBox.ShortcutsEnabled = true;
            this.staffSurnameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffSurnameTextBox.UseSelectable = true;
            this.staffSurnameTextBox.UseStyleColors = true;
            this.staffSurnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.staffSurnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.staffSurnameTextBox.TextChanged += new System.EventHandler(this.input_staffSearchChanged);
            // 
            // staffGivenNameTextBox
            // 
            resources.ApplyResources(this.staffGivenNameTextBox, "staffGivenNameTextBox");
            // 
            // 
            // 
            this.staffGivenNameTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.staffGivenNameTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.staffGivenNameTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor2")));
            this.staffGivenNameTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize2")));
            this.staffGivenNameTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode2")));
            this.staffGivenNameTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.staffGivenNameTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout2")));
            this.staffGivenNameTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.staffGivenNameTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle2")));
            this.staffGivenNameTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.staffGivenNameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.staffGivenNameTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign2")));
            this.staffGivenNameTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex2")));
            this.staffGivenNameTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey2");
            this.staffGivenNameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.staffGivenNameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.staffGivenNameTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize2")));
            this.staffGivenNameTextBox.CustomButton.Name = "";
            this.staffGivenNameTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft2")));
            this.staffGivenNameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.staffGivenNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.staffGivenNameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.staffGivenNameTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign2")));
            this.staffGivenNameTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation2")));
            this.staffGivenNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.staffGivenNameTextBox.CustomButton.UseSelectable = true;
            this.staffGivenNameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.staffGivenNameTextBox.Lines = new string[0];
            this.staffGivenNameTextBox.MaxLength = 32767;
            this.staffGivenNameTextBox.Name = "staffGivenNameTextBox";
            this.staffGivenNameTextBox.PasswordChar = '\0';
            this.staffGivenNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.staffGivenNameTextBox.SelectedText = "";
            this.staffGivenNameTextBox.SelectionLength = 0;
            this.staffGivenNameTextBox.SelectionStart = 0;
            this.staffGivenNameTextBox.ShortcutsEnabled = true;
            this.staffGivenNameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffGivenNameTextBox.UseSelectable = true;
            this.staffGivenNameTextBox.UseStyleColors = true;
            this.staffGivenNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.staffGivenNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.staffGivenNameTextBox.TextChanged += new System.EventHandler(this.input_staffSearchChanged);
            // 
            // staffGivenNameLabel
            // 
            resources.ApplyResources(this.staffGivenNameLabel, "staffGivenNameLabel");
            this.staffGivenNameLabel.Name = "staffGivenNameLabel";
            // 
            // staffIdTextBox
            // 
            resources.ApplyResources(this.staffIdTextBox, "staffIdTextBox");
            this.staffIdTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.staffIdTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.staffIdTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3");
            this.staffIdTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName3");
            this.staffIdTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor3")));
            this.staffIdTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize3")));
            this.staffIdTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode3")));
            this.staffIdTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage3")));
            this.staffIdTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout3")));
            this.staffIdTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock3")));
            this.staffIdTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle3")));
            this.staffIdTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font3")));
            this.staffIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.staffIdTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign3")));
            this.staffIdTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex3")));
            this.staffIdTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey3");
            this.staffIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.staffIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.staffIdTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize3")));
            this.staffIdTextBox.CustomButton.Name = "";
            this.staffIdTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft3")));
            this.staffIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.staffIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.staffIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.staffIdTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign3")));
            this.staffIdTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation3")));
            this.staffIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.staffIdTextBox.CustomButton.UseSelectable = true;
            this.staffIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.staffIdTextBox.Lines = new string[0];
            this.staffIdTextBox.MaxLength = 32767;
            this.staffIdTextBox.Name = "staffIdTextBox";
            this.staffIdTextBox.PasswordChar = '\0';
            this.staffIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.staffIdTextBox.SelectedText = "";
            this.staffIdTextBox.SelectionLength = 0;
            this.staffIdTextBox.SelectionStart = 0;
            this.staffIdTextBox.ShortcutsEnabled = true;
            this.staffIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffIdTextBox.UseSelectable = true;
            this.staffIdTextBox.UseStyleColors = true;
            this.staffIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.staffIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.staffIdTextBox.TextChanged += new System.EventHandler(this.input_staffSearchChanged);
            // 
            // staffIDLabel
            // 
            resources.ApplyResources(this.staffIDLabel, "staffIDLabel");
            this.staffIDLabel.Name = "staffIDLabel";
            // 
            // staffResetButton
            // 
            resources.ApplyResources(this.staffResetButton, "staffResetButton");
            this.staffResetButton.Highlight = true;
            this.staffResetButton.Name = "staffResetButton";
            this.staffResetButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffResetButton.UseSelectable = true;
            this.staffResetButton.Click += new System.EventHandler(this.staffResetButton_Click);
            // 
            // staffPermanentlyDeleteButton
            // 
            resources.ApplyResources(this.staffPermanentlyDeleteButton, "staffPermanentlyDeleteButton");
            this.staffPermanentlyDeleteButton.Highlight = true;
            this.staffPermanentlyDeleteButton.Name = "staffPermanentlyDeleteButton";
            this.staffPermanentlyDeleteButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffPermanentlyDeleteButton.UseSelectable = true;
            this.staffPermanentlyDeleteButton.Click += new System.EventHandler(this.staffPermanentlyDeleteButton_Click);
            // 
            // staffListDataGridView
            // 
            resources.ApplyResources(this.staffListDataGridView, "staffListDataGridView");
            this.staffListDataGridView.AllowUserToAddRows = false;
            this.staffListDataGridView.AllowUserToDeleteRows = false;
            this.staffListDataGridView.AllowUserToOrderColumns = true;
            this.staffListDataGridView.AllowUserToResizeColumns = false;
            this.staffListDataGridView.AllowUserToResizeRows = false;
            this.staffListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staffListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedStaffColumn,
            this.StaffIDColumn,
            this.StaffSurnameColumn,
            this.StaffGivenNameColumn,
            this.StaffPositionColumn,
            this.StaffEmailColumn,
            this.StaffDateDeletedColumn});
            this.staffListDataGridView.Name = "staffListDataGridView";
            this.staffListDataGridView.RowHeadersVisible = false;
            this.staffListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // SelectedStaffColumn
            // 
            this.SelectedStaffColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.SelectedStaffColumn, "SelectedStaffColumn");
            this.SelectedStaffColumn.Name = "SelectedStaffColumn";
            // 
            // StaffIDColumn
            // 
            this.StaffIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffIDColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.StaffIDColumn, "StaffIDColumn");
            this.StaffIDColumn.Name = "StaffIDColumn";
            this.StaffIDColumn.ReadOnly = true;
            // 
            // StaffSurnameColumn
            // 
            this.StaffSurnameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.StaffSurnameColumn, "StaffSurnameColumn");
            this.StaffSurnameColumn.Name = "StaffSurnameColumn";
            this.StaffSurnameColumn.ReadOnly = true;
            // 
            // StaffGivenNameColumn
            // 
            this.StaffGivenNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.StaffGivenNameColumn, "StaffGivenNameColumn");
            this.StaffGivenNameColumn.Name = "StaffGivenNameColumn";
            this.StaffGivenNameColumn.ReadOnly = true;
            // 
            // StaffPositionColumn
            // 
            this.StaffPositionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StaffPositionColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.StaffPositionColumn, "StaffPositionColumn");
            this.StaffPositionColumn.Name = "StaffPositionColumn";
            this.StaffPositionColumn.ReadOnly = true;
            // 
            // StaffEmailColumn
            // 
            this.StaffEmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.StaffEmailColumn, "StaffEmailColumn");
            this.StaffEmailColumn.Name = "StaffEmailColumn";
            this.StaffEmailColumn.ReadOnly = true;
            // 
            // StaffDateDeletedColumn
            // 
            this.StaffDateDeletedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.StaffDateDeletedColumn, "StaffDateDeletedColumn");
            this.StaffDateDeletedColumn.Name = "StaffDateDeletedColumn";
            this.StaffDateDeletedColumn.ReadOnly = true;
            // 
            // supplierRecycleBinTabPage
            // 
            resources.ApplyResources(this.supplierRecycleBinTabPage, "supplierRecycleBinTabPage");
            this.supplierRecycleBinTabPage.Controls.Add(this.supplierRecoverButton);
            this.supplierRecycleBinTabPage.Controls.Add(this.supplierSelectAllButton);
            this.supplierRecycleBinTabPage.Controls.Add(this.supplierDeselectAllButton);
            this.supplierRecycleBinTabPage.Controls.Add(this.supplierPermanentlyDeleteButton);
            this.supplierRecycleBinTabPage.Controls.Add(this.tableLayoutPanel4);
            this.supplierRecycleBinTabPage.Controls.Add(this.supplierListDataGridView);
            this.supplierRecycleBinTabPage.HorizontalScrollbarBarColor = true;
            this.supplierRecycleBinTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.supplierRecycleBinTabPage.HorizontalScrollbarSize = 10;
            this.supplierRecycleBinTabPage.Name = "supplierRecycleBinTabPage";
            this.supplierRecycleBinTabPage.VerticalScrollbarBarColor = true;
            this.supplierRecycleBinTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.supplierRecycleBinTabPage.VerticalScrollbarSize = 10;
            // 
            // supplierRecoverButton
            // 
            resources.ApplyResources(this.supplierRecoverButton, "supplierRecoverButton");
            this.supplierRecoverButton.Highlight = true;
            this.supplierRecoverButton.Name = "supplierRecoverButton";
            this.supplierRecoverButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierRecoverButton.UseSelectable = true;
            this.supplierRecoverButton.Click += new System.EventHandler(this.supplierRecoverButton_Click);
            // 
            // supplierSelectAllButton
            // 
            resources.ApplyResources(this.supplierSelectAllButton, "supplierSelectAllButton");
            this.supplierSelectAllButton.Highlight = true;
            this.supplierSelectAllButton.Name = "supplierSelectAllButton";
            this.supplierSelectAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierSelectAllButton.UseSelectable = true;
            this.supplierSelectAllButton.Click += new System.EventHandler(this.supplierSelectAllButton_Click);
            // 
            // supplierDeselectAllButton
            // 
            resources.ApplyResources(this.supplierDeselectAllButton, "supplierDeselectAllButton");
            this.supplierDeselectAllButton.Highlight = true;
            this.supplierDeselectAllButton.Name = "supplierDeselectAllButton";
            this.supplierDeselectAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierDeselectAllButton.UseSelectable = true;
            this.supplierDeselectAllButton.Click += new System.EventHandler(this.supplierDeselectAllButton_Click);
            // 
            // supplierPermanentlyDeleteButton
            // 
            resources.ApplyResources(this.supplierPermanentlyDeleteButton, "supplierPermanentlyDeleteButton");
            this.supplierPermanentlyDeleteButton.Highlight = true;
            this.supplierPermanentlyDeleteButton.Name = "supplierPermanentlyDeleteButton";
            this.supplierPermanentlyDeleteButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierPermanentlyDeleteButton.UseSelectable = true;
            this.supplierPermanentlyDeleteButton.Click += new System.EventHandler(this.supplierPermanentlyDeleteButton_Click);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.Controls.Add(this.supplierEmailTextBox, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierEmailLabel, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierNameLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierNameTextBox, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierContactNoTextBox, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierContactNoLabel, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierIDTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierIDLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.supplierResetButton, 8, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // supplierEmailTextBox
            // 
            resources.ApplyResources(this.supplierEmailTextBox, "supplierEmailTextBox");
            // 
            // 
            // 
            this.supplierEmailTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription4");
            this.supplierEmailTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName4");
            this.supplierEmailTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor4")));
            this.supplierEmailTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize4")));
            this.supplierEmailTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode4")));
            this.supplierEmailTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage4")));
            this.supplierEmailTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout4")));
            this.supplierEmailTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock4")));
            this.supplierEmailTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle4")));
            this.supplierEmailTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font4")));
            this.supplierEmailTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.supplierEmailTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign4")));
            this.supplierEmailTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex4")));
            this.supplierEmailTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey4");
            this.supplierEmailTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.supplierEmailTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.supplierEmailTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize4")));
            this.supplierEmailTextBox.CustomButton.Name = "";
            this.supplierEmailTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft4")));
            this.supplierEmailTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.supplierEmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierEmailTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.supplierEmailTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign4")));
            this.supplierEmailTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation4")));
            this.supplierEmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierEmailTextBox.CustomButton.UseSelectable = true;
            this.supplierEmailTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.supplierEmailTextBox.Lines = new string[0];
            this.supplierEmailTextBox.MaxLength = 32767;
            this.supplierEmailTextBox.Name = "supplierEmailTextBox";
            this.supplierEmailTextBox.PasswordChar = '\0';
            this.supplierEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.supplierEmailTextBox.SelectedText = "";
            this.supplierEmailTextBox.SelectionLength = 0;
            this.supplierEmailTextBox.SelectionStart = 0;
            this.supplierEmailTextBox.ShortcutsEnabled = true;
            this.supplierEmailTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierEmailTextBox.UseSelectable = true;
            this.supplierEmailTextBox.UseStyleColors = true;
            this.supplierEmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supplierEmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.supplierEmailTextBox.TextChanged += new System.EventHandler(this.input_supplierSearchChanged);
            // 
            // supplierEmailLabel
            // 
            resources.ApplyResources(this.supplierEmailLabel, "supplierEmailLabel");
            this.supplierEmailLabel.Name = "supplierEmailLabel";
            // 
            // supplierNameLabel
            // 
            resources.ApplyResources(this.supplierNameLabel, "supplierNameLabel");
            this.supplierNameLabel.Name = "supplierNameLabel";
            // 
            // supplierNameTextBox
            // 
            resources.ApplyResources(this.supplierNameTextBox, "supplierNameTextBox");
            // 
            // 
            // 
            this.supplierNameTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription5");
            this.supplierNameTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName5");
            this.supplierNameTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor5")));
            this.supplierNameTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize5")));
            this.supplierNameTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode5")));
            this.supplierNameTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage5")));
            this.supplierNameTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout5")));
            this.supplierNameTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock5")));
            this.supplierNameTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle5")));
            this.supplierNameTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font5")));
            this.supplierNameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.supplierNameTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign5")));
            this.supplierNameTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex5")));
            this.supplierNameTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey5");
            this.supplierNameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode5")));
            this.supplierNameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location5")));
            this.supplierNameTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize5")));
            this.supplierNameTextBox.CustomButton.Name = "";
            this.supplierNameTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft5")));
            this.supplierNameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size5")));
            this.supplierNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierNameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex5")));
            this.supplierNameTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign5")));
            this.supplierNameTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation5")));
            this.supplierNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierNameTextBox.CustomButton.UseSelectable = true;
            this.supplierNameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible5")));
            this.supplierNameTextBox.Lines = new string[0];
            this.supplierNameTextBox.MaxLength = 32767;
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.PasswordChar = '\0';
            this.supplierNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.supplierNameTextBox.SelectedText = "";
            this.supplierNameTextBox.SelectionLength = 0;
            this.supplierNameTextBox.SelectionStart = 0;
            this.supplierNameTextBox.ShortcutsEnabled = true;
            this.supplierNameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierNameTextBox.UseSelectable = true;
            this.supplierNameTextBox.UseStyleColors = true;
            this.supplierNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supplierNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.supplierNameTextBox.TextChanged += new System.EventHandler(this.input_supplierSearchChanged);
            // 
            // supplierContactNoTextBox
            // 
            resources.ApplyResources(this.supplierContactNoTextBox, "supplierContactNoTextBox");
            // 
            // 
            // 
            this.supplierContactNoTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription6");
            this.supplierContactNoTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName6");
            this.supplierContactNoTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor6")));
            this.supplierContactNoTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize6")));
            this.supplierContactNoTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode6")));
            this.supplierContactNoTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage6")));
            this.supplierContactNoTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout6")));
            this.supplierContactNoTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock6")));
            this.supplierContactNoTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle6")));
            this.supplierContactNoTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font6")));
            this.supplierContactNoTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.supplierContactNoTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign6")));
            this.supplierContactNoTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex6")));
            this.supplierContactNoTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey6");
            this.supplierContactNoTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode6")));
            this.supplierContactNoTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location6")));
            this.supplierContactNoTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize6")));
            this.supplierContactNoTextBox.CustomButton.Name = "";
            this.supplierContactNoTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft6")));
            this.supplierContactNoTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size6")));
            this.supplierContactNoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierContactNoTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex6")));
            this.supplierContactNoTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign6")));
            this.supplierContactNoTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation6")));
            this.supplierContactNoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierContactNoTextBox.CustomButton.UseSelectable = true;
            this.supplierContactNoTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible6")));
            this.supplierContactNoTextBox.Lines = new string[0];
            this.supplierContactNoTextBox.MaxLength = 32767;
            this.supplierContactNoTextBox.Name = "supplierContactNoTextBox";
            this.supplierContactNoTextBox.PasswordChar = '\0';
            this.supplierContactNoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.supplierContactNoTextBox.SelectedText = "";
            this.supplierContactNoTextBox.SelectionLength = 0;
            this.supplierContactNoTextBox.SelectionStart = 0;
            this.supplierContactNoTextBox.ShortcutsEnabled = true;
            this.supplierContactNoTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierContactNoTextBox.UseSelectable = true;
            this.supplierContactNoTextBox.UseStyleColors = true;
            this.supplierContactNoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supplierContactNoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.supplierContactNoTextBox.TextChanged += new System.EventHandler(this.input_supplierSearchChanged);
            // 
            // supplierContactNoLabel
            // 
            resources.ApplyResources(this.supplierContactNoLabel, "supplierContactNoLabel");
            this.supplierContactNoLabel.Name = "supplierContactNoLabel";
            // 
            // supplierIDTextBox
            // 
            resources.ApplyResources(this.supplierIDTextBox, "supplierIDTextBox");
            this.supplierIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplierIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.supplierIDTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription7");
            this.supplierIDTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName7");
            this.supplierIDTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor7")));
            this.supplierIDTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize7")));
            this.supplierIDTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode7")));
            this.supplierIDTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage7")));
            this.supplierIDTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout7")));
            this.supplierIDTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock7")));
            this.supplierIDTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle7")));
            this.supplierIDTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font7")));
            this.supplierIDTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.supplierIDTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign7")));
            this.supplierIDTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex7")));
            this.supplierIDTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey7");
            this.supplierIDTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode7")));
            this.supplierIDTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location7")));
            this.supplierIDTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize7")));
            this.supplierIDTextBox.CustomButton.Name = "";
            this.supplierIDTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft7")));
            this.supplierIDTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size7")));
            this.supplierIDTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierIDTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex7")));
            this.supplierIDTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign7")));
            this.supplierIDTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation7")));
            this.supplierIDTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierIDTextBox.CustomButton.UseSelectable = true;
            this.supplierIDTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible7")));
            this.supplierIDTextBox.Lines = new string[0];
            this.supplierIDTextBox.MaxLength = 32767;
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.PasswordChar = '\0';
            this.supplierIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.supplierIDTextBox.SelectedText = "";
            this.supplierIDTextBox.SelectionLength = 0;
            this.supplierIDTextBox.SelectionStart = 0;
            this.supplierIDTextBox.ShortcutsEnabled = true;
            this.supplierIDTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierIDTextBox.UseSelectable = true;
            this.supplierIDTextBox.UseStyleColors = true;
            this.supplierIDTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supplierIDTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.supplierIDTextBox.TextChanged += new System.EventHandler(this.input_supplierSearchChanged);
            // 
            // supplierIDLabel
            // 
            resources.ApplyResources(this.supplierIDLabel, "supplierIDLabel");
            this.supplierIDLabel.Name = "supplierIDLabel";
            // 
            // supplierResetButton
            // 
            resources.ApplyResources(this.supplierResetButton, "supplierResetButton");
            this.supplierResetButton.Highlight = true;
            this.supplierResetButton.Name = "supplierResetButton";
            this.supplierResetButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierResetButton.UseSelectable = true;
            this.supplierResetButton.Click += new System.EventHandler(this.supplierResetButton_Click);
            // 
            // supplierListDataGridView
            // 
            resources.ApplyResources(this.supplierListDataGridView, "supplierListDataGridView");
            this.supplierListDataGridView.AllowUserToAddRows = false;
            this.supplierListDataGridView.AllowUserToDeleteRows = false;
            this.supplierListDataGridView.AllowUserToOrderColumns = true;
            this.supplierListDataGridView.AllowUserToResizeColumns = false;
            this.supplierListDataGridView.AllowUserToResizeRows = false;
            this.supplierListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.supplierListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.supplierListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedSupplierColumn,
            this.SupplierIDColumn,
            this.SupplierNameColumn,
            this.SupplierTypeColumn,
            this.SupplierContactNoColumn,
            this.SupplierEmailColumn,
            this.SupplierAddressColumn,
            this.DateDeletedColumn});
            this.supplierListDataGridView.Name = "supplierListDataGridView";
            this.supplierListDataGridView.RowHeadersVisible = false;
            this.supplierListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // SelectedSupplierColumn
            // 
            this.SelectedSupplierColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.SelectedSupplierColumn, "SelectedSupplierColumn");
            this.SelectedSupplierColumn.Name = "SelectedSupplierColumn";
            // 
            // SupplierIDColumn
            // 
            this.SupplierIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplierIDColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.SupplierIDColumn, "SupplierIDColumn");
            this.SupplierIDColumn.Name = "SupplierIDColumn";
            this.SupplierIDColumn.ReadOnly = true;
            // 
            // SupplierNameColumn
            // 
            this.SupplierNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.SupplierNameColumn, "SupplierNameColumn");
            this.SupplierNameColumn.Name = "SupplierNameColumn";
            this.SupplierNameColumn.ReadOnly = true;
            // 
            // SupplierTypeColumn
            // 
            this.SupplierTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.SupplierTypeColumn, "SupplierTypeColumn");
            this.SupplierTypeColumn.Name = "SupplierTypeColumn";
            this.SupplierTypeColumn.ReadOnly = true;
            // 
            // SupplierContactNoColumn
            // 
            this.SupplierContactNoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupplierContactNoColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.SupplierContactNoColumn, "SupplierContactNoColumn");
            this.SupplierContactNoColumn.Name = "SupplierContactNoColumn";
            this.SupplierContactNoColumn.ReadOnly = true;
            // 
            // SupplierEmailColumn
            // 
            this.SupplierEmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.SupplierEmailColumn, "SupplierEmailColumn");
            this.SupplierEmailColumn.Name = "SupplierEmailColumn";
            this.SupplierEmailColumn.ReadOnly = true;
            // 
            // SupplierAddressColumn
            // 
            this.SupplierAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.SupplierAddressColumn, "SupplierAddressColumn");
            this.SupplierAddressColumn.Name = "SupplierAddressColumn";
            this.SupplierAddressColumn.ReadOnly = true;
            // 
            // DateDeletedColumn
            // 
            this.DateDeletedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.DateDeletedColumn, "DateDeletedColumn");
            this.DateDeletedColumn.Name = "DateDeletedColumn";
            this.DateDeletedColumn.ReadOnly = true;
            // 
            // RecycleBinUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recycleBinTabControl);
            this.Name = "RecycleBinUserCtrl";
            this.recycleBinTabControl.ResumeLayout(false);
            this.staffRecycleBinTabPage.ResumeLayout(false);
            this.sfattSearchPanel.ResumeLayout(false);
            this.sfattSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffListDataGridView)).EndInit();
            this.supplierRecycleBinTabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl recycleBinTabControl;
        private MetroFramework.Controls.MetroTabPage staffRecycleBinTabPage;
        private MetroFramework.Controls.MetroTextBox staffIdTextBox;
        private System.Windows.Forms.Label staffSurnameLabel;
        private MetroFramework.Controls.MetroTextBox staffSurnameTextBox;
        private System.Windows.Forms.Label staffGivenNameLabel;
        private MetroFramework.Controls.MetroTextBox staffGivenNameTextBox;
        private System.Windows.Forms.DataGridView staffListDataGridView;
        private MetroFramework.Controls.MetroTabPage supplierRecycleBinTabPage;
        private System.Windows.Forms.DataGridView supplierListDataGridView;
        private System.Windows.Forms.TableLayoutPanel sfattSearchPanel;
        private MetroFramework.Controls.MetroTextBox staffEmailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label staffIDLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroTextBox supplierEmailTextBox;
        private System.Windows.Forms.Label supplierEmailLabel;
        private System.Windows.Forms.Label supplierNameLabel;
        private MetroFramework.Controls.MetroTextBox supplierNameTextBox;
        private MetroFramework.Controls.MetroTextBox supplierContactNoTextBox;
        private System.Windows.Forms.Label supplierContactNoLabel;
        private MetroFramework.Controls.MetroTextBox supplierIDTextBox;
        private System.Windows.Forms.Label supplierIDLabel;
        private MetroFramework.Controls.MetroButton staffRecoverButton;
        private MetroFramework.Controls.MetroButton staffSelectAllButton;
        private MetroFramework.Controls.MetroButton staffDeselectAllButton;
        private MetroFramework.Controls.MetroButton staffPermanentlyDeleteButton;
        private MetroFramework.Controls.MetroButton staffResetButton;
        private MetroFramework.Controls.MetroButton supplierRecoverButton;
        private MetroFramework.Controls.MetroButton supplierSelectAllButton;
        private MetroFramework.Controls.MetroButton supplierDeselectAllButton;
        private MetroFramework.Controls.MetroButton supplierPermanentlyDeleteButton;
        private MetroFramework.Controls.MetroButton supplierResetButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedStaffColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffSurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffGivenNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffDateDeletedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedSupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierContactNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDeletedColumn;
    }
}
