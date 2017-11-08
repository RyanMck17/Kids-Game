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

            // Second Question 
            //Question
            qaHistoryArray[1, 0] = "what was the date that Hitler Died";
            //multiple choice
            qaHistoryArray[1, 1] = "30 Apr 1945";
            qaHistoryArray[1, 2] = "25 Apr 1945";
            qaHistoryArray[1, 3] = "10 Apr 1945";
            qaHistoryArray[1, 4] = "1 Apr 1945";
            //picture
            qaHistoryArray[0, 5] = "hitler";
            //answer
            qaHistoryArray[0, 6] = "30 Apr 1945";

            // third question 
            //Question
            qaHistoryArray[2, 0] = "when was the company 'Apple' founded ";
            //multiple choice
            qaHistoryArray[2, 1] = "30 Apr 1945";
            qaHistoryArray[2, 2] = "june 1, 1976";
            qaHistoryArray[2, 3] = "April 1, 1976";
            qaHistoryArray[2, 4] = "1 Apr 1945";
            //picture
            qaHistoryArray[0, 5] = "apple";
            //answer
            qaHistoryArray[0, 6] = "April 1, 1976";

            // forth question 
            //Question
            qaHistoryArray[3, 0] = "when was the battle of the somme";
            //multiple choice
            qaHistoryArray[3, 1] = "1 July 1916";
            qaHistoryArray[3, 2] = "june 1, 1976";
            qaHistoryArray[3, 3] = "2 July 1916";
            qaHistoryArray[3, 4] = "7 Apr 1945";
            //picture
            qaHistoryArray[0, 5] = "somme";
            //answer
            qaHistoryArray[0, 6] = "1 July 1916";






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
