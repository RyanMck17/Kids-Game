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
        public static string[,] qaHistoryArray = new string[11, 7];
        public static string[,] qaITArray = new string[11, 7];
        public static string[,] qaArray = new string[11, 7];
        private static int historyCounter = 0;
        private static int itCounter = 0;
        private static int sportsCounter = 0;
        private string userChoice = "";
        private string pictureName = "";
        private string answer = "";

    
        

        public Football()
        {
            InitializeComponent();
        }

        private string[,] BuildHistoryArray()
        {

            //using an array to store questions 
            // First Question
            //Question 
            qaHistoryArray[0, 0] = "In Greek mythology who was believed to be the god of the sea and was known to" +
                "carry a 3-sided fork (trident) which could use to stir up storm or eathquake";
            //mulitiple choices
            qaHistoryArray[0, 1] = "Zeus";
            qaHistoryArray[0, 2] = "Hades";
            qaHistoryArray[0, 3] = "Poseidon";
            qaHistoryArray[0, 4] = "Apollo";
            //picture
            qaHistoryArray[0, 5] = "Poseidon";
            //answer
            qaHistoryArray[0, 6] = "poseidon";






            return qaHistoryArray;
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

        private void Football_Load(object sender, EventArgs e)
        {

        }
    }
}
