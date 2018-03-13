using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kids_Game
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked==true)
            {
                pwdtxtbox.PasswordChar = '\0';
            }
            else
            {
                pwdtxtbox.PasswordChar = '*';
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // dialog box to check if you have clicked in error or not
            DialogResult result =
                MessageBox.Show("Are you sure you want to exit the quiz?", "Exit Quiz",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
            else
            {
                // Do nothing
            }
        }

    private void button2_Click(object sender, EventArgs e)
{

}
    }
}