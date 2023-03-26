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
    public partial class RegistrationForRoleDevices : Form
    {
        public RegistrationForRoleDevices()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            AnotherRoleForm frm = new AnotherRoleForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
