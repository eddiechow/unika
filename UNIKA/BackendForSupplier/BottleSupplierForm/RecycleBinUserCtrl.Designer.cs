namespace BackendForSupplier.BottleSupplierForm
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
            this.bottleListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedProductColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bottleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tChiNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tChiDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeleteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.permanentlyDeleteButton = new MetroFramework.Controls.MetroButton();
            this.recoverButton = new MetroFramework.Controls.MetroButton();
            this.searchPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.deleteDateAllRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.deleteDateLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteDateToLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteDateRangeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteFromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.searchPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keywordLabel = new MetroFramework.Controls.MetroLabel();
            this.capacityAllRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.capacityToTextBox = new MetroFramework.Controls.MetroTextBox();
            this.capacityToLabel = new MetroFramework.Controls.MetroLabel();
            this.capacityFormTextBox = new MetroFramework.Controls.MetroTextBox();
            this.capacityRangeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.capacityLabel = new MetroFramework.Controls.MetroLabel();
            this.keywordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.bottleIdLabel = new MetroFramework.Controls.MetroLabel();
            this.bottleIdTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottleListDataGridView)).BeginInit();
            this.searchPanel2.SuspendLayout();
            this.searchPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottleListDataGridView
            // 
            this.bottleListDataGridView.AllowUserToAddRows = false;
            this.bottleListDataGridView.AllowUserToDeleteRows = false;
            this.bottleListDataGridView.AllowUserToOrderColumns = true;
            this.bottleListDataGridView.AllowUserToResizeColumns = false;
            this.bottleListDataGridView.AllowUserToResizeRows = false;
            this.bottleListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bottleListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bottleListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bottleListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedProductColumn,
            this.bottleIdColumn,
            this.engNameColumn,
            this.tChiNameColumn,
            this.engDescriptionColumn,
            this.tChiDescriptionColumn,
            this.capacityColumn,
            this.quantityColumn,
            this.priceColumn,
            this.releaseDateColumn,
            this.dateDeleteColumn});
            resources.ApplyResources(this.bottleListDataGridView, "bottleListDataGridView");
            this.bottleListDataGridView.MultiSelect = false;
            this.bottleListDataGridView.Name = "bottleListDataGridView";
            this.bottleListDataGridView.RowHeadersVisible = false;
            this.bottleListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // selectedProductColumn
            // 
            this.selectedProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedProductColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedProductColumn, "selectedProductColumn");
            this.selectedProductColumn.Name = "selectedProductColumn";
            // 
            // bottleIdColumn
            // 
            this.bottleIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bottleIdColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.bottleIdColumn, "bottleIdColumn");
            this.bottleIdColumn.Name = "bottleIdColumn";
            this.bottleIdColumn.ReadOnly = true;
            // 
            // engNameColumn
            // 
            this.engNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.engNameColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.engNameColumn, "engNameColumn");
            this.engNameColumn.Name = "engNameColumn";
            this.engNameColumn.ReadOnly = true;
            // 
            // tChiNameColumn
            // 
            this.tChiNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tChiNameColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.tChiNameColumn, "tChiNameColumn");
            this.tChiNameColumn.Name = "tChiNameColumn";
            this.tChiNameColumn.ReadOnly = true;
            // 
            // engDescriptionColumn
            // 
            this.engDescriptionColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.engDescriptionColumn, "engDescriptionColumn");
            this.engDescriptionColumn.Name = "engDescriptionColumn";
            this.engDescriptionColumn.ReadOnly = true;
            // 
            // tChiDescriptionColumn
            // 
            this.tChiDescriptionColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.tChiDescriptionColumn, "tChiDescriptionColumn");
            this.tChiDescriptionColumn.Name = "tChiDescriptionColumn";
            this.tChiDescriptionColumn.ReadOnly = true;
            // 
            // capacityColumn
            // 
            this.capacityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.capacityColumn, "capacityColumn");
            this.capacityColumn.Name = "capacityColumn";
            this.capacityColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            this.quantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantityColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.quantityColumn, "quantityColumn");
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.priceColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.priceColumn, "priceColumn");
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // releaseDateColumn
            // 
            this.releaseDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.releaseDateColumn, "releaseDateColumn");
            this.releaseDateColumn.Name = "releaseDateColumn";
            this.releaseDateColumn.ReadOnly = true;
            // 
            // dateDeleteColumn
            // 
            this.dateDeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dateDeleteColumn, "dateDeleteColumn");
            this.dateDeleteColumn.Name = "dateDeleteColumn";
            this.dateDeleteColumn.ReadOnly = true;
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
            // recoverButton
            // 
            resources.ApplyResources(this.recoverButton, "recoverButton");
            this.recoverButton.Highlight = true;
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.recoverButton.UseSelectable = true;
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // searchPanel2
            // 
            resources.ApplyResources(this.searchPanel2, "searchPanel2");
            this.searchPanel2.Controls.Add(this.resetButton, 6, 0);
            this.searchPanel2.Controls.Add(this.deleteDateAllRadioButton, 5, 0);
            this.searchPanel2.Controls.Add(this.deleteToDateTime, 4, 0);
            this.searchPanel2.Controls.Add(this.deleteDateLabel, 0, 0);
            this.searchPanel2.Controls.Add(this.deleteDateToLabel, 3, 0);
            this.searchPanel2.Controls.Add(this.deleteDateRangeRadioButton, 1, 0);
            this.searchPanel2.Controls.Add(this.deleteFromDateTime, 2, 0);
            this.searchPanel2.Name = "searchPanel2";
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
            // deleteDateAllRadioButton
            // 
            resources.ApplyResources(this.deleteDateAllRadioButton, "deleteDateAllRadioButton");
            this.deleteDateAllRadioButton.Checked = true;
            this.deleteDateAllRadioButton.Name = "deleteDateAllRadioButton";
            this.deleteDateAllRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deleteDateAllRadioButton.TabStop = true;
            this.deleteDateAllRadioButton.UseCustomForeColor = true;
            this.deleteDateAllRadioButton.UseSelectable = true;
            this.deleteDateAllRadioButton.CheckedChanged += new System.EventHandler(this.deleteDateTime_ValueChanged);
            // 
            // deleteToDateTime
            // 
            resources.ApplyResources(this.deleteToDateTime, "deleteToDateTime");
            this.deleteToDateTime.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.deleteToDateTime.Name = "deleteToDateTime";
            this.deleteToDateTime.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deleteToDateTime.UseCustomForeColor = true;
            this.deleteToDateTime.ValueChanged += new System.EventHandler(this.deleteDateTime_ValueChanged);
            // 
            // deleteDateLabel
            // 
            resources.ApplyResources(this.deleteDateLabel, "deleteDateLabel");
            this.deleteDateLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.deleteDateLabel.Name = "deleteDateLabel";
            // 
            // deleteDateToLabel
            // 
            resources.ApplyResources(this.deleteDateToLabel, "deleteDateToLabel");
            this.deleteDateToLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.deleteDateToLabel.Name = "deleteDateToLabel";
            // 
            // deleteDateRangeRadioButton
            // 
            resources.ApplyResources(this.deleteDateRangeRadioButton, "deleteDateRangeRadioButton");
            this.deleteDateRangeRadioButton.Name = "deleteDateRangeRadioButton";
            this.deleteDateRangeRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deleteDateRangeRadioButton.UseCustomForeColor = true;
            this.deleteDateRangeRadioButton.UseSelectable = true;
            this.deleteDateRangeRadioButton.CheckedChanged += new System.EventHandler(this.deleteDateRadioButton_CheckedChanged);
            // 
            // deleteFromDateTime
            // 
            resources.ApplyResources(this.deleteFromDateTime, "deleteFromDateTime");
            this.deleteFromDateTime.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.deleteFromDateTime.Name = "deleteFromDateTime";
            this.deleteFromDateTime.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deleteFromDateTime.UseCustomForeColor = true;
            this.deleteFromDateTime.ValueChanged += new System.EventHandler(this.deleteDateTime_ValueChanged);
            // 
            // searchPanel1
            // 
            resources.ApplyResources(this.searchPanel1, "searchPanel1");
            this.searchPanel1.Controls.Add(this.keywordLabel, 2, 0);
            this.searchPanel1.Controls.Add(this.capacityAllRadioButton, 9, 0);
            this.searchPanel1.Controls.Add(this.capacityToTextBox, 8, 0);
            this.searchPanel1.Controls.Add(this.capacityToLabel, 7, 0);
            this.searchPanel1.Controls.Add(this.capacityFormTextBox, 6, 0);
            this.searchPanel1.Controls.Add(this.capacityRangeRadioButton, 5, 0);
            this.searchPanel1.Controls.Add(this.capacityLabel, 4, 0);
            this.searchPanel1.Controls.Add(this.keywordTextBox, 3, 0);
            this.searchPanel1.Controls.Add(this.bottleIdLabel, 0, 0);
            this.searchPanel1.Controls.Add(this.bottleIdTextBox, 1, 0);
            this.searchPanel1.Name = "searchPanel1";
            // 
            // keywordLabel
            // 
            resources.ApplyResources(this.keywordLabel, "keywordLabel");
            this.keywordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.keywordLabel.Name = "keywordLabel";
            // 
            // capacityAllRadioButton
            // 
            resources.ApplyResources(this.capacityAllRadioButton, "capacityAllRadioButton");
            this.capacityAllRadioButton.Checked = true;
            this.capacityAllRadioButton.Name = "capacityAllRadioButton";
            this.capacityAllRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.capacityAllRadioButton.TabStop = true;
            this.capacityAllRadioButton.UseCustomForeColor = true;
            this.capacityAllRadioButton.UseSelectable = true;
            this.capacityAllRadioButton.CheckedChanged += new System.EventHandler(this.capacityRadioButton_CheckedChanged);
            // 
            // capacityToTextBox
            // 
            resources.ApplyResources(this.capacityToTextBox, "capacityToTextBox");
            // 
            // 
            // 
            this.capacityToTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.capacityToTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.capacityToTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.capacityToTextBox.CustomButton.Name = "";
            this.capacityToTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.capacityToTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.capacityToTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.capacityToTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.capacityToTextBox.CustomButton.UseSelectable = true;
            this.capacityToTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.capacityToTextBox.Lines = new string[0];
            this.capacityToTextBox.MaxLength = 3;
            this.capacityToTextBox.Name = "capacityToTextBox";
            this.capacityToTextBox.PasswordChar = '\0';
            this.capacityToTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.capacityToTextBox.SelectedText = "";
            this.capacityToTextBox.SelectionLength = 0;
            this.capacityToTextBox.SelectionStart = 0;
            this.capacityToTextBox.ShortcutsEnabled = true;
            this.capacityToTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.capacityToTextBox.UseSelectable = true;
            this.capacityToTextBox.UseStyleColors = true;
            this.capacityToTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.capacityToTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.capacityToTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
            this.capacityToTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.capacityTextBox_Validating);
            // 
            // capacityToLabel
            // 
            resources.ApplyResources(this.capacityToLabel, "capacityToLabel");
            this.capacityToLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.capacityToLabel.Name = "capacityToLabel";
            // 
            // capacityFormTextBox
            // 
            resources.ApplyResources(this.capacityFormTextBox, "capacityFormTextBox");
            // 
            // 
            // 
            this.capacityFormTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.capacityFormTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.capacityFormTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.capacityFormTextBox.CustomButton.Name = "";
            this.capacityFormTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.capacityFormTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.capacityFormTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.capacityFormTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.capacityFormTextBox.CustomButton.UseSelectable = true;
            this.capacityFormTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.capacityFormTextBox.Lines = new string[0];
            this.capacityFormTextBox.MaxLength = 3;
            this.capacityFormTextBox.Name = "capacityFormTextBox";
            this.capacityFormTextBox.PasswordChar = '\0';
            this.capacityFormTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.capacityFormTextBox.SelectedText = "";
            this.capacityFormTextBox.SelectionLength = 0;
            this.capacityFormTextBox.SelectionStart = 0;
            this.capacityFormTextBox.ShortcutsEnabled = true;
            this.capacityFormTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.capacityFormTextBox.UseSelectable = true;
            this.capacityFormTextBox.UseStyleColors = true;
            this.capacityFormTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.capacityFormTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.capacityFormTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
            this.capacityFormTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.capacityTextBox_Validating);
            // 
            // capacityRangeRadioButton
            // 
            resources.ApplyResources(this.capacityRangeRadioButton, "capacityRangeRadioButton");
            this.capacityRangeRadioButton.Name = "capacityRangeRadioButton";
            this.capacityRangeRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.capacityRangeRadioButton.UseCustomForeColor = true;
            this.capacityRangeRadioButton.UseSelectable = true;
            this.capacityRangeRadioButton.CheckedChanged += new System.EventHandler(this.capacityRadioButton_CheckedChanged);
            // 
            // capacityLabel
            // 
            resources.ApplyResources(this.capacityLabel, "capacityLabel");
            this.capacityLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.capacityLabel.Name = "capacityLabel";
            // 
            // keywordTextBox
            // 
            // 
            // 
            // 
            this.keywordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.keywordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.keywordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.keywordTextBox.CustomButton.Name = "";
            this.keywordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.keywordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keywordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.keywordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keywordTextBox.CustomButton.UseSelectable = true;
            this.keywordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.keywordTextBox.Lines = new string[0];
            resources.ApplyResources(this.keywordTextBox, "keywordTextBox");
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
            this.keywordTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
            // 
            // bottleIdLabel
            // 
            resources.ApplyResources(this.bottleIdLabel, "bottleIdLabel");
            this.bottleIdLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.bottleIdLabel.Name = "bottleIdLabel";
            // 
            // bottleIdTextBox
            // 
            resources.ApplyResources(this.bottleIdTextBox, "bottleIdTextBox");
            // 
            // 
            // 
            this.bottleIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.bottleIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.bottleIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.bottleIdTextBox.CustomButton.Name = "";
            this.bottleIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.bottleIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bottleIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.bottleIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bottleIdTextBox.CustomButton.UseSelectable = true;
            this.bottleIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.bottleIdTextBox.Lines = new string[0];
            this.bottleIdTextBox.MaxLength = 8;
            this.bottleIdTextBox.Name = "bottleIdTextBox";
            this.bottleIdTextBox.PasswordChar = '\0';
            this.bottleIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bottleIdTextBox.SelectedText = "";
            this.bottleIdTextBox.SelectionLength = 0;
            this.bottleIdTextBox.SelectionStart = 0;
            this.bottleIdTextBox.ShortcutsEnabled = true;
            this.bottleIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bottleIdTextBox.UseSelectable = true;
            this.bottleIdTextBox.UseStyleColors = true;
            this.bottleIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bottleIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.bottleIdTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
            // 
            // RecycleBinUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel2);
            this.Controls.Add(this.searchPanel1);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.permanentlyDeleteButton);
            this.Controls.Add(this.bottleListDataGridView);
            this.Name = "RecycleBinUserCtrl";
            this.Load += new System.EventHandler(this.RecycleBinUserCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottleListDataGridView)).EndInit();
            this.searchPanel2.ResumeLayout(false);
            this.searchPanel2.PerformLayout();
            this.searchPanel1.ResumeLayout(false);
            this.searchPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bottleListDataGridView;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private MetroFramework.Controls.MetroButton permanentlyDeleteButton;
        private MetroFramework.Controls.MetroButton recoverButton;
        private System.Windows.Forms.TableLayoutPanel searchPanel2;
        private MetroFramework.Controls.MetroButton resetButton;
        private MetroFramework.Controls.MetroRadioButton deleteDateAllRadioButton;
        private MetroFramework.Controls.MetroDateTime deleteToDateTime;
        private MetroFramework.Controls.MetroLabel deleteDateLabel;
        private MetroFramework.Controls.MetroLabel deleteDateToLabel;
        private MetroFramework.Controls.MetroRadioButton deleteDateRangeRadioButton;
        private MetroFramework.Controls.MetroDateTime deleteFromDateTime;
        private System.Windows.Forms.TableLayoutPanel searchPanel1;
        private MetroFramework.Controls.MetroTextBox keywordTextBox;
        private MetroFramework.Controls.MetroLabel bottleIdLabel;
        private MetroFramework.Controls.MetroTextBox bottleIdTextBox;
        private MetroFramework.Controls.MetroLabel capacityLabel;
        private MetroFramework.Controls.MetroRadioButton capacityRangeRadioButton;
        private MetroFramework.Controls.MetroTextBox capacityFormTextBox;
        private MetroFramework.Controls.MetroLabel capacityToLabel;
        private MetroFramework.Controls.MetroTextBox capacityToTextBox;
        private MetroFramework.Controls.MetroRadioButton capacityAllRadioButton;
        private MetroFramework.Controls.MetroLabel keywordLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bottleIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tChiNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tChiDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeleteColumn;
    }
}
