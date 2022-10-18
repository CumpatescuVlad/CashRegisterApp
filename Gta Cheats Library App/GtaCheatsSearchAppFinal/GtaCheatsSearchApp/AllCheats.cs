using System;
using System.Windows.Forms;

namespace GtaCheatsSearchApp
{
    public partial class AllCheats : Form
    {
        public AllCheats()
        {
            InitializeComponent();
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }
        public string DisplayAllCheats(string allCheats)
        {
            return richTextBox1.Text = allCheats;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
