using CashRegisterAppUI;
using System;
using System.Collections.Generic;
using System.IO;


namespace CashRegisterApp
{
    public class GenerateRecipt
    {
        #region Objects
        List<GenerateRecipt> upperSide = new List<GenerateRecipt>();

        List<GenerateRecipt> lowerSide = new List<GenerateRecipt>();

        Products product = new Products();

        CacheData cache = new CacheData();

        Random random = new Random();
        #endregion

        public string Content { get; set; }

        public void UpperSideRecipt()
        {
            #region ClearRecipt

            File.WriteAllText(cache.ReciptPath, " ");

            File.WriteAllText(cache.SubTotalPath, $"{0}");

            File.WriteAllText(cache.NumberOfArticlesPath, $"{1}");

            #endregion

            upperSide.Add(new GenerateRecipt { Content = "\t\t\tSC.Magazin.SRl\n" });
            upperSide.Add(new GenerateRecipt { Content = "\t\t\tLocatie\n" });
            upperSide.Add(new GenerateRecipt { Content = "\t\t\tComuna\n" });
            upperSide.Add(new GenerateRecipt { Content = "\t\t\tJudet\n" });
            upperSide.Add(new GenerateRecipt { Content = $"\t\t\tCIF:{product.Cif}\n" });
            upperSide.Add(new GenerateRecipt { Content = "-------------------------------------------------------------------\n" });

            foreach (GenerateRecipt reciptUpper in upperSide)
            {
                File.AppendAllText(cache.ReciptPath, reciptUpper.Content);
            }

        }
        public void LowerSideRecipt()
        {
            #region WriteTotal
            product.Total = int.Parse(File.ReadAllText(cache.SubTotalPath));

            File.AppendAllText(cache.ReciptPath, "\n-------------------------------------------------------------------\n");

            File.AppendAllText(cache.ReciptPath, $"Total:{product.Total} Lei");

            File.AppendAllText(cache.ReciptPath, "\n-------------------------------------------------------------------\n");

            #endregion

            lowerSide.Add(new GenerateRecipt { Content = $"Numerar\t\t\t\t\t\t{product.Total}.00\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"Rest\t\t\t\t\t\t\t\t{0.00d}" });
            lowerSide.Add(new GenerateRecipt { Content = $"\nTotal TVA A - 19% \t\t\t\t\t\t{(product.Total * 19) / 100}.00\n" });
            lowerSide.Add(new GenerateRecipt { Content = "Total TVA B - 9% \n" });
            lowerSide.Add(new GenerateRecipt { Content = $"Total TVA Bon \t\t\t\t\t\t\t {(product.Total * 19) / 100}.00\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"Nr.Poz.Art. in bon\t\t\t\t\t\t {File.ReadAllText(cache.NumberOfArticlesPath)}\n" });
            lowerSide.Add(new GenerateRecipt { Content = "-------------------------------------------------------------------\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"Z:{random.Next(10, 20)}{random.Next(30, 50)}" });
            lowerSide.Add(new GenerateRecipt { Content = $"\t\t\t\t\t\t\tNr.AMEF:{000}{random.Next(1, 5)}\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"\t\t\tID BF:{random.Next(50000, 100000)}{random.Next(10000, 5000000)}{random.Next(500000, 1000000)}{random.Next(10, 20)}\n\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"\t\t\tDATA SI ORA:{DateTime.Now}\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"S/N:DB:{random.Next(1000, 5000)}{random.Next(1000, 5000)}\t\t\t\t\t\t" });
            lowerSide.Add(new GenerateRecipt { Content = $"TD:{random.Next(2000, 4000)}{random.Next(3000, 8000)}\n" });
            lowerSide.Add(new GenerateRecipt { Content = $"Casier:{15}\t\t\t\t\t\t" });
            lowerSide.Add(new GenerateRecipt { Content = $"Casier:{15}\n" });
            lowerSide.Add(new GenerateRecipt { Content = "\t\t\tBon Fiscal" });


            foreach (GenerateRecipt lowerRecipt in lowerSide)
            {
                File.AppendAllText(cache.ReciptPath, lowerRecipt.Content);
            }

        }


    }
}
