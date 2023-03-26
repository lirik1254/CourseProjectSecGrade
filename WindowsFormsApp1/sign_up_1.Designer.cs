
namespace WindowsFormsApp1
{
    partial class sign_up_1
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
            this.Authorisation_panel = new System.Windows.Forms.Panel();
            this.SmartHousePicture = new System.Windows.Forms.PictureBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.PeoplePicture = new System.Windows.Forms.PictureBox();
            this.button_Continue = new System.Windows.Forms.Button();
            this.UnHidePictureBox = new System.Windows.Forms.PictureBox();
            this.PasswordEntTxtBox = new System.Windows.Forms.TextBox();
            this.LogEntTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.HidePictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Authorisation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnHidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Authorisation_panel
            // 
            this.Authorisation_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Authorisation_panel.Controls.Add(this.SmartHousePicture);
            this.Authorisation_panel.Controls.Add(this.RegistrationLabel);
            this.Authorisation_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Authorisation_panel.Location = new System.Drawing.Point(179, 12);
            this.Authorisation_panel.Name = "Authorisation_panel";
            this.Authorisation_panel.Size = new System.Drawing.Size(592, 133);
            this.Authorisation_panel.TabIndex = 3;
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
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.Location = new System.Drawing.Point(11, 50);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(186, 33);
            this.RegistrationLabel.TabIndex = 1;
            this.RegistrationLabel.Text = "Регистрация";
            // 
            // PeoplePicture
            // 
            this.PeoplePicture.Image = global::WindowsFormsApp1.Properties.Resources.add_user;
            this.PeoplePicture.Location = new System.Drawing.Point(12, 12);
            this.PeoplePicture.Name = "PeoplePicture";
            this.PeoplePicture.Size = new System.Drawing.Size(161, 134);
            this.PeoplePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PeoplePicture.TabIndex = 3;
            this.PeoplePicture.TabStop = false;
            // 
            // button_Continue
            // 
            this.button_Continue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Continue.Location = new System.Drawing.Point(286, 402);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(207, 60);
            this.button_Continue.TabIndex = 16;
            this.button_Continue.Text = "Продолжить";
            this.button_Continue.UseVisualStyleBackColor = true;
            this.button_Continue.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // UnHidePictureBox
            // 
            this.UnHidePictureBox.Image = global::WindowsFormsApp1.Properties.Resources.unhide;
            this.UnHidePictureBox.Location = new System.Drawing.Point(510, 341);
            this.UnHidePictureBox.Name = "UnHidePictureBox";
            this.UnHidePictureBox.Size = new System.Drawing.Size(32, 28);
            this.UnHidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnHidePictureBox.TabIndex = 15;
            this.UnHidePictureBox.TabStop = false;
            this.UnHidePictureBox.Click += new System.EventHandler(this.UnHidePictureBox_Click);
            // 
            // PasswordEntTxtBox
            // 
            this.PasswordEntTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEntTxtBox.Location = new System.Drawing.Point(286, 333);
            this.PasswordEntTxtBox.Multiline = true;
            this.PasswordEntTxtBox.Name = "PasswordEntTxtBox";
            this.PasswordEntTxtBox.Size = new System.Drawing.Size(207, 47);
            this.PasswordEntTxtBox.TabIndex = 14;
            // 
            // LogEntTxtBox
            // 
            this.LogEntTxtBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogEntTxtBox.Location = new System.Drawing.Point(286, 252);
            this.LogEntTxtBox.Multiline = true;
            this.LogEntTxtBox.Name = "LogEntTxtBox";
            this.LogEntTxtBox.Size = new System.Drawing.Size(207, 47);
            this.LogEntTxtBox.TabIndex = 13;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(142, 335);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.ReadOnly = true;
            this.PasswordTxtBox.Size = new System.Drawing.Size(100, 28);
            this.PasswordTxtBox.TabIndex = 12;
            this.PasswordTxtBox.TabStop = false;
            this.PasswordTxtBox.Text = "Пароль:";
            this.PasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxtBox.Location = new System.Drawing.Point(142, 254);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.ReadOnly = true;
            this.LoginTxtBox.Size = new System.Drawing.Size(100, 28);
            this.LoginTxtBox.TabIndex = 11;
            this.LoginTxtBox.TabStop = false;
            this.LoginTxtBox.Text = "Логин:";
            this.LoginTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HidePictureBox
            // 
            this.HidePictureBox.Image = global::WindowsFormsApp1.Properties.Resources.hide;
            this.HidePictureBox.Location = new System.Drawing.Point(510, 341);
            this.HidePictureBox.Name = "HidePictureBox";
            this.HidePictureBox.Size = new System.Drawing.Size(32, 28);
            this.HidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HidePictureBox.TabIndex = 17;
            this.HidePictureBox.TabStop = false;
            this.HidePictureBox.Click += new System.EventHandler(this.HidePictureBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(245, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 27);
            this.textBox1.TabIndex = 18;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Введите логин и пароль";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sign_up_1
            // 
            this.AcceptButton = this.button_Continue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 508);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HidePictureBox);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.UnHidePictureBox);
            this.Controls.Add(this.PasswordEntTxtBox);
            this.Controls.Add(this.LogEntTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.PeoplePicture);
            this.Controls.Add(this.Authorisation_panel);
            this.Name = "sign_up_1";
            this.Text = "sign_up";
            this.Load += new System.EventHandler(this.sign_up_Load);
            this.Authorisation_panel.ResumeLayout(false);
            this.Authorisation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnHidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Authorisation_panel;
        private System.Windows.Forms.PictureBox SmartHousePicture;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.PictureBox PeoplePicture;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.PictureBox UnHidePictureBox;
        private System.Windows.Forms.TextBox PasswordEntTxtBox;
        private System.Windows.Forms.TextBox LogEntTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.PictureBox HidePictureBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}