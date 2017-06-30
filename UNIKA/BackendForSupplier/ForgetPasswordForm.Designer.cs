namespace BackendForSupplier
{
    partial class ForgetPasswordForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
            this.idTextbox = new MetroFramework.Controls.MetroTextBox();
            this.sendTokenButton = new MetroFramework.Controls.MetroButton();
            this.TokenGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.idErrorLabel = new System.Windows.Forms.Label();
            this.resetPasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmPasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.confirmPasswordErrorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tokenTextbox = new MetroFramework.Controls.MetroTextBox();
            this.tokenErrorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.newPasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.newPasswordErrorLabel = new System.Windows.Forms.Label();
            this.resetPasswordButton = new MetroFramework.Controls.MetroButton();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.SecurityTokenLabel = new System.Windows.Forms.Label();
            this.tokenTimer = new System.Windows.Forms.Timer(this.components);
            this.hintsLabel = new System.Windows.Forms.Label();
            this.TokenGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.resetPasswordGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTextbox
            // 
            resources.ApplyResources(this.idTextbox, "idTextbox");
            // 
            // 
            // 
            this.idTextbox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.idTextbox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.idTextbox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.idTextbox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.idTextbox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.idTextbox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.idTextbox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.idTextbox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.idTextbox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.idTextbox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.idTextbox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.idTextbox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.idTextbox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.idTextbox.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.idTextbox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.idTextbox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.idTextbox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.idTextbox.CustomButton.Name = "";
            this.idTextbox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.idTextbox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.idTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTextbox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.idTextbox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.idTextbox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.idTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTextbox.CustomButton.UseSelectable = true;
            this.idTextbox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.idTextbox.ForeColor = System.Drawing.Color.Black;
            this.idTextbox.Lines = new string[0];
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
            // sendTokenButton
            // 
            resources.ApplyResources(this.sendTokenButton, "sendTokenButton");
            this.sendTokenButton.Highlight = true;
            this.sendTokenButton.Name = "sendTokenButton";
            this.sendTokenButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.sendTokenButton.UseSelectable = true;
            this.sendTokenButton.Click += new System.EventHandler(this.sendTokenButton_Click);
            // 
            // TokenGroupBox
            // 
            resources.ApplyResources(this.TokenGroupBox, "TokenGroupBox");
            this.TokenGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.TokenGroupBox.Controls.Add(this.sendTokenButton);
            this.TokenGroupBox.Name = "TokenGroupBox";
            this.TokenGroupBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.userPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.idTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.idErrorLabel, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // userPicture
            // 
            resources.ApplyResources(this.userPicture, "userPicture");
            this.userPicture.Image = global::BackendForSupplier.Properties.Resources.login_user;
            this.userPicture.Name = "userPicture";
            this.userPicture.TabStop = false;
            // 
            // idErrorLabel
            // 
            resources.ApplyResources(this.idErrorLabel, "idErrorLabel");
            this.idErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.idErrorLabel.Name = "idErrorLabel";
            // 
            // resetPasswordGroupBox
            // 
            resources.ApplyResources(this.resetPasswordGroupBox, "resetPasswordGroupBox");
            this.resetPasswordGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.resetPasswordGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.resetPasswordGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.resetPasswordGroupBox.Controls.Add(this.resetPasswordButton);
            this.resetPasswordGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.resetPasswordGroupBox.Controls.Add(this.newPasswordLabel);
            this.resetPasswordGroupBox.Controls.Add(this.SecurityTokenLabel);
            this.resetPasswordGroupBox.Name = "resetPasswordGroupBox";
            this.resetPasswordGroupBox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.confirmPasswordTextbox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.confirmPasswordErrorLabel, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // confirmPasswordTextbox
            // 
            resources.ApplyResources(this.confirmPasswordTextbox, "confirmPasswordTextbox");
            // 
            // 
            // 
            this.confirmPasswordTextbox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.confirmPasswordTextbox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.confirmPasswordTextbox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.confirmPasswordTextbox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.confirmPasswordTextbox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.confirmPasswordTextbox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.confirmPasswordTextbox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.confirmPasswordTextbox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.confirmPasswordTextbox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.confirmPasswordTextbox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.confirmPasswordTextbox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.confirmPasswordTextbox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.confirmPasswordTextbox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.confirmPasswordTextbox.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.confirmPasswordTextbox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.confirmPasswordTextbox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.confirmPasswordTextbox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.confirmPasswordTextbox.CustomButton.Name = "";
            this.confirmPasswordTextbox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.confirmPasswordTextbox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.confirmPasswordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPasswordTextbox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.confirmPasswordTextbox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.confirmPasswordTextbox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.confirmPasswordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPasswordTextbox.CustomButton.UseSelectable = true;
            this.confirmPasswordTextbox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.confirmPasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordTextbox.Lines = new string[0];
            this.confirmPasswordTextbox.MaxLength = 32767;
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.PasswordChar = '•';
            this.confirmPasswordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPasswordTextbox.SelectedText = "";
            this.confirmPasswordTextbox.SelectionLength = 0;
            this.confirmPasswordTextbox.SelectionStart = 0;
            this.confirmPasswordTextbox.ShortcutsEnabled = true;
            this.confirmPasswordTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.confirmPasswordTextbox.UseSelectable = true;
            this.confirmPasswordTextbox.UseStyleColors = true;
            this.confirmPasswordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPasswordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmPasswordErrorLabel
            // 
            resources.ApplyResources(this.confirmPasswordErrorLabel, "confirmPasswordErrorLabel");
            this.confirmPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswordErrorLabel.Name = "confirmPasswordErrorLabel";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tokenTextbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tokenErrorLabel, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tokenTextbox
            // 
            resources.ApplyResources(this.tokenTextbox, "tokenTextbox");
            // 
            // 
            // 
            this.tokenTextbox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.tokenTextbox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.tokenTextbox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor2")));
            this.tokenTextbox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize2")));
            this.tokenTextbox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode2")));
            this.tokenTextbox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.tokenTextbox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout2")));
            this.tokenTextbox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.tokenTextbox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle2")));
            this.tokenTextbox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.tokenTextbox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.tokenTextbox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign2")));
            this.tokenTextbox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex2")));
            this.tokenTextbox.CustomButton.ImageKey = resources.GetString("resource.ImageKey2");
            this.tokenTextbox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.tokenTextbox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.tokenTextbox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize2")));
            this.tokenTextbox.CustomButton.Name = "";
            this.tokenTextbox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft2")));
            this.tokenTextbox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.tokenTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tokenTextbox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.tokenTextbox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign2")));
            this.tokenTextbox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation2")));
            this.tokenTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tokenTextbox.CustomButton.UseSelectable = true;
            this.tokenTextbox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.tokenTextbox.ForeColor = System.Drawing.Color.Black;
            this.tokenTextbox.Lines = new string[0];
            this.tokenTextbox.MaxLength = 32767;
            this.tokenTextbox.Name = "tokenTextbox";
            this.tokenTextbox.PasswordChar = '\0';
            this.tokenTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tokenTextbox.SelectedText = "";
            this.tokenTextbox.SelectionLength = 0;
            this.tokenTextbox.SelectionStart = 0;
            this.tokenTextbox.ShortcutsEnabled = true;
            this.tokenTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tokenTextbox.UseSelectable = true;
            this.tokenTextbox.UseStyleColors = true;
            this.tokenTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tokenTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tokenErrorLabel
            // 
            resources.ApplyResources(this.tokenErrorLabel, "tokenErrorLabel");
            this.tokenErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.tokenErrorLabel.Name = "tokenErrorLabel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.newPasswordTextbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.newPasswordErrorLabel, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // newPasswordTextbox
            // 
            resources.ApplyResources(this.newPasswordTextbox, "newPasswordTextbox");
            // 
            // 
            // 
            this.newPasswordTextbox.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3");
            this.newPasswordTextbox.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName3");
            this.newPasswordTextbox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor3")));
            this.newPasswordTextbox.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize3")));
            this.newPasswordTextbox.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode3")));
            this.newPasswordTextbox.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage3")));
            this.newPasswordTextbox.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout3")));
            this.newPasswordTextbox.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock3")));
            this.newPasswordTextbox.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle3")));
            this.newPasswordTextbox.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font3")));
            this.newPasswordTextbox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.newPasswordTextbox.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign3")));
            this.newPasswordTextbox.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex3")));
            this.newPasswordTextbox.CustomButton.ImageKey = resources.GetString("resource.ImageKey3");
            this.newPasswordTextbox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.newPasswordTextbox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.newPasswordTextbox.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize3")));
            this.newPasswordTextbox.CustomButton.Name = "";
            this.newPasswordTextbox.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft3")));
            this.newPasswordTextbox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.newPasswordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newPasswordTextbox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.newPasswordTextbox.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign3")));
            this.newPasswordTextbox.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation3")));
            this.newPasswordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newPasswordTextbox.CustomButton.UseSelectable = true;
            this.newPasswordTextbox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.newPasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.newPasswordTextbox.Lines = new string[0];
            this.newPasswordTextbox.MaxLength = 32767;
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.PasswordChar = '•';
            this.newPasswordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPasswordTextbox.SelectedText = "";
            this.newPasswordTextbox.SelectionLength = 0;
            this.newPasswordTextbox.SelectionStart = 0;
            this.newPasswordTextbox.ShortcutsEnabled = true;
            this.newPasswordTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.newPasswordTextbox.UseSelectable = true;
            this.newPasswordTextbox.UseStyleColors = true;
            this.newPasswordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newPasswordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPasswordErrorLabel
            // 
            resources.ApplyResources(this.newPasswordErrorLabel, "newPasswordErrorLabel");
            this.newPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newPasswordErrorLabel.Name = "newPasswordErrorLabel";
            // 
            // resetPasswordButton
            // 
            resources.ApplyResources(this.resetPasswordButton, "resetPasswordButton");
            this.resetPasswordButton.Highlight = true;
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.resetPasswordButton.UseSelectable = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // confirmPasswordLabel
            // 
            resources.ApplyResources(this.confirmPasswordLabel, "confirmPasswordLabel");
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            // 
            // newPasswordLabel
            // 
            resources.ApplyResources(this.newPasswordLabel, "newPasswordLabel");
            this.newPasswordLabel.Name = "newPasswordLabel";
            // 
            // SecurityTokenLabel
            // 
            resources.ApplyResources(this.SecurityTokenLabel, "SecurityTokenLabel");
            this.SecurityTokenLabel.Name = "SecurityTokenLabel";
            // 
            // tokenTimer
            // 
            this.tokenTimer.Interval = 1000;
            this.tokenTimer.Tick += new System.EventHandler(this.tokenTimer_Tick);
            // 
            // hintsLabel
            // 
            resources.ApplyResources(this.hintsLabel, "hintsLabel");
            this.hintsLabel.Name = "hintsLabel";
            // 
            // ForgetPasswordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hintsLabel);
            this.Controls.Add(this.resetPasswordGroupBox);
            this.Controls.Add(this.TokenGroupBox);
            this.MaximizeBox = false;
            this.Name = "ForgetPasswordForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TokenGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.resetPasswordGroupBox.ResumeLayout(false);
            this.resetPasswordGroupBox.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox idTextbox;
        private System.Windows.Forms.PictureBox userPicture;
        private MetroFramework.Controls.MetroButton sendTokenButton;
        private System.Windows.Forms.GroupBox TokenGroupBox;
        private System.Windows.Forms.GroupBox resetPasswordGroupBox;
        private System.Windows.Forms.Label SecurityTokenLabel;
        private MetroFramework.Controls.MetroTextBox tokenTextbox;
        private MetroFramework.Controls.MetroButton resetPasswordButton;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private MetroFramework.Controls.MetroTextBox confirmPasswordTextbox;
        private System.Windows.Forms.Label newPasswordLabel;
        private MetroFramework.Controls.MetroTextBox newPasswordTextbox;
        private System.Windows.Forms.Timer tokenTimer;
        private System.Windows.Forms.Label hintsLabel;
        private System.Windows.Forms.Label idErrorLabel;
        private System.Windows.Forms.Label tokenErrorLabel;
        private System.Windows.Forms.Label confirmPasswordErrorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label newPasswordErrorLabel;
    }
}