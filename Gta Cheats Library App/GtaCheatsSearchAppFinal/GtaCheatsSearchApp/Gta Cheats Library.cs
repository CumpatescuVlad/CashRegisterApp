using System;
using System.Windows.Forms;

namespace GtaCheatsSearchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            searchAndDisplayCheat1.Hide();
            viceCityCheats1.Hide();
            gtaSanAndreas1.Hide();
        }

        private void searchAndDisplayCheat1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchAndDisplayCheat1.Show();
            searchAndDisplayCheat1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            viceCityCheats1.Show();
            viceCityCheats1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gtaSanAndreas1.Show();
            gtaSanAndreas1.BringToFront();

        }

    }
}
