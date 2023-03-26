
namespace WindowsFormsApp1
{
    partial class RegistrationForRole
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TelephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Continue = new System.Windows.Forms.Button();
            this.Authorisation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).BeginInit();
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
            this.Authorisation_panel.Size = new System.Drawing.Size(609, 133);
            this.Authorisation_panel.TabIndex = 6;
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
            this.PeoplePicture.TabIndex = 5;
            this.PeoplePicture.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(30, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 27);
            this.textBox1.TabIndex = 27;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Введите следующие данные:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelephoneNumberTextBox
            // 
            this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneNumberTextBox.Location = new System.Drawing.Point(252, 356);
            this.TelephoneNumberTextBox.Multiline = true;
            this.TelephoneNumberTextBox.Name = "TelephoneNumberTextBox";
            this.TelephoneNumberTextBox.Size = new System.Drawing.Size(194, 47);
            this.TelephoneNumberTextBox.TabIndex = 26;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.Location = new System.Drawing.Point(252, 274);
            this.EmailTxtBox.Multiline = true;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(194, 47);
            this.EmailTxtBox.TabIndex = 25;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(29, 358);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.ReadOnly = true;
            this.PasswordTxtBox.Size = new System.Drawing.Size(218, 28);
            this.PasswordTxtBox.TabIndex = 24;
            this.PasswordTxtBox.TabStop = false;
            this.PasswordTxtBox.Text = "Номер телефона";
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxtBox.Location = new System.Drawing.Point(31, 274);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.ReadOnly = true;
            this.LoginTxtBox.Size = new System.Drawing.Size(87, 28);
            this.LoginTxtBox.TabIndex = 23;
            this.LoginTxtBox.TabStop = false;
            this.LoginTxtBox.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(252, 443);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 47);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "\r\n\r\n";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(31, 443);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(193, 28);
            this.textBox3.TabIndex = 28;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Название роли";
            // 
            // button_Continue
            // 
            this.button_Continue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Continue.Location = new System.Drawing.Point(545, 326);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(207, 60);
            this.button_Continue.TabIndex = 30;
            this.button_Continue.Text = "Продолжить";
            this.button_Continue.UseVisualStyleBackColor = true;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // RegistrationForRole
            // 
            this.AcceptButton = this.button_Continue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TelephoneNumberTextBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.PeoplePicture);
            this.Controls.Add(this.Authorisation_panel);
            this.Name = "RegistrationForRole";
            this.Text = "RegistrationForRole";
            this.Authorisation_panel.ResumeLayout(false);
            this.Authorisation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Authorisation_panel;
        private System.Windows.Forms.PictureBox SmartHousePicture;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.PictureBox PeoplePicture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TelephoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Continue;
    }
}