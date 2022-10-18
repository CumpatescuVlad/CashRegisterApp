using CashRegisterApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace CashRegisterAppUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            GenerateRecipt recipt = new GenerateRecipt();
            CacheData cache = new CacheData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationWindow());
            Directory.CreateDirectory(cache.CashRegisterDirectory);
            Directory.CreateDirectory($@"{cache.CashRegisterDirectory}\Cache");
            recipt.UpperSideRecipt();
            Application.Run(new CashRegisterAppUI());

        }
    }
}
