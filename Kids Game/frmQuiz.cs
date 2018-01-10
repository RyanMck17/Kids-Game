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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitQuiz_Click(object sender, EventArgs e)
        {
            //Dialog box to check if you have clicked in error or not
            DialogResult result =
                MessageBox.Show("Are you sure you want to exit the Quiz?", "Exit Quiz",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
            else
            {
                //Do nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                //Dialog box to check if you have clicked in error or not
                DialogResult result =
                    MessageBox.Show("Are you sure you want to exit the Quiz?", "Exit Quiz",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    Application.Exit();
                }
                else
                {
                    //Do nothing
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
     


        }

        private void btnStartQuiz_Click_1(object sender, EventArgs e)
        {
            if (cboThemes.SelectedItem != null)
            {
                Globals.selectedTheme = cboThemes.SelectedItem.ToString();
                this.Hide();
                Football qFrm = new Football();
                qFrm.Show();


            }
            else
            {
                lblError.Text = "first select a quiz theme!";
            }

        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.Show();
        }

        private void frmQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)

        {

            //exit application when form is closed

            Application.Exit();

        }
    }
}
