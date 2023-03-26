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
    public partial class log_in : Form
    {

        DataBase database = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            PasswordEntTxtBox.PasswordChar = '*';
            UnHidePictureBox.Visible = false;
            PasswordEntTxtBox.MaxLength = 50;
            LogEntTxtBox.MaxLength = 50;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var loginUser = LogEntTxtBox.Text;
            var passUser = PasswordEntTxtBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainActivity = new MainMenu();
                this.Hide();
                mainActivity.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NoAccauntLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up_1 frm_sign = new sign_up_1();
            frm_sign.Show();
            this.Hide();
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
    }
}
