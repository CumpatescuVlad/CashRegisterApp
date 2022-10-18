using System;
using System.Windows.Forms;

namespace CashRegisterAppUI
{
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
