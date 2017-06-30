namespace BackendForCompany.ManagerForm
{
    partial class HandleEcommerceContentUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandleEcommerceContentUserCtrl));
            this.noticeListGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchAllButton = new MetroFramework.Controls.MetroButton();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.keywordLabel = new MetroFramework.Controls.MetroLabel();
            this.keywordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.listResetButton = new MetroFramework.Controls.MetroButton();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.noticeListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedNoticeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noticeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradChiContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedByColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tradChiContentErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.tradChiContentLabel = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.engContentErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.engContentLabel = new MetroFramework.Controls.MetroLabel();
            this.tradChiContentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.engContentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.illegalWordHintLabel = new MetroFramework.Controls.MetroLabel();
            this.resetFormButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.noticeListGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeListDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // noticeListGroupBox
            // 
            resources.ApplyResources(this.noticeListGroupBox, "noticeListGroupBox");
            this.noticeListGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.noticeListGroupBox.Controls.Add(this.listResetButton);
            this.noticeListGroupBox.Controls.Add(this.selectAllButton);
            this.noticeListGroupBox.Controls.Add(this.deselectAllButton);
            this.noticeListGroupBox.Controls.Add(this.noticeListDataGridView);
            this.noticeListGroupBox.Controls.Add(this.deleteButton);
            this.noticeListGroupBox.Name = "noticeListGroupBox";
            this.noticeListGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.searchAllButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.keywordLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.keywordTextBox, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // searchAllButton
            // 
            resources.ApplyResources(this.searchAllButton, "searchAllButton");
            this.searchAllButton.Highlight = true;
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.searchAllButton.UseSelectable = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Highlight = true;
            this.searchButton.Name = "searchButton";
            this.searchButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // keywordLabel
            // 
            resources.ApplyResources(this.keywordLabel, "keywordLabel");
            this.keywordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.keywordLabel.Name = "keywordLabel";
            // 
            // keywordTextBox
            // 
            resources.ApplyResources(this.keywordTextBox, "keywordTextBox");
            this.keywordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.keywordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.keywordTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.keywordTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.keywordTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.keywordTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.keywordTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.keywordTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.keywordTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.keywordTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.keywordTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.keywordTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.keywordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.keywordTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.keywordTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.keywordTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.keywordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.keywordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.keywordTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.keywordTextBox.CustomButton.Name = "";
            this.keywordTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.keywordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.keywordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keywordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.keywordTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.keywordTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.keywordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keywordTextBox.CustomButton.UseSelectable = true;
            this.keywordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.keywordTextBox.Lines = new string[0];
            this.keywordTextBox.MaxLength = 32767;
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.PasswordChar = '\0';
            this.keywordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keywordTextBox.SelectedText = "";
            this.keywordTextBox.SelectionLength = 0;
            this.keywordTextBox.SelectionStart = 0;
            this.keywordTextBox.ShortcutsEnabled = true;
            this.keywordTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.keywordTextBox.UseSelectable = true;
            this.keywordTextBox.UseStyleColors = true;
            this.keywordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keywordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listResetButton
            // 
            resources.ApplyResources(this.listResetButton, "listResetButton");
            this.listResetButton.Highlight = true;
            this.listResetButton.Name = "listResetButton";
            this.listResetButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.listResetButton.UseSelectable = true;
            this.listResetButton.Click += new System.EventHandler(this.listResetButton_Click);
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
            // noticeListDataGridView
            // 
            resources.ApplyResources(this.noticeListDataGridView, "noticeListDataGridView");
            this.noticeListDataGridView.AllowUserToAddRows = false;
            this.noticeListDataGridView.AllowUserToDeleteRows = false;
            this.noticeListDataGridView.AllowUserToResizeColumns = false;
            this.noticeListDataGridView.AllowUserToResizeRows = false;
            this.noticeListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.noticeListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.noticeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.noticeListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedNoticeColumn,
            this.noticeIdColumn,
            this.engContentColumn,
            this.tradChiContentColumn,
            this.releasedByColumn});
            this.noticeListDataGridView.MultiSelect = false;
            this.noticeListDataGridView.Name = "noticeListDataGridView";
            this.noticeListDataGridView.RowHeadersVisible = false;
            this.noticeListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.noticeListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.noticeListDataGridView_CellClick);
            // 
            // selectedNoticeColumn
            // 
            this.selectedNoticeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedNoticeColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedNoticeColumn, "selectedNoticeColumn");
            this.selectedNoticeColumn.Name = "selectedNoticeColumn";
            // 
            // noticeIdColumn
            // 
            this.noticeIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noticeIdColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.noticeIdColumn, "noticeIdColumn");
            this.noticeIdColumn.Name = "noticeIdColumn";
            this.noticeIdColumn.ReadOnly = true;
            // 
            // engContentColumn
            // 
            this.engContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.engContentColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.engContentColumn, "engContentColumn");
            this.engContentColumn.Name = "engContentColumn";
            this.engContentColumn.ReadOnly = true;
            // 
            // tradChiContentColumn
            // 
            this.tradChiContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tradChiContentColumn.FillWeight = 83.48683F;
            resources.ApplyResources(this.tradChiContentColumn, "tradChiContentColumn");
            this.tradChiContentColumn.Name = "tradChiContentColumn";
            this.tradChiContentColumn.ReadOnly = true;
            // 
            // releasedByColumn
            // 
            this.releasedByColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.releasedByColumn, "releasedByColumn");
            this.releasedByColumn.Name = "releasedByColumn";
            this.releasedByColumn.ReadOnly = true;
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Highlight = true;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tradChiContentTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.engContentTextBox, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.Controls.Add(this.tradChiContentErrorLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tradChiContentLabel, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // tradChiContentErrorLabel
            // 
            resources.ApplyResources(this.tradChiContentErrorLabel, "tradChiContentErrorLabel");
            this.tradChiContentErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.tradChiContentErrorLabel.Name = "tradChiContentErrorLabel";
            this.tradChiContentErrorLabel.UseCustomForeColor = true;
            // 
            // tradChiContentLabel
            // 
            resources.ApplyResources(this.tradChiContentLabel, "tradChiContentLabel");
            this.tradChiContentLabel.Name = "tradChiContentLabel";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.Controls.Add(this.engContentErrorLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.engContentLabel, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // engContentErrorLabel
            // 
            resources.ApplyResources(this.engContentErrorLabel, "engContentErrorLabel");
            this.engContentErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.engContentErrorLabel.Name = "engContentErrorLabel";
            this.engContentErrorLabel.UseCustomForeColor = true;
            // 
            // engContentLabel
            // 
            resources.ApplyResources(this.engContentLabel, "engContentLabel");
            this.engContentLabel.Name = "engContentLabel";
            // 
            // tradChiContentTextBox
            // 
            resources.ApplyResources(this.tradChiContentTextBox, "tradChiContentTextBox");
            // 
            // 
            // 
            this.tradChiContentTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.tradChiContentTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.tradChiContentTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.tradChiContentTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.tradChiContentTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.tradChiContentTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.tradChiContentTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.tradChiContentTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.tradChiContentTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.tradChiContentTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.tradChiContentTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.tradChiContentTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.tradChiContentTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.tradChiContentTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.tradChiContentTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.tradChiContentTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.tradChiContentTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.tradChiContentTextBox.CustomButton.Name = "";
            this.tradChiContentTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.tradChiContentTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.tradChiContentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tradChiContentTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.tradChiContentTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.tradChiContentTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.tradChiContentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tradChiContentTextBox.CustomButton.UseSelectable = true;
            this.tradChiContentTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.tradChiContentTextBox.Lines = new string[0];
            this.tradChiContentTextBox.MaxLength = 32767;
            this.tradChiContentTextBox.Multiline = true;
            this.tradChiContentTextBox.Name = "tradChiContentTextBox";
            this.tradChiContentTextBox.PasswordChar = '\0';
            this.tradChiContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tradChiContentTextBox.SelectedText = "";
            this.tradChiContentTextBox.SelectionLength = 0;
            this.tradChiContentTextBox.SelectionStart = 0;
            this.tradChiContentTextBox.ShortcutsEnabled = true;
            this.tradChiContentTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tradChiContentTextBox.UseSelectable = true;
            this.tradChiContentTextBox.UseStyleColors = true;
            this.tradChiContentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tradChiContentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // engContentTextBox
            // 
            resources.ApplyResources(this.engContentTextBox, "engContentTextBox");
            // 
            // 
            // 
            this.engContentTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.engContentTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.engContentTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor2")));
            this.engContentTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize2")));
            this.engContentTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode2")));
            this.engContentTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.engContentTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout2")));
            this.engContentTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.engContentTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle2")));
            this.engContentTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.engContentTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.engContentTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign2")));
            this.engContentTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex2")));
            this.engContentTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey2");
            this.engContentTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.engContentTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.engContentTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize2")));
            this.engContentTextBox.CustomButton.Name = "";
            this.engContentTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft2")));
            this.engContentTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.engContentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.engContentTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.engContentTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign2")));
            this.engContentTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation2")));
            this.engContentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.engContentTextBox.CustomButton.UseSelectable = true;
            this.engContentTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.engContentTextBox.Lines = new string[0];
            this.engContentTextBox.MaxLength = 32767;
            this.engContentTextBox.Multiline = true;
            this.engContentTextBox.Name = "engContentTextBox";
            this.engContentTextBox.PasswordChar = '\0';
            this.engContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.engContentTextBox.SelectedText = "";
            this.engContentTextBox.SelectionLength = 0;
            this.engContentTextBox.SelectionStart = 0;
            this.engContentTextBox.ShortcutsEnabled = true;
            this.engContentTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.engContentTextBox.UseSelectable = true;
            this.engContentTextBox.UseStyleColors = true;
            this.engContentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.engContentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.Controls.Add(this.illegalWordHintLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.resetFormButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.addButton, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // illegalWordHintLabel
            // 
            resources.ApplyResources(this.illegalWordHintLabel, "illegalWordHintLabel");
            this.illegalWordHintLabel.Name = "illegalWordHintLabel";
            this.illegalWordHintLabel.UseCustomForeColor = true;
            // 
            // resetFormButton
            // 
            resources.ApplyResources(this.resetFormButton, "resetFormButton");
            this.resetFormButton.Highlight = true;
            this.resetFormButton.Name = "resetFormButton";
            this.resetFormButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.resetFormButton.UseSelectable = true;
            this.resetFormButton.Click += new System.EventHandler(this.resetFormButton_Click);
            // 
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.Highlight = true;
            this.updateButton.Name = "updateButton";
            this.updateButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Highlight = true;
            this.addButton.Name = "addButton";
            this.addButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // HandleEcommerceContentUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.noticeListGroupBox);
            this.Name = "HandleEcommerceContentUserCtrl";
            this.noticeListGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noticeListDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox noticeListGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton searchAllButton;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel keywordLabel;
        private MetroFramework.Controls.MetroTextBox keywordTextBox;
        private MetroFramework.Controls.MetroButton listResetButton;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private System.Windows.Forms.DataGridView noticeListDataGridView;
        private MetroFramework.Controls.MetroButton deleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel tradChiContentLabel;
        private MetroFramework.Controls.MetroLabel engContentLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroLabel illegalWordHintLabel;
        private MetroFramework.Controls.MetroButton resetFormButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroTextBox tradChiContentTextBox;
        private MetroFramework.Controls.MetroTextBox engContentTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroLabel engContentErrorLabel;
        private MetroFramework.Controls.MetroLabel tradChiContentErrorLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedNoticeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noticeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engContentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradChiContentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedByColumn;
    }
}
