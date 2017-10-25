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
    public partial class Football : Form
    {
        public Football()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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
    }
}
