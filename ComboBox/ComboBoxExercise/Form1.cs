using ComboBoxExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Boy")
            {
                label1.Text = "Boy";
                pictureBox1.Image = Resources.Boy;
            }
       else if (comboBox1.Text == "Girl")
            {
                label1.Text = "Girl";
                pictureBox1.Image = Resources.Girl;
            }
       else if (comboBox1.Text == "Book")
            {
                label1.Text = "Book";
                pictureBox1.Image = Resources.Book;
            }
       else if (comboBox1.Text == "Pen")
            {
                label1.Text = "Pen";
                pictureBox1.Image = Resources.Pen;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }
    }
}
