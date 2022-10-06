namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.oilPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.litr = new System.Windows.Forms.Label();
            this.gasoline = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastPriceOil = new System.Windows.Forms.Label();
            this.lastPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLitr = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cocaCola = new System.Windows.Forms.TextBox();
            this.frenchFries = new System.Windows.Forms.TextBox();
            this.hamburger = new System.Windows.Forms.TextBox();
            this.hotDog = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.miniCoffee = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.oilPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.litr);
            this.panel1.Controls.Add(this.gasoline);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.money);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxLitr);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 401);
            this.panel1.TabIndex = 0;
            // 
            // oilPrice
            // 
            this.oilPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oilPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oilPrice.Location = new System.Drawing.Point(116, 112);
            this.oilPrice.Name = "oilPrice";
            this.oilPrice.Size = new System.Drawing.Size(165, 25);
            this.oilPrice.TabIndex = 24;
            this.oilPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(283, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Azn.";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 29);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // litr
            // 
            this.litr.AutoSize = true;
            this.litr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.litr.Location = new System.Drawing.Point(283, 176);
            this.litr.Name = "litr";
            this.litr.Size = new System.Drawing.Size(21, 21);
            this.litr.TabIndex = 18;
            this.litr.Text = "L.";
            // 
            // gasoline
            // 
            this.gasoline.AutoSize = true;
            this.gasoline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gasoline.Location = new System.Drawing.Point(17, 56);
            this.gasoline.Name = "gasoline";
            this.gasoline.Size = new System.Drawing.Size(70, 21);
            this.gasoline.TabIndex = 3;
            this.gasoline.Text = "Gasoline";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(17, 112);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 21);
            this.price.TabIndex = 15;
            this.price.Text = "Price";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.money.Location = new System.Drawing.Point(282, 233);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(35, 19);
            this.money.TabIndex = 14;
            this.money.Text = "Azn.";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(17, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 80);
            this.panel3.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(4, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Amount";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(4, 1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Litr";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lastPriceOil);
            this.panel2.Controls.Add(this.lastPrice);
            this.panel2.Location = new System.Drawing.Point(17, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 108);
            this.panel2.TabIndex = 1;
            // 
            // lastPriceOil
            // 
            this.lastPriceOil.AutoSize = true;
            this.lastPriceOil.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastPriceOil.Location = new System.Drawing.Point(104, 49);
            this.lastPriceOil.Name = "lastPriceOil";
            this.lastPriceOil.Size = new System.Drawing.Size(0, 37);
            this.lastPriceOil.TabIndex = 17;
            // 
            // lastPrice
            // 
            this.lastPrice.AutoSize = true;
            this.lastPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastPrice.Location = new System.Drawing.Point(0, -1);
            this.lastPrice.Name = "lastPrice";
            this.lastPrice.Size = new System.Drawing.Size(78, 23);
            this.lastPrice.TabIndex = 16;
            this.lastPrice.Text = "Last Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Auto Gas Station";
            // 
            // textBoxLitr
            // 
            this.textBoxLitr.Location = new System.Drawing.Point(181, 171);
            this.textBoxLitr.Name = "textBoxLitr";
            this.textBoxLitr.Size = new System.Drawing.Size(100, 23);
            this.textBoxLitr.TabIndex = 12;
            this.textBoxLitr.TextChanged += new System.EventHandler(this.textBoxLitr_TextChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(181, 226);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmount.TabIndex = 9;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cocaCola);
            this.panel4.Controls.Add(this.frenchFries);
            this.panel4.Controls.Add(this.hamburger);
            this.panel4.Controls.Add(this.hotDog);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.miniCoffee);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(466, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 401);
            this.panel4.TabIndex = 3;
            // 
            // cocaCola
            // 
            this.cocaCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cocaCola.Location = new System.Drawing.Point(260, 210);
            this.cocaCola.Name = "cocaCola";
            this.cocaCola.Size = new System.Drawing.Size(39, 23);
            this.cocaCola.TabIndex = 28;
            this.cocaCola.TextChanged += new System.EventHandler(this.cocaCola_TextChanged);
            // 
            // frenchFries
            // 
            this.frenchFries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frenchFries.Location = new System.Drawing.Point(260, 164);
            this.frenchFries.Name = "frenchFries";
            this.frenchFries.Size = new System.Drawing.Size(39, 23);
            this.frenchFries.TabIndex = 27;
            this.frenchFries.TextChanged += new System.EventHandler(this.frenchFries_TextChanged);
            // 
            // hamburger
            // 
            this.hamburger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hamburger.Location = new System.Drawing.Point(260, 116);
            this.hamburger.Name = "hamburger";
            this.hamburger.Size = new System.Drawing.Size(39, 23);
            this.hamburger.TabIndex = 26;
            this.hamburger.TextChanged += new System.EventHandler(this.hamburger_TextChanged);
            // 
            // hotDog
            // 
            this.hotDog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotDog.Location = new System.Drawing.Point(260, 64);
            this.hotDog.Name = "hotDog";
            this.hotDog.Size = new System.Drawing.Size(39, 23);
            this.hotDog.TabIndex = 25;
            this.hotDog.TextChanged += new System.EventHandler(this.hotDog_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(160, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "4.40";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(160, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "7.20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(160, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "5.40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(160, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "4.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(252, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox4.Location = new System.Drawing.Point(11, 212);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 23);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Coca-Cola";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(11, 166);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 23);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "French Fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(11, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 23);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Hamburger";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(11, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 23);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Hot-Dog";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // miniCoffee
            // 
            this.miniCoffee.AutoSize = true;
            this.miniCoffee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.miniCoffee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miniCoffee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miniCoffee.Location = new System.Drawing.Point(0, 0);
            this.miniCoffee.Name = "miniCoffee";
            this.miniCoffee.Size = new System.Drawing.Size(81, 21);
            this.miniCoffee.TabIndex = 14;
            this.miniCoffee.Text = "Mini Coffee";
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(16, 275);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 108);
            this.panel6.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(99, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 37);
            this.label11.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Price";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(12, 494);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 149);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("PMingLiU-ExtB", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(123, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 19;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(317, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 45);
            this.label12.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "All to pay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Best Oil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label gasoline;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private TextBox textBoxAmount;
        private TextBox textBoxLitr;
        private Label litr;
        private Label money;
        private Label label1;
        private Label price;
        private Label lastPrice;
        private Label lastPriceOil;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label miniCoffee;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox cocaCola;
        private TextBox frenchFries;
        private TextBox hamburger;
        private TextBox hotDog;
        private Label label11;
        private Button button1;
        private Label label12;
        private Label label10;
        private Label oilPrice;
    }
}