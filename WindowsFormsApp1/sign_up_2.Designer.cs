
namespace WindowsFormsApp1
{
    partial class sign_up_2
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
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.Authorisation_panel = new System.Windows.Forms.Panel();
            this.button_Create = new System.Windows.Forms.Button();
            this.TelephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.PeoplePicture = new System.Windows.Forms.PictureBox();
            this.SmartHousePicture = new System.Windows.Forms.PictureBox();
            this.Authorisation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).BeginInit();
            this.SuspendLayout();
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
            // Authorisation_panel
            // 
            this.Authorisation_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Authorisation_panel.Controls.Add(this.SmartHousePicture);
            this.Authorisation_panel.Controls.Add(this.RegistrationLabel);
            this.Authorisation_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Authorisation_panel.Location = new System.Drawing.Point(179, 12);
            this.Authorisation_panel.Name = "Authorisation_panel";
            this.Authorisation_panel.Size = new System.Drawing.Size(592, 133);
            this.Authorisation_panel.TabIndex = 5;
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create.Location = new System.Drawing.Point(530, 336);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(194, 122);
            this.button_Create.TabIndex = 21;
            this.button_Create.Text = " Создать Аккаунт";
            this.button_Create.UseVisualStyleBackColor = true;
            // 
            // TelephoneNumberTextBox
            // 
            this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneNumberTextBox.Location = new System.Drawing.Point(261, 348);
            this.TelephoneNumberTextBox.Multiline = true;
            this.TelephoneNumberTextBox.Name = "TelephoneNumberTextBox";
            this.TelephoneNumberTextBox.Size = new System.Drawing.Size(194, 47);
            this.TelephoneNumberTextBox.TabIndex = 20;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.Location = new System.Drawing.Point(261, 266);
            this.EmailTxtBox.Multiline = true;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(194, 47);
            this.EmailTxtBox.TabIndex = 19;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(38, 350);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.ReadOnly = true;
            this.PasswordTxtBox.Size = new System.Drawing.Size(218, 28);
            this.PasswordTxtBox.TabIndex = 18;
            this.PasswordTxtBox.TabStop = false;
            this.PasswordTxtBox.Text = "Номер телефона";
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxtBox.Location = new System.Drawing.Point(40, 266);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.ReadOnly = true;
            this.LoginTxtBox.Size = new System.Drawing.Size(87, 28);
            this.LoginTxtBox.TabIndex = 17;
            this.LoginTxtBox.TabStop = false;
            this.LoginTxtBox.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(39, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 27);
            this.textBox1.TabIndex = 22;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Введите следующие данные:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(39, 430);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(178, 28);
            this.textBox3.TabIndex = 23;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Страна";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(39, 516);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(176, 28);
            this.textBox5.TabIndex = 25;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Город";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(261, 436);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(194, 21);
            this.CountryComboBox.TabIndex = 26;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(261, 522);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(194, 21);
            this.CityComboBox.TabIndex = 27;
            // 
            // PeoplePicture
            // 
            this.PeoplePicture.Image = global::WindowsFormsApp1.Properties.Resources.add_user;
            this.PeoplePicture.Location = new System.Drawing.Point(12, 12);
            this.PeoplePicture.Name = "PeoplePicture";
            this.PeoplePicture.Size = new System.Drawing.Size(161, 134);
            this.PeoplePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PeoplePicture.TabIndex = 4;
            this.PeoplePicture.TabStop = false;
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
            // sign_up_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 635);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.PeoplePicture);
            this.Controls.Add(this.TelephoneNumberTextBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.Authorisation_panel);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Name = "sign_up_2";
            this.Text = "sign_up_2";
            this.Authorisation_panel.ResumeLayout(false);
            this.Authorisation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeoplePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartHousePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PeoplePicture;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Panel Authorisation_panel;
        private System.Windows.Forms.PictureBox SmartHousePicture;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox TelephoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.ComboBox CityComboBox;
    }
}