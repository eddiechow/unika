namespace BackendForCompany.WebMasterForm
{
    partial class StaffManagmentUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagmentUserCtrl));
            this.formPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staffIdLabel = new MetroFramework.Controls.MetroLabel();
            this.positionLabel = new MetroFramework.Controls.MetroLabel();
            this.staffIdHintLabel = new MetroFramework.Controls.MetroLabel();
            this.positionErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.backendStaffRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.backendManagerRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.webMasterRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.idTextBox = new MetroFramework.Controls.MetroTextBox();
            this.formPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.givenNameErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.emailErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.givenNameLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.givenNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.surnameErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.surnameLabel = new MetroFramework.Controls.MetroLabel();
            this.surnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordHintLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.resetFormButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchAllButton = new MetroFramework.Controls.MetroButton();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.searchStaffIdLabel = new MetroFramework.Controls.MetroLabel();
            this.searchStaffIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.staffListGroupBox = new System.Windows.Forms.GroupBox();
            this.staffDataResetButton = new MetroFramework.Controls.MetroButton();
            this.selectAllButton = new MetroFramework.Controls.MetroButton();
            this.deselectAllButton = new MetroFramework.Controls.MetroButton();
            this.staffListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectedStaffColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.staffIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.formPanel1.SuspendLayout();
            this.formPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.staffListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // formPanel1
            // 
            this.formPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.formPanel1, "formPanel1");
            this.formPanel1.Controls.Add(this.staffIdLabel, 0, 5);
            this.formPanel1.Controls.Add(this.positionLabel, 0, 1);
            this.formPanel1.Controls.Add(this.staffIdHintLabel, 1, 6);
            this.formPanel1.Controls.Add(this.positionErrorLabel, 1, 3);
            this.formPanel1.Controls.Add(this.backendStaffRadioButton, 1, 2);
            this.formPanel1.Controls.Add(this.backendManagerRadioButton, 1, 1);
            this.formPanel1.Controls.Add(this.webMasterRadioButton, 1, 0);
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
            // positionErrorLabel
            // 
            resources.ApplyResources(this.positionErrorLabel, "positionErrorLabel");
            this.positionErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.positionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.positionErrorLabel.Name = "positionErrorLabel";
            this.positionErrorLabel.UseCustomForeColor = true;
            // 
            // backendStaffRadioButton
            // 
            resources.ApplyResources(this.backendStaffRadioButton, "backendStaffRadioButton");
            this.backendStaffRadioButton.Name = "backendStaffRadioButton";
            this.backendStaffRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.backendStaffRadioButton.UseCustomForeColor = true;
            this.backendStaffRadioButton.UseSelectable = true;
            this.backendStaffRadioButton.CheckedChanged += new System.EventHandler(this.backendStaffRadioButton_CheckedChanged);
            // 
            // backendManagerRadioButton
            // 
            resources.ApplyResources(this.backendManagerRadioButton, "backendManagerRadioButton");
            this.backendManagerRadioButton.Name = "backendManagerRadioButton";
            this.backendManagerRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.backendManagerRadioButton.UseCustomForeColor = true;
            this.backendManagerRadioButton.UseSelectable = true;
            this.backendManagerRadioButton.CheckedChanged += new System.EventHandler(this.backendManagerRadioButton_CheckedChanged);
            // 
            // webMasterRadioButton
            // 
            resources.ApplyResources(this.webMasterRadioButton, "webMasterRadioButton");
            this.webMasterRadioButton.Name = "webMasterRadioButton";
            this.webMasterRadioButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.webMasterRadioButton.UseCustomForeColor = true;
            this.webMasterRadioButton.UseSelectable = true;
            this.webMasterRadioButton.CheckedChanged += new System.EventHandler(this.webMasterRadioButton_CheckedChanged);
            // 
            // idTextBox
            // 
            resources.ApplyResources(this.idTextBox, "idTextBox");
            // 
            // 
            // 
            this.idTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.idTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.idTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.idTextBox.CustomButton.Name = "";
            this.idTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.idTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.idTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextBox.CustomButton.UseSelectable = true;
            this.idTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.idTextBox.Lines = new string[0];
            this.idTextBox.MaxLength = 8;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '\0';
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
            this.formPanel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.formPanel2, "formPanel2");
            this.formPanel2.Controls.Add(this.givenNameErrorLabel, 1, 4);
            this.formPanel2.Controls.Add(this.emailErrorLabel, 1, 7);
            this.formPanel2.Controls.Add(this.givenNameLabel, 0, 3);
            this.formPanel2.Controls.Add(this.emailLabel, 0, 6);
            this.formPanel2.Controls.Add(this.givenNameTextBox, 1, 3);
            this.formPanel2.Controls.Add(this.surnameErrorLabel, 1, 1);
            this.formPanel2.Controls.Add(this.surnameLabel, 0, 0);
            this.formPanel2.Controls.Add(this.surnameTextBox, 1, 0);
            this.formPanel2.Controls.Add(this.emailTextBox, 1, 6);
            this.formPanel2.Name = "formPanel2";
            // 
            // givenNameErrorLabel
            // 
            resources.ApplyResources(this.givenNameErrorLabel, "givenNameErrorLabel");
            this.givenNameErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.givenNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.givenNameErrorLabel.Name = "givenNameErrorLabel";
            this.givenNameErrorLabel.UseCustomForeColor = true;
            // 
            // emailErrorLabel
            // 
            resources.ApplyResources(this.emailErrorLabel, "emailErrorLabel");
            this.emailErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.UseCustomForeColor = true;
            // 
            // givenNameLabel
            // 
            resources.ApplyResources(this.givenNameLabel, "givenNameLabel");
            this.givenNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.givenNameLabel.Name = "givenNameLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.emailLabel.Name = "emailLabel";
            // 
            // givenNameTextBox
            // 
            resources.ApplyResources(this.givenNameTextBox, "givenNameTextBox");
            // 
            // 
            // 
            this.givenNameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.givenNameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.givenNameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.givenNameTextBox.CustomButton.Name = "";
            this.givenNameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.givenNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.givenNameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.givenNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.givenNameTextBox.CustomButton.UseSelectable = true;
            this.givenNameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.givenNameTextBox.Lines = new string[0];
            this.givenNameTextBox.MaxLength = 32767;
            this.givenNameTextBox.Name = "givenNameTextBox";
            this.givenNameTextBox.PasswordChar = '\0';
            this.givenNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.givenNameTextBox.SelectedText = "";
            this.givenNameTextBox.SelectionLength = 0;
            this.givenNameTextBox.SelectionStart = 0;
            this.givenNameTextBox.ShortcutsEnabled = true;
            this.givenNameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.givenNameTextBox.UseSelectable = true;
            this.givenNameTextBox.UseStyleColors = true;
            this.givenNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.givenNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // surnameErrorLabel
            // 
            resources.ApplyResources(this.surnameErrorLabel, "surnameErrorLabel");
            this.surnameErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.surnameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.surnameErrorLabel.Name = "surnameErrorLabel";
            this.surnameErrorLabel.UseCustomForeColor = true;
            // 
            // surnameLabel
            // 
            resources.ApplyResources(this.surnameLabel, "surnameLabel");
            this.surnameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.surnameLabel.Name = "surnameLabel";
            // 
            // surnameTextBox
            // 
            resources.ApplyResources(this.surnameTextBox, "surnameTextBox");
            // 
            // 
            // 
            this.surnameTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.surnameTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.surnameTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.surnameTextBox.CustomButton.Name = "";
            this.surnameTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.surnameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.surnameTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.surnameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.surnameTextBox.CustomButton.UseSelectable = true;
            this.surnameTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.surnameTextBox.Lines = new string[0];
            this.surnameTextBox.MaxLength = 32767;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.SelectionLength = 0;
            this.surnameTextBox.SelectionStart = 0;
            this.surnameTextBox.ShortcutsEnabled = true;
            this.surnameTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.surnameTextBox.UseSelectable = true;
            this.surnameTextBox.UseStyleColors = true;
            this.surnameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.surnameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.emailTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.emailTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
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
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.passwordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.passwordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.passwordHintLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // passwordHintLabel
            // 
            this.passwordHintLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passwordHintLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.passwordHintLabel, "passwordHintLabel");
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.resetFormButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.addButton, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
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
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.searchAllButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchStaffIdLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchStaffIdTextBox, 1, 0);
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
            // searchStaffIdLabel
            // 
            resources.ApplyResources(this.searchStaffIdLabel, "searchStaffIdLabel");
            this.searchStaffIdLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.searchStaffIdLabel.Name = "searchStaffIdLabel";
            // 
            // searchStaffIdTextBox
            // 
            resources.ApplyResources(this.searchStaffIdTextBox, "searchStaffIdTextBox");
            this.searchStaffIdTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchStaffIdTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.searchStaffIdTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.searchStaffIdTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode5")));
            this.searchStaffIdTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location5")));
            this.searchStaffIdTextBox.CustomButton.Name = "";
            this.searchStaffIdTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size5")));
            this.searchStaffIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchStaffIdTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex5")));
            this.searchStaffIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchStaffIdTextBox.CustomButton.UseSelectable = true;
            this.searchStaffIdTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible5")));
            this.searchStaffIdTextBox.Lines = new string[0];
            this.searchStaffIdTextBox.MaxLength = 32767;
            this.searchStaffIdTextBox.Name = "searchStaffIdTextBox";
            this.searchStaffIdTextBox.PasswordChar = '\0';
            this.searchStaffIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchStaffIdTextBox.SelectedText = "";
            this.searchStaffIdTextBox.SelectionLength = 0;
            this.searchStaffIdTextBox.SelectionStart = 0;
            this.searchStaffIdTextBox.ShortcutsEnabled = true;
            this.searchStaffIdTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.searchStaffIdTextBox.UseSelectable = true;
            this.searchStaffIdTextBox.UseStyleColors = true;
            this.searchStaffIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchStaffIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // staffListGroupBox
            // 
            this.staffListGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.staffListGroupBox.Controls.Add(this.staffDataResetButton);
            this.staffListGroupBox.Controls.Add(this.selectAllButton);
            this.staffListGroupBox.Controls.Add(this.deselectAllButton);
            this.staffListGroupBox.Controls.Add(this.staffListDataGridView);
            this.staffListGroupBox.Controls.Add(this.deleteButton);
            resources.ApplyResources(this.staffListGroupBox, "staffListGroupBox");
            this.staffListGroupBox.Name = "staffListGroupBox";
            this.staffListGroupBox.TabStop = false;
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
            // staffListDataGridView
            // 
            this.staffListDataGridView.AllowUserToAddRows = false;
            this.staffListDataGridView.AllowUserToDeleteRows = false;
            this.staffListDataGridView.AllowUserToResizeColumns = false;
            this.staffListDataGridView.AllowUserToResizeRows = false;
            this.staffListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staffListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedStaffColumn,
            this.staffIdColumn,
            this.staffNameColumn,
            this.emailColumn,
            this.positionColumn});
            resources.ApplyResources(this.staffListDataGridView, "staffListDataGridView");
            this.staffListDataGridView.MultiSelect = false;
            this.staffListDataGridView.Name = "staffListDataGridView";
            this.staffListDataGridView.RowHeadersVisible = false;
            this.staffListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffListDataGridView_CellClick);
            // 
            // selectedStaffColumn
            // 
            this.selectedStaffColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectedStaffColumn.FillWeight = 91.37056F;
            resources.ApplyResources(this.selectedStaffColumn, "selectedStaffColumn");
            this.selectedStaffColumn.Name = "selectedStaffColumn";
            // 
            // staffIdColumn
            // 
            this.staffIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.staffIdColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.staffIdColumn, "staffIdColumn");
            this.staffIdColumn.Name = "staffIdColumn";
            this.staffIdColumn.ReadOnly = true;
            // 
            // staffNameColumn
            // 
            this.staffNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staffNameColumn.FillWeight = 101.0787F;
            resources.ApplyResources(this.staffNameColumn, "staffNameColumn");
            this.staffNameColumn.Name = "staffNameColumn";
            this.staffNameColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailColumn.FillWeight = 83.48683F;
            resources.ApplyResources(this.emailColumn, "emailColumn");
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // positionColumn
            // 
            this.positionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.positionColumn, "positionColumn");
            this.positionColumn.Name = "positionColumn";
            this.positionColumn.ReadOnly = true;
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
            // StaffManagmentUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.staffListGroupBox);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.formPanel2);
            this.Controls.Add(this.formPanel1);
            this.Name = "StaffManagmentUserCtrl";
            this.formPanel1.ResumeLayout(false);
            this.formPanel1.PerformLayout();
            this.formPanel2.ResumeLayout(false);
            this.formPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.staffListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formPanel1;
        private MetroFramework.Controls.MetroRadioButton backendManagerRadioButton;
        private MetroFramework.Controls.MetroRadioButton webMasterRadioButton;
        private MetroFramework.Controls.MetroRadioButton backendStaffRadioButton;
        private MetroFramework.Controls.MetroLabel positionErrorLabel;
        private MetroFramework.Controls.MetroTextBox idTextBox;
        private MetroFramework.Controls.MetroLabel staffIdHintLabel;
        private MetroFramework.Controls.MetroLabel positionLabel;
        private MetroFramework.Controls.MetroLabel staffIdLabel;
        private System.Windows.Forms.TableLayoutPanel formPanel2;
        private MetroFramework.Controls.MetroTextBox surnameTextBox;
        private MetroFramework.Controls.MetroLabel surnameLabel;
        private MetroFramework.Controls.MetroLabel surnameErrorLabel;
        private MetroFramework.Controls.MetroLabel givenNameLabel;
        private MetroFramework.Controls.MetroTextBox givenNameTextBox;
        private MetroFramework.Controls.MetroLabel givenNameErrorLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel passwordHintLabel;
        private MetroFramework.Controls.MetroLabel emailErrorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton resetFormButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton searchAllButton;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel searchStaffIdLabel;
        private MetroFramework.Controls.MetroTextBox searchStaffIdTextBox;
        private System.Windows.Forms.GroupBox staffListGroupBox;
        private MetroFramework.Controls.MetroButton staffDataResetButton;
        private MetroFramework.Controls.MetroButton selectAllButton;
        private MetroFramework.Controls.MetroButton deselectAllButton;
        private System.Windows.Forms.DataGridView staffListDataGridView;
        private MetroFramework.Controls.MetroButton deleteButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedStaffColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
    }
}
