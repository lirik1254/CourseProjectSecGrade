using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistrationForRole : Form
    {
        public RegistrationForRole()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            RegistrationForRoleDevices frm = new RegistrationForRoleDevices();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
