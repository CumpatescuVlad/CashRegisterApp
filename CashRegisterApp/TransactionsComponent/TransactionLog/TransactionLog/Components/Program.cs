using System;
using System.Windows.Forms;
using System.IO;
using Transactions;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataSource data = new DataSource();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SearchTab());
            File.WriteAllText(data.TransactionsAmountPath, " ");
            


        }
    }
}
