namespace BackendForCompany.StaffForm
{
    partial class ChangePasswordUserCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUserCtrl));
            this.hintsLabel = new MetroFramework.Controls.MetroLabel();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.confirmPasswordErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.newPasswordErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.confirmPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.newPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.changePasswordButton = new MetroFramework.Controls.MetroButton();
            this.confirmPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.currentPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.currentPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.currentPasswordErrorLabel = new MetroFramework.Controls.MetroLabel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hintsLabel
            // 
            resources.ApplyResources(this.hintsLabel, "hintsLabel");
            this.hintsLabel.Name = "hintsLabel";
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.confirmPasswordErrorLabel, 2, 2);
            this.mainPanel.Controls.Add(this.newPasswordErrorLabel, 2, 1);
            this.mainPanel.Controls.Add(this.confirmPasswordLabel, 0, 2);
            this.mainPanel.Controls.Add(this.newPasswordLabel, 0, 1);
            this.mainPanel.Controls.Add(this.changePasswordButton, 1, 3);
            this.mainPanel.Controls.Add(this.confirmPasswordTextBox, 1, 2);
            this.mainPanel.Controls.Add(this.newPasswordTextBox, 1, 1);
            this.mainPanel.Controls.Add(this.currentPasswordLabel, 0, 0);
            this.mainPanel.Controls.Add(this.currentPasswordTextBox, 1, 0);
            this.mainPanel.Controls.Add(this.currentPasswordErrorLabel, 2, 0);
            this.mainPanel.Name = "mainPanel";
            // 
            // confirmPasswordErrorLabel
            // 
            resources.ApplyResources(this.confirmPasswordErrorLabel, "confirmPasswordErrorLabel");
            this.confirmPasswordErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.confirmPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswordErrorLabel.Name = "confirmPasswordErrorLabel";
            this.confirmPasswordErrorLabel.UseCustomForeColor = true;
            // 
            // newPasswordErrorLabel
            // 
            resources.ApplyResources(this.newPasswordErrorLabel, "newPasswordErrorLabel");
            this.newPasswordErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.newPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newPasswordErrorLabel.Name = "newPasswordErrorLabel";
            this.newPasswordErrorLabel.UseCustomForeColor = true;
            // 
            // confirmPasswordLabel
            // 
            resources.ApplyResources(this.confirmPasswordLabel, "confirmPasswordLabel");
            this.confirmPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            // 
            // newPasswordLabel
            // 
            resources.ApplyResources(this.newPasswordLabel, "newPasswordLabel");
            this.newPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.newPasswordLabel.Name = "newPasswordLabel";
            // 
            // changePasswordButton
            // 
            resources.ApplyResources(this.changePasswordButton, "changePasswordButton");
            this.changePasswordButton.Highlight = true;
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.changePasswordButton.UseSelectable = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // confirmPasswordTextBox
            // 
            resources.ApplyResources(this.confirmPasswordTextBox, "confirmPasswordTextBox");
            // 
            // 
            // 
            this.confirmPasswordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.confirmPasswordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.confirmPasswordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.confirmPasswordTextBox.CustomButton.Name = "";
            this.confirmPasswordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.confirmPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPasswordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.confirmPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPasswordTextBox.CustomButton.UseSelectable = true;
            this.confirmPasswordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.confirmPasswordTextBox.Lines = new string[0];
            this.confirmPasswordTextBox.MaxLength = 32767;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '•';
            this.confirmPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.SelectionLength = 0;
            this.confirmPasswordTextBox.SelectionStart = 0;
            this.confirmPasswordTextBox.ShortcutsEnabled = true;
            this.confirmPasswordTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.confirmPasswordTextBox.UseSelectable = true;
            this.confirmPasswordTextBox.UseStyleColors = true;
            this.confirmPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPasswordTextBox
            // 
            resources.ApplyResources(this.newPasswordTextBox, "newPasswordTextBox");
            // 
            // 
            // 
            this.newPasswordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.newPasswordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.newPasswordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.newPasswordTextBox.CustomButton.Name = "";
            this.newPasswordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.newPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newPasswordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.newPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newPasswordTextBox.CustomButton.UseSelectable = true;
            this.newPasswordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.newPasswordTextBox.Lines = new string[0];
            this.newPasswordTextBox.MaxLength = 32767;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '•';
            this.newPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.SelectionLength = 0;
            this.newPasswordTextBox.SelectionStart = 0;
            this.newPasswordTextBox.ShortcutsEnabled = true;
            this.newPasswordTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.newPasswordTextBox.UseSelectable = true;
            this.newPasswordTextBox.UseStyleColors = true;
            this.newPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // currentPasswordLabel
            // 
            resources.ApplyResources(this.currentPasswordLabel, "currentPasswordLabel");
            this.currentPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            // 
            // currentPasswordTextBox
            // 
            resources.ApplyResources(this.currentPasswordTextBox, "currentPasswordTextBox");
            // 
            // 
            // 
            this.currentPasswordTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.currentPasswordTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.currentPasswordTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.currentPasswordTextBox.CustomButton.Name = "";
            this.currentPasswordTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.currentPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.currentPasswordTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.currentPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.currentPasswordTextBox.CustomButton.UseSelectable = true;
            this.currentPasswordTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.currentPasswordTextBox.Lines = new string[0];
            this.currentPasswordTextBox.MaxLength = 32767;
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '•';
            this.currentPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.currentPasswordTextBox.SelectedText = "";
            this.currentPasswordTextBox.SelectionLength = 0;
            this.currentPasswordTextBox.SelectionStart = 0;
            this.currentPasswordTextBox.ShortcutsEnabled = true;
            this.currentPasswordTextBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.currentPasswordTextBox.UseSelectable = true;
            this.currentPasswordTextBox.UseStyleColors = true;
            this.currentPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.currentPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // currentPasswordErrorLabel
            // 
            resources.ApplyResources(this.currentPasswordErrorLabel, "currentPasswordErrorLabel");
            this.currentPasswordErrorLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.currentPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.currentPasswordErrorLabel.Name = "currentPasswordErrorLabel";
            this.currentPasswordErrorLabel.UseCustomForeColor = true;
            // 
            // ChangePasswordUserCtrl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.hintsLabel);
            this.Name = "ChangePasswordUserCtrl";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel hintsLabel;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private MetroFramework.Controls.MetroTextBox currentPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox confirmPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox newPasswordTextBox;
        private MetroFramework.Controls.MetroLabel currentPasswordLabel;
        private MetroFramework.Controls.MetroButton changePasswordButton;
        private MetroFramework.Controls.MetroLabel confirmPasswordLabel;
        private MetroFramework.Controls.MetroLabel newPasswordLabel;
        private MetroFramework.Controls.MetroLabel currentPasswordErrorLabel;
        private MetroFramework.Controls.MetroLabel confirmPasswordErrorLabel;
        private MetroFramework.Controls.MetroLabel newPasswordErrorLabel;
    }
}
