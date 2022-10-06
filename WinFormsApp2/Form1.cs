using System.Data;
using System.Numerics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<double> oil_price = new()
            {
                1,
                2,
                2.30
            };
        private List<string> oil = new List<string>()
            {
                ("AI-93"),
                ("AI-95"),
                ("AI-98")
            };

        private int mainIndex = -1;

        private double commonOilPrice = 0;

        private double foodsAmount = 0;
        private double priceHotDog = 0;
        private double priceHam = 0;
        private double priceFri = 0;
        private double priceCo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(oil.ToArray());

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxLitr.Enabled = false;
            textBoxAmount.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            hotDog.Enabled = false;
            hamburger.Enabled = false;
            frenchFries.Enabled = false;
            cocaCola.Enabled = false;
        }


        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                oilPrice.Text = oil_price[comboBox1.SelectedIndex].ToString();
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            mainIndex = comboBox1.SelectedIndex;

            if (textBoxLitr.Text != String.Empty || textBoxAmount.Text != String.Empty)
            {
                textBoxLitr.Text = String.Empty;
                textBoxAmount.Text = String.Empty;
                commonOilPrice = 0;
            }
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBoxLitr.Enabled = true;

            textBoxAmount.Enabled = false;
            textBoxAmount.Text = String.Empty;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBoxLitr.Enabled = false;
            textBoxLitr.Text = String.Empty;
            textBoxAmount.Enabled = true;
        }

        private void textBoxLitr_TextChanged(object sender, EventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (tb is not null)
                tb.MaxLength = 6;


            if (double.TryParse(tb?.Text, out double d) || tb?.Text == String.Empty)
            {
                if (mainIndex != -1)
                {
                    double price = d * oil_price[mainIndex];
                    commonOilPrice = price;
                    lastPriceOil.Text = ((float)price).ToString() + " Azn.";
                }
            }
            else
            {
                MessageBox.Show("You can't add there letter...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb is not null)
                    tb.Text = String.Empty;
            }

            if (tb?.Text.Length == 0)
            {
                lastPriceOil.Text = String.Empty;
                commonOilPrice = 0;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (tb is not null)
                tb.MaxLength = 5;


            if (double.TryParse(tb?.Text, out double d) || tb?.Text == String.Empty)
            {
                double litr = d / oil_price[mainIndex];
                commonOilPrice = d;
                lastPriceOil.Text = litr.ToString() + " l.";
            }
            else
            {
                MessageBox.Show("You can't add there letter...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb is not null)
                    tb.Text = String.Empty;
            }

            if (tb?.Text.Length == 0)
            {
                lastPriceOil.Text = String.Empty;
                commonOilPrice = 0;
            }
        }

        //Hot-Dog
        private void hotDog_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (tb is not null)
                tb.MaxLength = 3;



            if (uint.TryParse(tb?.Text, out uint d) || tb?.Text == String.Empty)
            {
                foodsAmount -= (float)priceHotDog;
                priceHotDog = d * 4;
                label11.Text = ((float)(foodsAmount += priceHotDog)).ToString() + " Azn.";
            }
            else
            {
                MessageBox.Show("You can't add there letter...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb is not null)
                    tb.Text = String.Empty;
            }

            if (tb?.Text.Length == 0)
                label11.Text = String.Empty;
        }

        //Hamburger
        private void hamburger_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (tb is not null)
                tb.MaxLength = 3;


            if (uint.TryParse(tb?.Text, out uint d) || tb?.Text == String.Empty)
            {
                foodsAmount -= priceHam;
                priceHam = d * 5.4;
                label11.Text = ((float)(foodsAmount += priceHam)).ToString() + " Azn.";
            }
            else
            {
                MessageBox.Show("You can't add there letter...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb is not null)
                    tb.Text = String.Empty;
            }

            if (tb?.Text.Length == 0)
                label11.Text = String.Empty;
        }

        //French Fries

        private void frenchFries_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (tb is not null)
                tb.MaxLength = 3;


            if (uint.TryParse(tb?.Text, out uint d) || tb?.Text == String.Empty)
            {
                foodsAmount -= priceFri;
                priceFri = d * 7.2;
                label11.Text = ((float)(foodsAmount += priceFri)).ToString() + " Azn.";
            }
            else
            {
                MessageBox.Show("You can't add there letter...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb is not null)
                    tb.Text = String.Empty;
            }

            if (tb?.Text.Length == 0)
                label11.Text = String.Empty;
        }

        //Coca-cola

        private void cocaCola_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;

            if (tb is not null)
                tb.MaxLength = 3;


            if (uint.TryParse(tb?.Text, out uint d) || tb?.Text == String.Empty)
            {
                foodsAmount -= priceCo;
                priceCo = d * 4.4;
                label11.Text = ((float)(foodsAmount += priceCo)).ToString() + " Azn.";
            }
            else
            {
                MessageBox.Show("You can't add there letter...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb is not null)
                    tb.Text = String.Empty;
            }

            if (tb?.Text.Length == 0)
                label11.Text = String.Empty;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                hotDog.Enabled = true;
            else
            {
                hotDog.Enabled = false;
                if (hotDog.Text != String.Empty)
                {
                    hotDog.Text = String.Empty;
                    foodsAmount -= priceHotDog;
                    priceHotDog = 0;
                    label11.Text = ((float)foodsAmount).ToString() + " Azn";
                }
            }

            if (checkBox2.Checked)
                hamburger.Enabled = true;
            else
            {
                hamburger.Enabled = false;
                if (hamburger.Text != String.Empty)
                {
                    hamburger.Text = String.Empty;
                    foodsAmount -= priceHam;
                    priceHam = 0;
                    label11.Text = ((float)foodsAmount).ToString() + " Azn";
                }
            }


            if (checkBox3.Checked)
                frenchFries.Enabled = true;
            else
            {
                frenchFries.Enabled = false;
                if (frenchFries.Text != String.Empty)
                {
                    frenchFries.Text = String.Empty;
                    foodsAmount -= priceFri;
                    priceFri = 0;
                    label11.Text = ((float)foodsAmount).ToString() + " Azn";

                }
            }

            if (checkBox4.Checked)
                cocaCola.Enabled = true;
            else
            {
                cocaCola.Enabled = false;
                if (cocaCola.Text != String.Empty)
                {
                    cocaCola.Text = String.Empty;
                    foodsAmount -= priceCo;
                    priceCo = 0;
                    label11.Text = ((float)foodsAmount).ToString() + " Azn";
                }
            }

            if (hotDog.Text == String.Empty && frenchFries.Text == String.Empty && cocaCola.Text == String.Empty && hamburger.Text == String.Empty)
            {
                foodsAmount = 0;
                label11.Text = foodsAmount.ToString() + " Azn.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = ((float)(commonOilPrice + foodsAmount)).ToString() + " Azn.";
        }
    }
}