
namespace WindowsFormsApp1
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.AuthorisationLabel = new System.Windows.Forms.Label();
            this.Authorisation_panel = new System.Windows.Forms.Panel();
            this.SmartHousePicture = new System.Windows.Forms.PictureBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LogEntTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordEntTxtBox = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.NoAccauntLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UnHidePictureBox = new System.Windows.Forms.PictureBox();
            this.HidePictureBox = new System.Windows.Forms.PictureBox();
            this.PeoplePicture = new System.Windows.Forms.PictureBox();
            this.Authorisation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnHidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorisationLabel
            // 
            this.AuthorisationLabel.AutoSize = true;
            this.AuthorisationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorisationLabel.Location = new System.Drawing.Point(11, 50);
            this.AuthorisationLabel.Name = "AuthorisationLabel";
            this.AuthorisationLabel.Size = new System.Drawing.Size(190, 33);
            this.AuthorisationLabel.TabIndex = 1;
            this.AuthorisationLabel.Text = "Авторизация";
            // 
            // Authorisation_panel
            // 
            this.Authorisation_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Authorisation_panel.Controls.Add(this.SmartHousePicture);
            this.Authorisation_panel.Controls.Add(this.AuthorisationLabel);
            this.Authorisation_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Authorisation_panel.Location = new System.Drawing.Point(179, 12);
            this.Authorisation_panel.Name = "Authorisation_panel";
            this.Authorisation_panel.Size = new System.Drawing.Size(592, 133);
            this.Authorisation_panel.TabIndex = 2;
            // 
            // SmartHousePicture
            // 
            this.SmartHousePicture.Image = global::WindowsFormsApp1.Properties.Resources.smarthouse;
            this.SmartHousePicture.Location = new System.Drawing.Point(457, 20);
            this.SmartHousePicture.Name = "SmartHousePicture";
            this.SmartHousePicture.Size = new System.Drawing.Size(116, 97);
            this.SmartHousePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmartHousePicture.TabIndex = 2;
            this.SmartHousePicture.TabStop = false;
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxtBox.Location = new System.Drawing.Point(133, 220);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.ReadOnly = true;
            this.LoginTxtBox.Size = new System.Drawing.Size(100, 28);
            this.LoginTxtBox.TabIndex = 3;
            this.LoginTxtBox.TabStop = false;
            this.LoginTxtBox.Text = "Логин:";
            this.LoginTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(133, 301);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.ReadOnly = true;
            this.PasswordTxtBox.Size = new System.Drawing.Size(100, 28);
            this.PasswordTxtBox.TabIndex = 4;
            this.PasswordTxtBox.TabStop = false;
            this.PasswordTxtBox.Text = "Пароль:";
            this.PasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogEntTxtBox
            // 
            this.LogEntTxtBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogEntTxtBox.Location = new System.Drawing.Point(277, 218);
            this.LogEntTxtBox.Multiline = true;
            this.LogEntTxtBox.Name = "LogEntTxtBox";
            this.LogEntTxtBox.Size = new System.Drawing.Size(207, 47);
            this.LogEntTxtBox.TabIndex = 5;
            // 
            // PasswordEntTxtBox
            // 
            this.PasswordEntTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEntTxtBox.Location = new System.Drawing.Point(277, 299);
            this.PasswordEntTxtBox.Multiline = true;
            this.PasswordEntTxtBox.Name = "PasswordEntTxtBox";
            this.PasswordEntTxtBox.Size = new System.Drawing.Size(207, 47);
            this.PasswordEntTxtBox.TabIndex = 6;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(277, 368);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(207, 60);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // NoAccauntLink
            // 
            this.NoAccauntLink.AutoSize = true;
            this.NoAccauntLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoAccauntLink.LinkColor = System.Drawing.Color.SlateGray;
            this.NoAccauntLink.Location = new System.Drawing.Point(303, 463);
            this.NoAccauntLink.Name = "NoAccauntLink";
            this.NoAccauntLink.Size = new System.Drawing.Size(154, 20);
            this.NoAccauntLink.TabIndex = 10;
            this.NoAccauntLink.TabStop = true;
            this.NoAccauntLink.Text = "Ещё нет аккаунта?";
            this.NoAccauntLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoAccauntLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(66, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // UnHidePictureBox
            // 
            this.UnHidePictureBox.Image = global::WindowsFormsApp1.Properties.Resources.unhide;
            this.UnHidePictureBox.Location = new System.Drawing.Point(500, 308);
            this.UnHidePictureBox.Name = "UnHidePictureBox";
            this.UnHidePictureBox.Size = new System.Drawing.Size(32, 28);
            this.UnHidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnHidePictureBox.TabIndex = 8;
            this.UnHidePictureBox.TabStop = false;
            this.UnHidePictureBox.Click += new System.EventHandler(this.UnHidePictureBox_Click);
            // 
            // HidePictureBox
            // 
            this.HidePictureBox.Image = global::WindowsFormsApp1.Properties.Resources.hide;
            this.HidePictureBox.Location = new System.Drawing.Point(500, 308);
            this.HidePictureBox.Name = "HidePictureBox";
            this.HidePictureBox.Size = new System.Drawing.Size(32, 28);
            this.HidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePictureBox.TabIndex = 7;
            this.HidePictureBox.TabStop = false;
            this.HidePictureBox.Click += new System.EventHandler(this.HidePictureBox_Click);
            // 
            // PeoplePicture
            // 
            this.PeoplePicture.Image = ((System.Drawing.Image)(resources.GetObject("PeoplePicture.Image")));
            this.PeoplePicture.Location = new System.Drawing.Point(12, 12);
            this.PeoplePicture.Name = "PeoplePicture";
            this.PeoplePicture.Size = new System.Drawing.Size(161, 134);
            this.PeoplePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PeoplePicture.TabIndex = 0;
            this.PeoplePicture.TabStop = false;
            // 
            // log_in
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NoAccauntLink);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.UnHidePictureBox);
            this.Controls.Add(this.HidePictureBox);
            this.Controls.Add(this.PasswordEntTxtBox);
            this.Controls.Add(this.LogEntTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.Authorisation_panel);
            this.Controls.Add(this.PeoplePicture);
            this.Name = "log_in";
            this.Text = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.Authorisation_panel.ResumeLayout(false);
            this.Authorisation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnHidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PeoplePicture;
        private System.Windows.Forms.Label AuthorisationLabel;
        private System.Windows.Forms.Panel Authorisation_panel;
        private System.Windows.Forms.PictureBox SmartHousePicture;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox LogEntTxtBox;
        private System.Windows.Forms.TextBox PasswordEntTxtBox;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel NoAccauntLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox HidePictureBox;
        private System.Windows.Forms.PictureBox UnHidePictureBox;
    }
}