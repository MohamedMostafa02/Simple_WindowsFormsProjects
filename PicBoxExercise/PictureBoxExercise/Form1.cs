using PictureBoxExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            //lblTitle.Text = "Boy";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            pictureBox1.Image = Resources.Boy;
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
           // lblTitle.Text = "Girl";
           lblTitle.Text = ((RadioButton)sender).Tag.ToString(); 
            pictureBox1.Image = Resources.Girl;
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            //lblTitle.Text = "Book";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            pictureBox1.Image = Resources.Book;
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            //lblTitle.Text = "Pen";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
            pictureBox1.Image = Resources.Pen;
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    lblTitle.Text = "Boy";
        //    pictureBox1.Image = Resources.Boy;
        //}
    }
}
