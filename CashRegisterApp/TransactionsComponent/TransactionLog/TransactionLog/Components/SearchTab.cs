using System;
using System.IO;
using System.Windows.Forms;
using Transactions;

namespace WindowsFormsApp1
{
    public partial class SearchTab : Form
    {
        readonly Transactions.GetTransactions search = new Transactions.GetTransactions();

        DataSource data = new DataSource();
        public SearchTab()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cif = enterCifbox.Text;

            displayTransactions.Text = $"{search.TransactionLog(cif)}\nTOTAL:{File.ReadAllText(data.TransactionsAmountPath)} Lei";

            data.Dispose(data.TransactionsAmountPath);

        }

        #region ButtonsAndTextboxesMethods
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
