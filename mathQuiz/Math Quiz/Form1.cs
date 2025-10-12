using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {

        Random Randomizer = new Random();

        int adnum1;
        int adnum2;

        int minusnum1;
        int minusnum2;

        int multnum1;
        int multnum2;

        int divnum1;
        int divnum2;

        int clock;


        private bool CheckAnswer()
        {

            if (((((adnum1 + adnum2) == Sum.Value)
               && (minusnum1 - minusnum2 == Substraction.Value))
               && (multnum1 * multnum2 == Multiplication.Value))
               && (divnum1 / divnum2 == Division.Value))

                return true;

            else
                return false;


            
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void StartQuiz()
        {
            adnum1 = Randomizer.Next(51);
            adnum2 = Randomizer.Next(51);

            lbPlusLeft.Text = adnum1.ToString();
            lbPlusRight.Text = adnum2.ToString();

            Sum.Value = 0;

            minusnum1 = Randomizer.Next(1, 101);
            minusnum2 = Randomizer.Next(1, minusnum1);

            lbMinusLeft.Text = minusnum1.ToString();
            lbMinusRight.Text = minusnum2.ToString();

            Substraction.Value = 0;

            multnum1 = Randomizer.Next(2, 11);
            multnum2 = Randomizer.Next(2, 11);

            lbMultLeft.Text = multnum1.ToString();
            lbMultRight.Text = multnum2.ToString();

            Multiplication.Value = 0;

            divnum2 = Randomizer.Next(2, 11);
            int temp = Randomizer.Next(2, 11);
            divnum1 = divnum2 * temp;

            lbDivLeft.Text = divnum1.ToString();
            lbDivRight.Text = divnum2.ToString();

            Division.Value = 0;


            clock = 30;

            lbTimer.Text = "30 Seconds";
            timer1.Start();
        }
        private void btStartQuiz_Click(object sender, EventArgs e)
        {
            StartQuiz();
            btStartQuiz.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(clock > 0)
            {
                //Display the new time left
                //by updating the time left label

                clock = clock - 1;
                lbTimer.Text = clock + "Seconds";
            }
            else
            {
                //if the user run out of time, stop the timer, show
                // a MessageBox, and fill in the answers.

                timer1.Stop();
                lbTimer.Text = "Time's up!";
                if (CheckAnswer())
                {
                    MessageBox.Show("You Have Passed All The Questions", "Congratulations!");
                    btStartQuiz.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You didn't finish in time.", "Sorry!");
                    Sum.Value = adnum1 + adnum2;
                    Substraction.Value = minusnum1 - minusnum2;
                    Multiplication.Value = multnum1 * multnum2;
                    Division.Value = divnum1 / divnum2;
                    btStartQuiz.Enabled = true;
                }
            }
        }
    }
}
