namespace BackendForCompany.WebMasterForm
{
    partial class SupplierManagementUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierManagementUserCtrl));
            this.formPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staffIdLabel = new MetroFramework.Controls.MetroLabel();
            this.positionLabel = new MetroFramework.Controls.MetroLabel();
            this.staffIdHintLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierTypeErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.bottleRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.supplierNameErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.packageRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.supplierNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.supplierNameLabel = new MetroFramework.Controls.MetroLabel();
            this.perfumeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.idTextBox = new MetroFramework.Controls.MetroTextBox();
            this.formPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierContactNoErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierContactNoLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierContactNoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordHintLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.formPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierAddressErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierAddressLabel = new MetroFramework.Controls.MetroLabel();
            this.supplierAddressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.resetFormButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.staffListGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchAllButton = new MetroFramework.Controls.MetroButton();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.searchSupplierIdLabel = new MetroFramework.Controls.MetroLabel();
            this.searchSupplierIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.staffDataResetButton = new MetroFramework.Controls.MetroButton();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.supplierListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedSupplierColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supplierIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierContactNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.formPanel1.SuspendLayout();
            this.formPanel2.SuspendLayout();
            this.formPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.staffListGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel1
            // 
            resources.ApplyResources(this.formPanel1, "formPanel1");
            this.formPanel1.BackColor = System.Drawing.Color.Transparent;
            this.formPanel1.Controls.Add(this.staffIdLabel, 0, 5);
            this.formPanel1.Controls.Add(this.positionLabel, 0, 1);
            this.formPanel1.Controls.Add(this.staffIdHintLabel, 1, 6);
            this.formPanel1.Controls.Add(this.supplierTypeErrorLabel, 1, 3);
            this.formPanel1.Controls.Add(this.bottleRadioButton, 1, 2);
            this.formPanel1.Controls.Add(this.supplierNameErrorLabel, 1, 9);
            this.formPanel1.Controls.Add(this.packageRadioButton, 1, 1);
            this.formPanel1.Controls.Add(this.supplierNameTextBox, 1, 8);
            this.formPanel1.Controls.Add(this.supplierNameLabel, 0, 8);
            this.formPanel1.Controls.Add(this.perfumeRadioButton, 1, 0);
            this.formPanel1.Controls.Add(this.idTextBox, 1, 5);
            this.formPanel1.Name = "formPanel1";
            // 
            // staffIdLabel
            // 
            resources.ApplyResources(this.staffIdLabel, "staffIdLabel");
            this.staffIdLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.staffIdLabel.Name = "staffIdLabel";
            // 
            // positionLabel
            // 
            resources.ApplyResources(this.positionLabel, "positionLabel");
            this.positionLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.positionLabel.Name = "positionLabel";
            // 
            // staffIdHintLabel
            // 
            resources.ApplyResources(this.staffIdHintLabel, "staffIdHintLabel");
            this.staffIdHintLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.staffIdHintLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.staffIdHintLabel.Name = "staffIdHintLabel";
            this.staffIdHintLabel.UseCustomForeColor = true;
            // 
            // supplierTypeErrorLabel
            // 
            resources.ApplyResources(this.supplierTypeErrorLabel, "supplierTypeErrorLabel");
            this.supplierTypeErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierTypeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierTypeErrorLabel.Name = "supplierTypeErrorLabel";
            this.supplierTypeErrorLabel.UseCustomForeColor = true;
            // 
            // bottleRadioButton
            // 
            resources.ApplyResources(this.bottleRadioButton, "bottleRadioButton");
            this.bottleRadioButton.Name = "bottleRadioButton";
            this.bottleRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bottleRadioButton.UseCustomForeColor = true;
            this.bottleRadioButton.UseSelectable = true;
            this.bottleRadioButton.CheckedChanged += new System.EventHandler(this.bottleRadioButton_CheckedChanged);
            // 
            // supplierNameErrorLabel
            // 
            resources.ApplyResources(this.supplierNameErrorLabel, "supplierNameErrorLabel");
            this.supplierNameErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierNameErrorLabel.Name = "supplierNameErrorLabel";
            this.supplierNameErrorLabel.UseCustomForeColor = true;
            // 
            // packageRadioButton
            // 
            resources.ApplyResources(this.packageRadioButton, "packageRadioButton");
            this.packageRadioButton.Name = "packageRadioButton";
            this.packageRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.packageRadioButton.UseCustomForeColor = true;
            this.packageRadioButton.UseSelectable = true;
            this.packageRadioButton.CheckedChanged += new System.EventHandler(this.packageRadioButton_CheckedChanged);
            // 
            // supplierNameTextBox
            // 
            resources.ApplyResources(this.supplierNameTextBox, "supplierNameTextBox");
            // 
            // 
            // 
            this.supplierNameTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.supplierNameTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.supplierNameTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.supplierNameTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.supplierNameTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.supplierNameTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.supplierNameTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.supplierNameTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.supplierNameTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.supplierNameTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.supplierNameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.supplierNameTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.supplierNameTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.supplierNameTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.supplierNameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.supplierNameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.supplierNameTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.supplierNameTextBox.CustomButton.Name = "";
            this.supplierNameTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.supplierNameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.supplierNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierNameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.supplierNameTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.supplierNameTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.supplierNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierNameTextBox.CustomButton.UseSelectable = true;
            this.supplierNameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
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
            // 
            // supplierNameLabel
            // 
            resources.ApplyResources(this.supplierNameLabel, "supplierNameLabel");
            this.supplierNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierNameLabel.Name = "supplierNameLabel";
            // 
            // perfumeRadioButton
            // 
            resources.ApplyResources(this.perfumeRadioButton, "perfumeRadioButton");
            this.perfumeRadioButton.Name = "perfumeRadioButton";
            this.perfumeRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.perfumeRadioButton.UseCustomForeColor = true;
            this.perfumeRadioButton.UseSelectable = true;
            this.perfumeRadioButton.CheckedChanged += new System.EventHandler(this.perfumeRadioButton_CheckedChanged);
            // 
            // idTextBox
            // 
            resources.ApplyResources(this.idTextBox, "idTextBox");
            // 
            // 
            // 
            this.idTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.idTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.idTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.idTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.idTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.idTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.idTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.idTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.idTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.idTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.idTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.idTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.idTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.idTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.idTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.idTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.idTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.idTextBox.CustomButton.Name = "";
            this.idTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.idTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.idTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.idTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.idTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.idTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextBox.CustomButton.UseSelectable = true;
            this.idTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.idTextBox.Lines = new string[0];
            this.idTextBox.MaxLength = 8;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '\0';
            this.idTextBox.ReadOnly = true;
            this.idTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTextBox.SelectedText = "";
            this.idTextBox.SelectionLength = 0;
            this.idTextBox.SelectionStart = 0;
            this.idTextBox.ShortcutsEnabled = true;
            this.idTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.idTextBox.UseSelectable = true;
            this.idTextBox.UseStyleColors = true;
            this.idTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // formPanel2
            // 
            resources.ApplyResources(this.formPanel2, "formPanel2");
            this.formPanel2.BackColor = System.Drawing.Color.Transparent;
            this.formPanel2.Controls.Add(this.supplierContactNoErrorLabel, 1, 1);
            this.formPanel2.Controls.Add(this.supplierContactNoLabel, 0, 0);
            this.formPanel2.Controls.Add(this.supplierContactNoTextBox, 1, 0);
            this.formPanel2.Controls.Add(this.emailErrorLabel, 1, 4);
            this.formPanel2.Controls.Add(this.emailTextBox, 1, 3);
            this.formPanel2.Controls.Add(this.emailLabel, 0, 3);
            this.formPanel2.Name = "formPanel2";
            // 
            // supplierContactNoErrorLabel
            // 
            resources.ApplyResources(this.supplierContactNoErrorLabel, "supplierContactNoErrorLabel");
            this.supplierContactNoErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierContactNoErrorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplierContactNoErrorLabel.Name = "supplierContactNoErrorLabel";
            this.supplierContactNoErrorLabel.UseCustomForeColor = true;
            // 
            // supplierContactNoLabel
            // 
            resources.ApplyResources(this.supplierContactNoLabel, "supplierContactNoLabel");
            this.supplierContactNoLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierContactNoLabel.Name = "supplierContactNoLabel";
            // 
            // supplierContactNoTextBox
            // 
            resources.ApplyResources(this.supplierContactNoTextBox, "supplierContactNoTextBox");
            // 
            // 
            // 
            this.supplierContactNoTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.supplierContactNoTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.supplierContactNoTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor2")));
            this.supplierContactNoTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize2")));
            this.supplierContactNoTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode2")));
            this.supplierContactNoTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.supplierContactNoTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout2")));
            this.supplierContactNoTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.supplierContactNoTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle2")));
            this.supplierContactNoTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.supplierContactNoTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.supplierContactNoTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign2")));
            this.supplierContactNoTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex2")));
            this.supplierContactNoTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey2");
            this.supplierContactNoTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.supplierContactNoTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.supplierContactNoTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize2")));
            this.supplierContactNoTextBox.CustomButton.Name = "";
            this.supplierContactNoTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft2")));
            this.supplierContactNoTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.supplierContactNoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierContactNoTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.supplierContactNoTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign2")));
            this.supplierContactNoTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation2")));
            this.supplierContactNoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierContactNoTextBox.CustomButton.UseSelectable = true;
            this.supplierContactNoTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
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
            // 
            // emailErrorLabel
            // 
            resources.ApplyResources(this.emailErrorLabel, "emailErrorLabel");
            this.emailErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.UseCustomForeColor = true;
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            // 
            // 
            // 
            this.emailTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3");
            this.emailTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName3");
            this.emailTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor3")));
            this.emailTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize3")));
            this.emailTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode3")));
            this.emailTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage3")));
            this.emailTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout3")));
            this.emailTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock3")));
            this.emailTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle3")));
            this.emailTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font3")));
            this.emailTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.emailTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign3")));
            this.emailTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex3")));
            this.emailTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey3");
            this.emailTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.emailTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.emailTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize3")));
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft3")));
            this.emailTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.emailTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign3")));
            this.emailTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation3")));
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.MaxLength = 32767;
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
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.emailLabel.Name = "emailLabel";
            // 
            // passwordHintLabel
            // 
            resources.ApplyResources(this.passwordHintLabel, "passwordHintLabel");
            this.passwordHintLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passwordHintLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordHintLabel.Name = "passwordHintLabel";
            this.passwordHintLabel.UseCustomForeColor = true;
            this.passwordHintLabel.WrapToLine = true;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription4");
            this.passwordTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName4");
            this.passwordTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor4")));
            this.passwordTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize4")));
            this.passwordTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode4")));
            this.passwordTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage4")));
            this.passwordTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout4")));
            this.passwordTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock4")));
            this.passwordTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle4")));
            this.passwordTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font4")));
            this.passwordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.passwordTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign4")));
            this.passwordTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex4")));
            this.passwordTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey4");
            this.passwordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.passwordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.passwordTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize4")));
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft4")));
            this.passwordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.passwordTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign4")));
            this.passwordTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation4")));
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.UseStyleColors = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // formPanel3
            // 
            resources.ApplyResources(this.formPanel3, "formPanel3");
            this.formPanel3.BackColor = System.Drawing.Color.Transparent;
            this.formPanel3.Controls.Add(this.passwordHintLabel, 1, 1);
            this.formPanel3.Controls.Add(this.passwordTextBox, 1, 0);
            this.formPanel3.Controls.Add(this.passwordLabel, 0, 0);
            this.formPanel3.Name = "formPanel3";
            // 
            // supplierAddressErrorLabel
            // 
            resources.ApplyResources(this.supplierAddressErrorLabel, "supplierAddressErrorLabel");
            this.supplierAddressErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierAddressErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierAddressErrorLabel.Name = "supplierAddressErrorLabel";
            this.supplierAddressErrorLabel.UseCustomForeColor = true;
            // 
            // supplierAddressLabel
            // 
            resources.ApplyResources(this.supplierAddressLabel, "supplierAddressLabel");
            this.supplierAddressLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.supplierAddressLabel.Name = "supplierAddressLabel";
            // 
            // supplierAddressTextBox
            // 
            resources.ApplyResources(this.supplierAddressTextBox, "supplierAddressTextBox");
            // 
            // 
            // 
            this.supplierAddressTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription5");
            this.supplierAddressTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName5");
            this.supplierAddressTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor5")));
            this.supplierAddressTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize5")));
            this.supplierAddressTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode5")));
            this.supplierAddressTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage5")));
            this.supplierAddressTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout5")));
            this.supplierAddressTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock5")));
            this.supplierAddressTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle5")));
            this.supplierAddressTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font5")));
            this.supplierAddressTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.supplierAddressTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign5")));
            this.supplierAddressTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex5")));
            this.supplierAddressTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey5");
            this.supplierAddressTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode5")));
            this.supplierAddressTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location5")));
            this.supplierAddressTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize5")));
            this.supplierAddressTextBox.CustomButton.Name = "";
            this.supplierAddressTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft5")));
            this.supplierAddressTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size5")));
            this.supplierAddressTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.supplierAddressTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex5")));
            this.supplierAddressTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign5")));
            this.supplierAddressTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation5")));
            this.supplierAddressTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.supplierAddressTextBox.CustomButton.UseSelectable = true;
            this.supplierAddressTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible5")));
            this.supplierAddressTextBox.Lines = new string[0];
            this.supplierAddressTextBox.MaxLength = 32767;
            this.supplierAddressTextBox.Multiline = true;
            this.supplierAddressTextBox.Name = "supplierAddressTextBox";
            this.supplierAddressTextBox.PasswordChar = '\0';
            this.supplierAddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.supplierAddressTextBox.SelectedText = "";
            this.supplierAddressTextBox.SelectionLength = 0;
            this.supplierAddressTextBox.SelectionStart = 0;
            this.supplierAddressTextBox.ShortcutsEnabled = true;
            this.supplierAddressTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.supplierAddressTextBox.UseSelectable = true;
            this.supplierAddressTextBox.UseStyleColors = true;
            this.supplierAddressTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.supplierAddressTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.Controls.Add(this.resetFormButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.updateButton, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.addButton, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
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
            // staffListGroupBox
            // 
            resources.ApplyResources(this.staffListGroupBox, "staffListGroupBox");
            this.staffListGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.staffListGroupBox.Controls.Add(this.staffDataResetButton);
            this.staffListGroupBox.Controls.Add(this.selectAllButton);
            this.staffListGroupBox.Controls.Add(this.deselectAllButton);
            this.staffListGroupBox.Controls.Add(this.supplierListDataGridView);
            this.staffListGroupBox.Controls.Add(this.deleteButton);
            this.staffListGroupBox.Name = "staffListGroupBox";
            this.staffListGroupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.searchAllButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchSupplierIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchSupplierIdTextBox, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            // searchSupplierIdLabel
            // 
            resources.ApplyResources(this.searchSupplierIdLabel, "searchSupplierIdLabel");
            this.searchSupplierIdLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.searchSupplierIdLabel.Name = "searchSupplierIdLabel";
            // 
            // searchSupplierIdTextBox
            // 
            resources.ApplyResources(this.searchSupplierIdTextBox, "searchSupplierIdTextBox");
            this.searchSupplierIdTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchSupplierIdTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.searchSupplierIdTextBox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription6");
            this.searchSupplierIdTextBox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName6");
            this.searchSupplierIdTextBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor6")));
            this.searchSupplierIdTextBox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize6")));
            this.searchSupplierIdTextBox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode6")));
            this.searchSupplierIdTextBox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage6")));
            this.searchSupplierIdTextBox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout6")));
            this.searchSupplierIdTextBox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock6")));
            this.searchSupplierIdTextBox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle6")));
            this.searchSupplierIdTextBox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font6")));
            this.searchSupplierIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.searchSupplierIdTextBox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign6")));
            this.searchSupplierIdTextBox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex6")));
            this.searchSupplierIdTextBox.CustomButton.ImageKey = resources.GetString("resource.ImageKey6");
            this.searchSupplierIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode6")));
            this.searchSupplierIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location6")));
            this.searchSupplierIdTextBox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize6")));
            this.searchSupplierIdTextBox.CustomButton.Name = "";
            this.searchSupplierIdTextBox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft6")));
            this.searchSupplierIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size6")));
            this.searchSupplierIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchSupplierIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex6")));
            this.searchSupplierIdTextBox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign6")));
            this.searchSupplierIdTextBox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation6")));
            this.searchSupplierIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchSupplierIdTextBox.CustomButton.UseSelectable = true;
            this.searchSupplierIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible6")));
            this.searchSupplierIdTextBox.Lines = new string[0];
            this.searchSupplierIdTextBox.MaxLength = 32767;
            this.searchSupplierIdTextBox.Name = "searchSupplierIdTextBox";
            this.searchSupplierIdTextBox.PasswordChar = '\0';
            this.searchSupplierIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchSupplierIdTextBox.SelectedText = "";
            this.searchSupplierIdTextBox.SelectionLength = 0;
            this.searchSupplierIdTextBox.SelectionStart = 0;
            this.searchSupplierIdTextBox.ShortcutsEnabled = true;
            this.searchSupplierIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.searchSupplierIdTextBox.UseSelectable = true;
            this.searchSupplierIdTextBox.UseStyleColors = true;
            this.searchSupplierIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchSupplierIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // staffDataResetButton
            // 
            resources.ApplyResources(this.staffDataResetButton, "staffDataResetButton");
            this.staffDataResetButton.Highlight = true;
            this.staffDataResetButton.Name = "staffDataResetButton";
            this.staffDataResetButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.staffDataResetButton.UseSelectable = true;
            this.staffDataResetButton.Click += new System.EventHandler(this.staffDataResetButton_Click);
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
            this.selectedSupplierColumn,
            this.supplierIDColumn,
            this.supplierNameColumn,
            this.supplierTypeColumn,
            this.supplierContactNoColumn,
            this.supplierEmailColumn,
            this.supplierAddressColumn});
            this.supplierListDataGridView.MultiSelect = false;
            this.supplierListDataGridView.Name = "supplierListDataGridView";
            this.supplierListDataGridView.RowHeadersVisible = false;
            this.supplierListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierListDataGridView_CellClick);
            // 
            // selectedSupplierColumn
            // 
            this.selectedSupplierColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedSupplierColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedSupplierColumn, "selectedSupplierColumn");
            this.selectedSupplierColumn.Name = "selectedSupplierColumn";
            // 
            // supplierIDColumn
            // 
            this.supplierIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supplierIDColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.supplierIDColumn, "supplierIDColumn");
            this.supplierIDColumn.Name = "supplierIDColumn";
            this.supplierIDColumn.ReadOnly = true;
            // 
            // supplierNameColumn
            // 
            this.supplierNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supplierNameColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.supplierNameColumn, "supplierNameColumn");
            this.supplierNameColumn.Name = "supplierNameColumn";
            this.supplierNameColumn.ReadOnly = true;
            // 
            // supplierTypeColumn
            // 
            this.supplierTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supplierTypeColumn.FillWeight = 83.48683F;
            resources.ApplyResources(this.supplierTypeColumn, "supplierTypeColumn");
            this.supplierTypeColumn.Name = "supplierTypeColumn";
            this.supplierTypeColumn.ReadOnly = true;
            // 
            // supplierContactNoColumn
            // 
            this.supplierContactNoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.supplierContactNoColumn, "supplierContactNoColumn");
            this.supplierContactNoColumn.Name = "supplierContactNoColumn";
            this.supplierContactNoColumn.ReadOnly = true;
            // 
            // supplierEmailColumn
            // 
            this.supplierEmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.supplierEmailColumn, "supplierEmailColumn");
            this.supplierEmailColumn.Name = "supplierEmailColumn";
            this.supplierEmailColumn.ReadOnly = true;
            // 
            // supplierAddressColumn
            // 
            this.supplierAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.supplierAddressColumn, "supplierAddressColumn");
            this.supplierAddressColumn.Name = "supplierAddressColumn";
            this.supplierAddressColumn.ReadOnly = true;
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
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.Controls.Add(this.supplierAddressErrorLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.supplierAddressLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.supplierAddressTextBox, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // SupplierManagementUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.staffListGroupBox);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.formPanel3);
            this.Controls.Add(this.formPanel2);
            this.Controls.Add(this.formPanel1);
            this.Name = "SupplierManagementUserCtrl";
            this.formPanel1.ResumeLayout(false);
            this.formPanel1.PerformLayout();
            this.formPanel2.ResumeLayout(false);
            this.formPanel2.PerformLayout();
            this.formPanel3.ResumeLayout(false);
            this.formPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.staffListGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel formPanel1;
        private MetroFramework.Controls.MetroLabel staffIdLabel;
        private MetroFramework.Controls.MetroLabel positionLabel;
        private MetroFramework.Controls.MetroLabel supplierTypeErrorLabel;
        private MetroFramework.Controls.MetroRadioButton bottleRadioButton;
        private MetroFramework.Controls.MetroRadioButton packageRadioButton;
        private MetroFramework.Controls.MetroRadioButton perfumeRadioButton;
        private MetroFramework.Controls.MetroTextBox idTextBox;
        private System.Windows.Forms.TableLayoutPanel formPanel2;
        private MetroFramework.Controls.MetroLabel supplierContactNoErrorLabel;
        private MetroFramework.Controls.MetroLabel supplierContactNoLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox supplierContactNoTextBox;
        private MetroFramework.Controls.MetroLabel supplierNameErrorLabel;
        private MetroFramework.Controls.MetroLabel supplierNameLabel;
        private MetroFramework.Controls.MetroTextBox supplierNameTextBox;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private System.Windows.Forms.TableLayoutPanel formPanel3;
        private MetroFramework.Controls.MetroLabel passwordHintLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel staffIdHintLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton resetFormButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroLabel supplierAddressErrorLabel;
        private MetroFramework.Controls.MetroLabel supplierAddressLabel;
        private MetroFramework.Controls.MetroTextBox supplierAddressTextBox;
        private System.Windows.Forms.GroupBox staffListGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton searchAllButton;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel searchSupplierIdLabel;
        private MetroFramework.Controls.MetroTextBox searchSupplierIdTextBox;
        private MetroFramework.Controls.MetroButton staffDataResetButton;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private System.Windows.Forms.DataGridView supplierListDataGridView;
        private MetroFramework.Controls.MetroButton deleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel emailErrorLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedSupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierContactNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressColumn;
    }
}
