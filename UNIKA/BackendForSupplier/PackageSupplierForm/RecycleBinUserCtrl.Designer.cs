namespace BackendForSupplier.PackageSupplierForm
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
            this.packageListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedProductColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.packageIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tChiNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tChiDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeleteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.permanentlyDeleteButton = new MetroFramework.Controls.MetroButton();
            this.recoverButton = new MetroFramework.Controls.MetroButton();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.deleteDateAllRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.deleteDateToLabel = new MetroFramework.Controls.MetroLabel();
            this.deleteFromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.deleteDateRangeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteDateLabel = new MetroFramework.Controls.MetroLabel();
            this.keywordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.keywordLabel = new MetroFramework.Controls.MetroLabel();
            this.perfumeIdLabel = new MetroFramework.Controls.MetroLabel();
            this.packageIdTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.packageListDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageListDataGridView
            // 
            this.packageListDataGridView.AllowUserToAddRows = false;
            this.packageListDataGridView.AllowUserToDeleteRows = false;
            this.packageListDataGridView.AllowUserToOrderColumns = true;
            this.packageListDataGridView.AllowUserToResizeColumns = false;
            this.packageListDataGridView.AllowUserToResizeRows = false;
            this.packageListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packageListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.packageListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.packageListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedProductColumn,
            this.packageIdColumn,
            this.engNameColumn,
            this.tChiNameColumn,
            this.engDescriptionColumn,
            this.tChiDescriptionColumn,
            this.quantityColumn,
            this.priceColumn,
            this.releaseDateColumn,
            this.dateDeleteColumn});
            resources.ApplyResources(this.packageListDataGridView, "packageListDataGridView");
            this.packageListDataGridView.MultiSelect = false;
            this.packageListDataGridView.Name = "packageListDataGridView";
            this.packageListDataGridView.RowHeadersVisible = false;
            this.packageListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // selectedProductColumn
            // 
            this.selectedProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedProductColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedProductColumn, "selectedProductColumn");
            this.selectedProductColumn.Name = "selectedProductColumn";
            // 
            // packageIdColumn
            // 
            this.packageIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.packageIdColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.packageIdColumn, "packageIdColumn");
            this.packageIdColumn.Name = "packageIdColumn";
            this.packageIdColumn.ReadOnly = true;
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
            // searchPanel
            // 
            resources.ApplyResources(this.searchPanel, "searchPanel");
            this.searchPanel.Controls.Add(this.resetButton, 10, 0);
            this.searchPanel.Controls.Add(this.deleteDateAllRadioButton, 9, 0);
            this.searchPanel.Controls.Add(this.deleteToDateTime, 8, 0);
            this.searchPanel.Controls.Add(this.deleteDateToLabel, 7, 0);
            this.searchPanel.Controls.Add(this.deleteFromDateTime, 6, 0);
            this.searchPanel.Controls.Add(this.deleteDateRangeRadioButton, 5, 0);
            this.searchPanel.Controls.Add(this.deleteDateLabel, 4, 0);
            this.searchPanel.Controls.Add(this.keywordTextBox, 3, 0);
            this.searchPanel.Controls.Add(this.keywordLabel, 2, 0);
            this.searchPanel.Controls.Add(this.perfumeIdLabel, 0, 0);
            this.searchPanel.Controls.Add(this.packageIdTextBox, 1, 0);
            this.searchPanel.Name = "searchPanel";
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.Highlight = true;
            this.resetButton.Name = "resetButton";
            this.resetButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.resetButton.UseSelectable = true;
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
            // deleteDateToLabel
            // 
            resources.ApplyResources(this.deleteDateToLabel, "deleteDateToLabel");
            this.deleteDateToLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.deleteDateToLabel.Name = "deleteDateToLabel";
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
            // deleteDateRangeRadioButton
            // 
            resources.ApplyResources(this.deleteDateRangeRadioButton, "deleteDateRangeRadioButton");
            this.deleteDateRangeRadioButton.Name = "deleteDateRangeRadioButton";
            this.deleteDateRangeRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.deleteDateRangeRadioButton.UseCustomForeColor = true;
            this.deleteDateRangeRadioButton.UseSelectable = true;
            this.deleteDateRangeRadioButton.CheckedChanged += new System.EventHandler(this.deleteDateRadioButton_CheckedChanged);
            // 
            // deleteDateLabel
            // 
            resources.ApplyResources(this.deleteDateLabel, "deleteDateLabel");
            this.deleteDateLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.deleteDateLabel.Name = "deleteDateLabel";
            // 
            // keywordTextBox
            // 
            // 
            // 
            // 
            this.keywordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.keywordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.keywordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.keywordTextBox.CustomButton.Name = "";
            this.keywordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.keywordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keywordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.keywordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keywordTextBox.CustomButton.UseSelectable = true;
            this.keywordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
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
            // packageIdTextBox
            // 
            // 
            // 
            // 
            this.packageIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.packageIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.packageIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.packageIdTextBox.CustomButton.Name = "";
            this.packageIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.packageIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.packageIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.packageIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.packageIdTextBox.CustomButton.UseSelectable = true;
            this.packageIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.packageIdTextBox.Lines = new string[0];
            resources.ApplyResources(this.packageIdTextBox, "packageIdTextBox");
            this.packageIdTextBox.MaxLength = 8;
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.PasswordChar = '\0';
            this.packageIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.packageIdTextBox.SelectedText = "";
            this.packageIdTextBox.SelectionLength = 0;
            this.packageIdTextBox.SelectionStart = 0;
            this.packageIdTextBox.ShortcutsEnabled = true;
            this.packageIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.packageIdTextBox.UseSelectable = true;
            this.packageIdTextBox.UseStyleColors = true;
            this.packageIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.packageIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.packageIdTextBox.TextChanged += new System.EventHandler(this.input_SearchChanged);
            // 
            // RecycleBinUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.permanentlyDeleteButton);
            this.Controls.Add(this.packageListDataGridView);
            this.Name = "RecycleBinUserCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.packageListDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView packageListDataGridView;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private MetroFramework.Controls.MetroButton permanentlyDeleteButton;
        private MetroFramework.Controls.MetroButton recoverButton;
        private System.Windows.Forms.TableLayoutPanel searchPanel;
        private MetroFramework.Controls.MetroTextBox keywordTextBox;
        private MetroFramework.Controls.MetroLabel keywordLabel;
        private MetroFramework.Controls.MetroLabel perfumeIdLabel;
        private MetroFramework.Controls.MetroTextBox packageIdTextBox;
        private MetroFramework.Controls.MetroLabel deleteDateLabel;
        private MetroFramework.Controls.MetroRadioButton deleteDateRangeRadioButton;
        private MetroFramework.Controls.MetroDateTime deleteFromDateTime;
        private MetroFramework.Controls.MetroLabel deleteDateToLabel;
        private MetroFramework.Controls.MetroDateTime deleteToDateTime;
        private MetroFramework.Controls.MetroRadioButton deleteDateAllRadioButton;
        private MetroFramework.Controls.MetroButton resetButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tChiNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tChiDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeleteColumn;
    }
}
