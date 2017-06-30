namespace BackendForCompany
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.forgetPasswordButton = new MetroFramework.Controls.MetroButton();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.idTextbox = new MetroFramework.Controls.MetroTextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.companyInternalUseOnlyLabel = new MetroFramework.Controls.MetroLabel();
            this.languageComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // forgetPasswordButton
            // 
            this.forgetPasswordButton.Highlight = true;
            resources.ApplyResources(this.forgetPasswordButton, "forgetPasswordButton");
            this.forgetPasswordButton.Name = "forgetPasswordButton";
            this.forgetPasswordButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.forgetPasswordButton.UseSelectable = true;
            this.forgetPasswordButton.Click += new System.EventHandler(this.forgetPasswordButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Highlight = true;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextbox
            // 
            // 
            // 
            // 
            this.passwordTextbox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.passwordTextbox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.passwordTextbox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.passwordTextbox.CustomButton.Name = "";
            this.passwordTextbox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextbox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextbox.CustomButton.UseSelectable = true;
            this.passwordTextbox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.passwordTextbox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextbox.Lines = new string[0];
            resources.ApplyResources(this.passwordTextbox, "passwordTextbox");
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.passwordTextbox.UseSelectable = true;
            this.passwordTextbox.UseStyleColors = true;
            this.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // idTextbox
            // 
            // 
            // 
            // 
            this.idTextbox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.idTextbox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.idTextbox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.idTextbox.CustomButton.Name = "";
            this.idTextbox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.idTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextbox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.idTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextbox.CustomButton.UseSelectable = true;
            this.idTextbox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.idTextbox.ForeColor = System.Drawing.Color.Black;
            this.idTextbox.Lines = new string[0];
            resources.ApplyResources(this.idTextbox, "idTextbox");
            this.idTextbox.MaxLength = 32767;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.PasswordChar = '\0';
            this.idTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTextbox.SelectedText = "";
            this.idTextbox.SelectionLength = 0;
            this.idTextbox.SelectionStart = 0;
            this.idTextbox.ShortcutsEnabled = true;
            this.idTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.idTextbox.UseSelectable = true;
            this.idTextbox.UseStyleColors = true;
            this.idTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // logo
            // 
            this.logo.Image = global::BackendForCompany.Properties.Resources.unika;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = global::BackendForCompany.Properties.Resources.login_password;
            resources.ApplyResources(this.passwordPicture, "passwordPicture");
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.TabStop = false;
            // 
            // userPicture
            // 
            this.userPicture.Image = global::BackendForCompany.Properties.Resources.login_user;
            resources.ApplyResources(this.userPicture, "userPicture");
            this.userPicture.Name = "userPicture";
            this.userPicture.TabStop = false;
            // 
            // companyInternalUseOnlyLabel
            // 
            resources.ApplyResources(this.companyInternalUseOnlyLabel, "companyInternalUseOnlyLabel");
            this.companyInternalUseOnlyLabel.Name = "companyInternalUseOnlyLabel";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.languageComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.languageComboBox.UseSelectable = true;
            this.languageComboBox.UseStyleColors = true;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.companyInternalUseOnlyLabel);
            this.Controls.Add(this.forgetPasswordButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.userPicture);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton forgetPasswordButton;
        private System.Windows.Forms.PictureBox logo;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private MetroFramework.Controls.MetroTextBox idTextbox;
        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.PictureBox userPicture;
        private MetroFramework.Controls.MetroLabel companyInternalUseOnlyLabel;
        private MetroFramework.Controls.MetroComboBox languageComboBox;
    }
}