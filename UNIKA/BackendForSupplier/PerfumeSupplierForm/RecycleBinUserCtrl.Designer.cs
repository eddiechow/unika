namespace BackendForSupplier.PerfumeSupplierForm
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
            this.perfumeListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedProductColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perfumeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tChiNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tChiDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeleteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.permanentlyDeleteButton = new MetroFramework.Controls.MetroButton();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.categoryLabel = new MetroFramework.Controls.MetroLabel();
            this.recoverButton = new MetroFramework.Controls.MetroButton();
            this.searchPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keywordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.keywordLabel = new MetroFramework.Controls.MetroLabel();
            this.perfumeIdLabel = new MetroFramework.Controls.MetroLabel();
            this.perfumeIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.searchPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.deleteDateAllRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.deleteDateLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteDateToLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteDateRangeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteFromDateTime = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.perfumeListDataGridView)).BeginInit();
            this.searchPanel1.SuspendLayout();
            this.searchPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // perfumeListDataGridView
            // 
            resources.ApplyResources(this.perfumeListDataGridView, "perfumeListDataGridView");
            this.perfumeListDataGridView.AllowUserToAddRows = false;
            this.perfumeListDataGridView.AllowUserToDeleteRows = false;
            this.perfumeListDataGridView.AllowUserToOrderColumns = true;
            this.perfumeListDataGridView.AllowUserToResizeColumns = false;
            this.perfumeListDataGridView.AllowUserToResizeRows = false;
            this.perfumeListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.perfumeListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.perfumeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.perfumeListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedProductColumn,
            this.perfumeIdColumn,
            this.engNameColumn,
            this.tChiNameColumn,
            this.engDescriptionColumn,
            this.tChiDescriptionColumn,
            this.categoryColumn,
            this.quantityColumn,
            this.priceColumn,
            this.releaseDateColumn,
            this.dateDeleteColumn});
            this.perfumeListDataGridView.MultiSelect = false;
            this.perfumeListDataGridView.Name = "perfumeListDataGridView";
            this.perfumeListDataGridView.RowHeadersVisible = false;
            this.perfumeListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // selectedProductColumn
            // 
            this.selectedProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedProductColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedProductColumn, "selectedProductColumn");
            this.selectedProductColumn.Name = "selectedProductColumn";
            // 
            // perfumeIdColumn
            // 
            this.perfumeIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.perfumeIdColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.perfumeIdColumn, "perfumeIdColumn");
            this.perfumeIdColumn.Name = "perfumeIdColumn";
            this.perfumeIdColumn.ReadOnly = true;
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
            // categoryColumn
            // 
            this.categoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.categoryColumn, "categoryColumn");
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
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
            // categoryComboBox
            // 
            resources.ApplyResources(this.categoryComboBox, "categoryComboBox");
            this.categoryComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.categoryComboBox.UseSelectable = true;
            this.categoryComboBox.UseStyleColors = true;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.input_SearchChanged);
            // 
            // categoryLabel
            // 
            resources.ApplyResources(this.categoryLabel, "categoryLabel");
            this.categoryLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.categoryLabel.Name = "categoryLabel";
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
            // searchPanel1
            // 
            resources.ApplyResources(this.searchPanel1, "searchPanel1");
            this.searchPanel1.Controls.Add(this.keywordTextBox, 5, 0);
            this.searchPanel1.Controls.Add(this.keywordLabel, 4, 0);
            this.searchPanel1.Controls.Add(this.perfumeIdLabel, 2, 0);
            this.searchPanel1.Controls.Add(this.categoryComboBox, 1, 0);
            this.searchPanel1.Controls.Add(this.categoryLabel, 0, 0);
            this.searchPanel1.Controls.Add(this.perfumeIdTextBox, 3, 0);
            this.searchPanel1.Name = "searchPanel1";
            // 
            // keywordTextBox
            // 
            resources.ApplyResources(this.keywordTextBox, "keywordTextBox");
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
            this.keywordTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
            // 
            // keywordLabel
            // 
            resources.ApplyResources(this.keywordLabel, "keywordLabel");
            this.keywordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.keywordLabel.Name = "keywordLabel";
            // 
            // perfumeIdLabel
            // 
            resources.ApplyResources(this.perfumeIdLabel, "perfumeIdLabel");
            this.perfumeIdLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.perfumeIdLabel.Name = "perfumeIdLabel";
            // 
            // perfumeIdTextBox
            // 
            resources.ApplyResources(this.perfumeIdTextBox, "perfumeIdTextBox");
            // 
            // 
            // 
            this.perfumeIdTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.perfumeIdTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.perfumeIdTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.perfumeIdTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.perfumeIdTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.perfumeIdTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.perfumeIdTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.perfumeIdTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.perfumeIdTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.perfumeIdTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.perfumeIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.perfumeIdTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.perfumeIdTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.perfumeIdTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.perfumeIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.perfumeIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.perfumeIdTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.perfumeIdTextBox.CustomButton.Name = "";
            this.perfumeIdTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.perfumeIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.perfumeIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.perfumeIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.perfumeIdTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.perfumeIdTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.perfumeIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.perfumeIdTextBox.CustomButton.UseSelectable = true;
            this.perfumeIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.perfumeIdTextBox.Lines = new string[0];
            this.perfumeIdTextBox.MaxLength = 8;
            this.perfumeIdTextBox.Name = "perfumeIdTextBox";
            this.perfumeIdTextBox.PasswordChar = '\0';
            this.perfumeIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.perfumeIdTextBox.SelectedText = "";
            this.perfumeIdTextBox.SelectionLength = 0;
            this.perfumeIdTextBox.SelectionStart = 0;
            this.perfumeIdTextBox.ShortcutsEnabled = true;
            this.perfumeIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.perfumeIdTextBox.UseSelectable = true;
            this.perfumeIdTextBox.UseStyleColors = true;
            this.perfumeIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.perfumeIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.perfumeIdTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
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
            this.deleteDateAllRadioButton.CheckedChanged += new System.EventHandler(this.deleteDateRadioButton_CheckedChanged);
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
            this.Controls.Add(this.perfumeListDataGridView);
            this.Name = "RecycleBinUserCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.perfumeListDataGridView)).EndInit();
            this.searchPanel1.ResumeLayout(false);
            this.searchPanel1.PerformLayout();
            this.searchPanel2.ResumeLayout(false);
            this.searchPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView perfumeListDataGridView;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private MetroFramework.Controls.MetroButton permanentlyDeleteButton;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private MetroFramework.Controls.MetroLabel categoryLabel;
        private MetroFramework.Controls.MetroButton recoverButton;
        private System.Windows.Forms.TableLayoutPanel searchPanel1;
        private MetroFramework.Controls.MetroLabel perfumeIdLabel;
        private MetroFramework.Controls.MetroTextBox perfumeIdTextBox;
        private MetroFramework.Controls.MetroLabel keywordLabel;
        private MetroFramework.Controls.MetroTextBox keywordTextBox;
        private System.Windows.Forms.TableLayoutPanel searchPanel2;
        private MetroFramework.Controls.MetroLabel deleteDateLabel;
        private MetroFramework.Controls.MetroLabel deleteDateToLabel;
        private MetroFramework.Controls.MetroRadioButton deleteDateRangeRadioButton;
        private MetroFramework.Controls.MetroDateTime deleteFromDateTime;
        private MetroFramework.Controls.MetroDateTime deleteToDateTime;
        private MetroFramework.Controls.MetroRadioButton deleteDateAllRadioButton;
        private MetroFramework.Controls.MetroButton resetButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfumeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tChiNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tChiDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeleteColumn;
    }
}
