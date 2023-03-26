using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class sign_up_2 : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up_2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //private void button_Create_Click(object sender, EventArgs e)
        //{
        //    var Email = EmailTxtBox.Text;
        //    var Telephone = TelephoneNumberTextBox.Text;
        //    var Country = CountryComboBox.

        //    string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

        //    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

        //    dataBase.openConnection();

        //    if (command.ExecuteNonQuery() == 1)
        //    {
        //        MessageBox.Show("Аккаунт успешно создан!", "Успех!");
        //        log_in frm_login = new log_in();
        //        this.Hide();
        //        frm_login.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Аккаунт не создан!");
        //    }

        //    dataBase.closeConnection();
        //}

    }
}
