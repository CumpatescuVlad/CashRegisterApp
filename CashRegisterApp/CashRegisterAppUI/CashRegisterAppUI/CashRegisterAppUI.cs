using CashRegisterApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace CashRegisterAppUI
{
    public partial class CashRegisterAppUI : Form
    {
        #region Objects

        ReadProductData data = new ReadProductData();

        InsertTransaction insert = new InsertTransaction();

        CacheData cache = new CacheData();

        GenerateRecipt recipt = new GenerateRecipt();


        #endregion



        public CashRegisterAppUI()
        {
            InitializeComponent();

        }

        #region Keypad

        public void Write(int number) => textBox1.Text += number;
        private void button1_Click(object sender, EventArgs e)
        {
            Write(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Write(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Write(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Write(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Write(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Write(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Write(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Write(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Write(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Write(0);

        }
        #endregion


        private void button11_Click(object sender, EventArgs e)
        {
            //Plus Button

            cache.NumberOfArticles++;

            cache.StoreData(cache.NumberOfArticlesPath, $"{cache.NumberOfArticles}");

            string numberOfProducts = textBox1.Text.Substring(0,1);

            string barcode = textBox1.Text.Substring(2,10);

            cache.StoreData(cache.NumberOfProducts, numberOfProducts);

            cache.StoreData(cache.Barcode, barcode);

            data.AddProducts();

            AddedProducts.Text = File.ReadAllText(cache.ProductList);

            totalBox.Text = $"TOTAL:{File.ReadAllText(cache.SubTotalPath)}";

            textBox1.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Total Button

            recipt.LowerSideRecipt();
            insert.PushTransactionData();
            MessageBox.Show($"{File.ReadAllText(cache.ReciptPath)}");
            cache.DisposeData(cache.NumberOfProducts);
            cache.DisposeData(cache.Barcode);
            cache.DisposeData(cache.NumberOfArticlesPath);
            cache.DisposeData(cache.SubTotalPath);
            cache.DisposeData(cache.ProductList);
            Directory.Delete($@"{cache.CashRegisterDirectory}\Cache");
            Environment.Exit(0);
        }

       

        private void AddedProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            textBox1.Text += "X";

        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length-1,1);
        }
    }
}
