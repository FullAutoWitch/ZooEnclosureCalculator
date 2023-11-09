using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DuckArea duckEnclosure = new DuckArea(true, false, 5, 7, 2, 4, 20);
                PenguinArea penguinEnclosure = new PenguinArea(true, false, 0, 0, 5, 6, 5);
                KiwiArea kiwiEnclosure = new KiwiArea(false, true, 3, 4.5, 5.9, 9.9, 30);
                List<BirdType> ducks = new List<BirdType>();
                List<BirdType> penguins = new List<BirdType>();
                List<BirdType> kiwis = new List<BirdType>();

                int duckCount = Convert.ToInt32(textBox1.Text);

                int penguinCount = Convert.ToInt32(textBox2.Text);

                int kiwiCount = Convert.ToInt32(textBox3.Text);

                double duckArea = duckEnclosure.area() * duckCount;

                double penguinArea = penguinEnclosure.area() * penguinCount;

                double kiwiArea = kiwiEnclosure.area() * kiwiCount;


                double generalArea = 0;
                generalArea = (duckEnclosure.area() * duckCount) + (penguinEnclosure.area() * penguinCount) + (kiwiEnclosure.area() * kiwiCount);

                label1.Text = duckArea.ToString();
                label5.Text = penguinArea.ToString();
                label6.Text = kiwiArea.ToString();
                label7.Text = generalArea.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("FormatError");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
