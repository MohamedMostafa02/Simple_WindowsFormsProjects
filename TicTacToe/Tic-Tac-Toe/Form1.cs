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
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        

        enum enPlayer
        {
            Player1,
            player2
        }

        enum enWinner
        {
            Player1,
            player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckValues(Button btn1,Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                 


                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }


            }

            GameStatus.GameOver = false;
            return false;
        }

        void EndGame()
        {
            lbTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lbWinner.Text = "Player1";
                    break;
                case enWinner.player2:
                    lbWinner.Text = "Player2";
                    break;
                default:
                    lbWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CheckWinner()
        {
            //Check rows
            //Check row1
            if (CheckValues(button1, button2, button3))
                return;
            //check row2
            if (CheckValues(button4, button5, button6))
                return;
            //check row3
            if (CheckValues(button7, button8, button9))
                return;

            //check cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;
            //check col2
            if (CheckValues(button2, button5, button8))
                return;
            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check diagonal

            //check diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check diagonal2
            if (CheckValues(button3, button5, button7))
                return;

        }

        public void ChangeImage(Button btn)
        {
            if(btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.player2;
                        lbTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                    
                }
             
            }
            else
            {
              MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }






        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;

            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw horizental lines
            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            //draw vertical lines

            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button1);
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button8);
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button5);
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button2);
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button4);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button3);
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button6);
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button9);
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(button7);
        //}

        public void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void RestartGame()
        {
            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);
            PlayerTurn = enPlayer.Player1;
            lbTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lbWinner.Text = "In Progress";

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();  
        }
    }
}
