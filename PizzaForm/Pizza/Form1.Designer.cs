namespace Pizza
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lbSize = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.lbCrust = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkBoxOlives = new System.Windows.Forms.CheckBox();
            this.chkBoxOnion = new System.Windows.Forms.CheckBox();
            this.chkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.lbWhToEat = new System.Windows.Forms.Label();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(396, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 147);
            this.label1.TabIndex = 11;
            this.label1.Text = "Make Your Pizza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLarge);
            this.panel1.Controls.Add(this.rbMedium);
            this.panel1.Controls.Add(this.rbSmall);
            this.panel1.Location = new System.Drawing.Point(112, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 138);
            this.panel1.TabIndex = 12;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(36, 94);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rgLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(36, 54);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Meduim";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(36, 14);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(115, 136);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(42, 20);
            this.lbSize.TabIndex = 13;
            this.lbSize.Text = "Size";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbThink);
            this.panel2.Controls.Add(this.rbThin);
            this.panel2.Location = new System.Drawing.Point(112, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 120);
            this.panel2.TabIndex = 14;
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(36, 74);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(94, 20);
            this.rbThink.TabIndex = 1;
            this.rbThink.TabStop = true;
            this.rbThink.Tag = "10";
            this.rbThink.Text = "Thick Crust";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(36, 34);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(87, 20);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(115, 356);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(91, 20);
            this.lbCrust.TabIndex = 15;
            this.lbCrust.Text = "Crust Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkBoxGreenPeppers);
            this.panel3.Controls.Add(this.chkBoxOlives);
            this.panel3.Controls.Add(this.chkBoxOnion);
            this.panel3.Controls.Add(this.chkBoxTomatoes);
            this.panel3.Controls.Add(this.chkBoxMushrooms);
            this.panel3.Controls.Add(this.chkBoxExtraCheese);
            this.panel3.Location = new System.Drawing.Point(512, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 138);
            this.panel3.TabIndex = 16;
            // 
            // chkBoxGreenPeppers
            // 
            this.chkBoxGreenPeppers.AutoSize = true;
            this.chkBoxGreenPeppers.Location = new System.Drawing.Point(158, 90);
            this.chkBoxGreenPeppers.Name = "chkBoxGreenPeppers";
            this.chkBoxGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkBoxGreenPeppers.TabIndex = 5;
            this.chkBoxGreenPeppers.Tag = "5";
            this.chkBoxGreenPeppers.Text = "Green Peppers";
            this.chkBoxGreenPeppers.UseVisualStyleBackColor = true;
            this.chkBoxGreenPeppers.CheckedChanged += new System.EventHandler(this.chkBoxGreenPeppers_CheckedChanged);
            // 
            // chkBoxOlives
            // 
            this.chkBoxOlives.AutoSize = true;
            this.chkBoxOlives.Location = new System.Drawing.Point(158, 52);
            this.chkBoxOlives.Name = "chkBoxOlives";
            this.chkBoxOlives.Size = new System.Drawing.Size(67, 20);
            this.chkBoxOlives.TabIndex = 4;
            this.chkBoxOlives.Tag = "5";
            this.chkBoxOlives.Text = "Olives";
            this.chkBoxOlives.UseVisualStyleBackColor = true;
            this.chkBoxOlives.CheckedChanged += new System.EventHandler(this.chkBoxOlives_CheckedChanged);
            // 
            // chkBoxOnion
            // 
            this.chkBoxOnion.AutoSize = true;
            this.chkBoxOnion.Location = new System.Drawing.Point(158, 14);
            this.chkBoxOnion.Name = "chkBoxOnion";
            this.chkBoxOnion.Size = new System.Drawing.Size(64, 20);
            this.chkBoxOnion.TabIndex = 3;
            this.chkBoxOnion.Tag = "5";
            this.chkBoxOnion.Text = "Onion";
            this.chkBoxOnion.UseVisualStyleBackColor = true;
            this.chkBoxOnion.CheckedChanged += new System.EventHandler(this.chkBoxOnion_CheckedChanged);
            // 
            // chkBoxTomatoes
            // 
            this.chkBoxTomatoes.AutoSize = true;
            this.chkBoxTomatoes.Location = new System.Drawing.Point(27, 90);
            this.chkBoxTomatoes.Name = "chkBoxTomatoes";
            this.chkBoxTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkBoxTomatoes.TabIndex = 2;
            this.chkBoxTomatoes.Tag = "5";
            this.chkBoxTomatoes.Text = "Tomatoes";
            this.chkBoxTomatoes.UseVisualStyleBackColor = true;
            this.chkBoxTomatoes.CheckedChanged += new System.EventHandler(this.chkBoxTomatoes_CheckedChanged);
            // 
            // chkBoxMushrooms
            // 
            this.chkBoxMushrooms.AutoSize = true;
            this.chkBoxMushrooms.Location = new System.Drawing.Point(27, 52);
            this.chkBoxMushrooms.Name = "chkBoxMushrooms";
            this.chkBoxMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkBoxMushrooms.TabIndex = 1;
            this.chkBoxMushrooms.Tag = "5";
            this.chkBoxMushrooms.Text = "Mushrooms";
            this.chkBoxMushrooms.UseVisualStyleBackColor = true;
            this.chkBoxMushrooms.CheckedChanged += new System.EventHandler(this.chkBoxMushrooms_CheckedChanged);
            // 
            // chkBoxExtraCheese
            // 
            this.chkBoxExtraCheese.AutoSize = true;
            this.chkBoxExtraCheese.Location = new System.Drawing.Point(27, 14);
            this.chkBoxExtraCheese.Name = "chkBoxExtraCheese";
            this.chkBoxExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.chkBoxExtraCheese.TabIndex = 0;
            this.chkBoxExtraCheese.Tag = "5";
            this.chkBoxExtraCheese.Text = "Extra Cheese";
            this.chkBoxExtraCheese.UseVisualStyleBackColor = true;
            this.chkBoxExtraCheese.CheckedChanged += new System.EventHandler(this.chkBoxExtraCheese_CheckedChanged);
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(511, 136);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(77, 20);
            this.lbToppings.TabIndex = 17;
            this.lbToppings.Text = "Toppings";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbTakeOut);
            this.panel4.Controls.Add(this.rbEatIn);
            this.panel4.Location = new System.Drawing.Point(512, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 81);
            this.panel4.TabIndex = 18;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(158, 34);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(15, 34);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // lbWhToEat
            // 
            this.lbWhToEat.AutoSize = true;
            this.lbWhToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhToEat.Location = new System.Drawing.Point(511, 355);
            this.lbWhToEat.Name = "lbWhToEat";
            this.lbWhToEat.Size = new System.Drawing.Size(112, 20);
            this.lbWhToEat.TabIndex = 19;
            this.lbWhToEat.Text = "Where To Eat";
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Location = new System.Drawing.Point(512, 465);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(91, 33);
            this.btOrderPizza.TabIndex = 20;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // btResetForm
            // 
            this.btResetForm.Location = new System.Drawing.Point(711, 465);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(91, 33);
            this.btResetForm.TabIndex = 21;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = true;
            this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.Location = new System.Drawing.Point(1009, 139);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(101, 16);
            this.lbOrderSummary.TabIndex = 22;
            this.lbOrderSummary.Text = "Order Summary";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1012, 178);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 20);
            this.label.TabIndex = 23;
            this.label.Text = "Size:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(1055, 182);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 16);
            this.lblSize.TabIndex = 24;
            this.lblSize.Text = "Medium";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(1118, 465);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 46);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1018, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total Price:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(1118, 369);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(40, 16);
            this.lblWhereToEat.TabIndex = 27;
            this.lblWhereToEat.Text = "Eat In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1015, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Toppings:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1017, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Where To Eat:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(1118, 300);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(66, 16);
            this.lblCrustType.TabIndex = 30;
            this.lblCrustType.Text = "Thin Crust";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1016, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Crust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.AllowDrop = true;
            this.lblToppings.AutoSize = true;
            this.lblToppings.Enabled = false;
            this.lblToppings.Location = new System.Drawing.Point(1098, 254);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(81, 20);
            this.lblToppings.TabIndex = 33;
            this.lblToppings.Text = "No Toppings";
            this.lblToppings.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 545);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbOrderSummary);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.lbWhToEat);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbCrust);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "This is the intial title";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Label lbCrust;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkBoxGreenPeppers;
        private System.Windows.Forms.CheckBox chkBoxOlives;
        private System.Windows.Forms.CheckBox chkBoxOnion;
        private System.Windows.Forms.CheckBox chkBoxTomatoes;
        private System.Windows.Forms.CheckBox chkBoxMushrooms;
        private System.Windows.Forms.CheckBox chkBoxExtraCheese;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label lbWhToEat;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblToppings;
    }
}

