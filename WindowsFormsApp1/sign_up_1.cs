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
    public partial class sign_up_1 : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up_1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            PasswordEntTxtBox.PasswordChar = '*';
            UnHidePictureBox.Visible = false;
            PasswordEntTxtBox.MaxLength = 50;
            LogEntTxtBox.MaxLength = 50;
        }

        private void UnHidePictureBox_Click(object sender, EventArgs e)
        {
            PasswordEntTxtBox.UseSystemPasswordChar = false;
            UnHidePictureBox.Visible = false;
            HidePictureBox.Visible = true;
        }

        private void HidePictureBox_Click(object sender, EventArgs e)
        {
            PasswordEntTxtBox.UseSystemPasswordChar = true;
            UnHidePictureBox.Visible = true;
            HidePictureBox.Visible = false;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            
            var login = LogEntTxtBox.Text;
            var password = PasswordEntTxtBox.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            dataBase.closeConnection();
        }


        private Boolean checkUser()
        {
            var loginUser = LogEntTxtBox.Text;
            var passUser = PasswordEntTxtBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and " +
                $"password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return false;
            }
            else
                return true;
        }
    }
}
