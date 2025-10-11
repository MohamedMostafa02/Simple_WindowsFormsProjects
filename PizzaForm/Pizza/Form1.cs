using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {
            //reset Groups
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;

            //reset Size

            rbMedium.Focus();

            //reset Toppings

            chkBoxExtraCheese.Checked = false;
            chkBoxMushrooms.Checked = false;
            chkBoxTomatoes.Checked = false;
            chkBoxOnion.Checked = false;
            chkBoxOlives.Checked = false;
            chkBoxGreenPeppers.Checked = false;

            //reset CrustType
            rbThin.Checked = true;

            //reset where to eat
            rbEatIn.Focus();

            //reset order button
            btOrderPizza.Enabled = true;


            }
        
        void UpdateSize()
        {
            UpdateTotalPrice();

            if(rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if(rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if(rbThin.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThink.Checked) 
            {
                lblCrustType.Text = "Thick Crust";
                return ;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkBoxExtraCheese.Checked)
                sToppings = "Extra Cheese";
            if (chkBoxMushrooms.Checked)
                sToppings += ", Mushrooms";
            if (chkBoxTomatoes.Checked)
                sToppings += ", Tomatoes";
            if (chkBoxOnion.Checked)
                sToppings += ", Onion";
            if (chkBoxOlives.Checked)
                sToppings += ", Olives";
            if (chkBoxGreenPeppers.Checked)
                sToppings += ", Green Peppers";

            if(sToppings.StartsWith(","))
                sToppings = sToppings.Substring(1,sToppings.Length - 1).Trim();

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;

        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
            } 
                
        }
        void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

           else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
           else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float totalPrice = 0;
             if (chkBoxExtraCheese.Checked)
                totalPrice += Convert.ToSingle(chkBoxExtraCheese.Tag);
             if (chkBoxTomatoes.Checked)
                totalPrice += Convert.ToSingle(chkBoxTomatoes.Tag);
             if (chkBoxMushrooms.Checked)
                totalPrice += Convert.ToSingle(chkBoxMushrooms.Tag);
             if (chkBoxOnion.Checked)
                totalPrice += Convert.ToSingle(chkBoxOnion.Tag);
             if (chkBoxOlives.Checked)
                totalPrice += Convert.ToSingle(chkBoxOlives.Tag);
             if (chkBoxGreenPeppers.Checked)
                totalPrice += Convert.ToSingle(chkBoxGreenPeppers.Tag);

            return totalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThink.Checked)
                return Convert.ToSingle(rbThink.Tag);
            else
                return Convert.ToSingle(rbThin.Tag);
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btOrderPizza.Enabled = false;
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
            }
            

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rgLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); 
        }

        private void chkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
          ResetForm();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat(); 
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
    }
}
