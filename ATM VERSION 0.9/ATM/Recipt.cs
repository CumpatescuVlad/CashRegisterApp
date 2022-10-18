using System;
using System.Collections.Generic;
using System.IO;

namespace ATM
{
    internal class Recipt
    {
        AtmData stored = new AtmData();

        private string _reciptContent;

        public string ReciptContent { get => _reciptContent; set => _reciptContent = value; }

        public void CreateSoldRecipt(int language)
        {

            List<Recipt> romanianReciptContent = new List<Recipt>();

            romanianReciptContent.Add(new Recipt { ReciptContent = "BANCA ROMANA\n\nBine ati venit!\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "*******************************\nInterogare Sold\nTID:        0008129  MID:      8325823\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "-----------------------------------------\nChitanta NR: 243623    Batch Number: 4623525\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "Numar Card:456XX XXXX XXXX XXXX\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"\nAVETI DISPONIBIL:  {int.Parse(File.ReadAllText(stored.SoldAmountPath))}\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"\nVA MULTUMIM!\n" });

            if (language == 1)
            {

                foreach (Recipt romanianRecipt in romanianReciptContent)
                {
                    Console.WriteLine(romanianRecipt.ReciptContent);

                }
            }

            List<Recipt> englishReciptContent = new List<Recipt>();

            englishReciptContent.Add(new Recipt { ReciptContent = "BANCA ROMANA\nWelcome!\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "*******************************\nSold Cash\nTID:        0008129  MID:      8325823\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "-----------------------------------------\nRecipt NO: 243623    Batch Number: 4623525\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "Card Number:456XX XXXX XXXX XXXX\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"\nAVAILABBLE CASH:  {int.Parse(File.ReadAllText(stored.SoldAmountPath))}\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"\nTHANK YOU !\n" });
            if (language == 2)
            {
                foreach (Recipt englishRecipt in englishReciptContent)
                {
                    Console.WriteLine(englishRecipt.ReciptContent);

                }
            }




        }

        public void CreateWithdrawRecipt(int language)
        {

            List<Recipt> romanianReciptContent = new List<Recipt>();

            romanianReciptContent.Add(new Recipt { ReciptContent = "BANCA ROMANA\n\nBine ati venit!\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "*******************************\nRetragere Numerar\nTID:        0008129  MID:      8325823\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"Numar Card:456X XXXX XXXX XXXX\n-----------------------------------------\n{DateTime.Now}\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "-----------------------------------------\nChitanta NR: 243623    Batch Number: 4623525\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"\nSUMA:  {int.Parse(File.ReadAllText(stored.WithdrawedAmountPath))}\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"\nVA MULTUMIM!\nPASTRATI CHITANTA.\n" });

            if (language == 1)
            {

                foreach (Recipt romanianRecipt in romanianReciptContent)
                {
                    Console.WriteLine(romanianRecipt.ReciptContent);

                }
            }

            List<Recipt> englishReciptContent = new List<Recipt>();

            englishReciptContent.Add(new Recipt { ReciptContent = "BANCA ROMANA\nWelcome!\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "*******************************\nWithdraw Cash\nTID:        0008129  MID:      8325823\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"Card Number:456X XXXX XXXX XXXX\n-----------------------------------------\n{DateTime.Now}\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "-----------------------------------------\nRecipt NO: 243623    Batch Number: 4623525\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"\nAMOUNT:  {int.Parse(File.ReadAllText(stored.WithdrawedAmountPath))}\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"\nTHANK YOU !\nKEEP THE RECIPT.\n" });
            if (language == 2)
            {
                foreach (Recipt englishRecipt in englishReciptContent)
                {
                    Console.WriteLine(englishRecipt.ReciptContent);

                }
            }


        }

        public void CreateDepositRecipt(int language)
        {

            List<Recipt> romanianReciptContent = new List<Recipt>();

            romanianReciptContent.Add(new Recipt { ReciptContent = "BANCA ROMANA\n\nBine ati venit!\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "*******************************\nDepunere Numerar\nTID:        0008129  MID:      8325823\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"IBAN: RO3227520RNCB4235254\n-----------------------------------------\n{DateTime.Now}\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "-----------------------------------------\nChitanta NR: 243623    Batch Number: 4623525\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"\nSUMA:  {int.Parse(File.ReadAllText(stored.DepositAmountPath))}\n" });
            romanianReciptContent.Add(new Recipt { ReciptContent = $"\nVA MULTUMIM!\nPASTRATI CHITANTA.\n" });

            if (language == 1)
            {

                foreach (Recipt romanianRecipt in romanianReciptContent)
                {
                    Console.WriteLine(romanianRecipt.ReciptContent);

                }
            }

            List<Recipt> englishReciptContent = new List<Recipt>();

            englishReciptContent.Add(new Recipt { ReciptContent = "BANCA ROMANA\nWelcome!\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "*******************************\nDeposit Cash\nTID:        0008129  MID:      8325823\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"IBAN: RO3227520RNCB4235254\n-----------------------------------------\n{DateTime.Now}\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "-----------------------------------------\nRecipt NO: 243623    Batch Number: 4623525\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "PRN: 25235    COD AUTH: 4324235\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "STAN:   25324    RC: 00005\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = "---------------------------------------\n\n---------------------------------------" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"\nAMOUNT:  {int.Parse(File.ReadAllText(stored.DepositAmountPath))}\n" });
            englishReciptContent.Add(new Recipt { ReciptContent = $"\nTHANK YOU !\nKEEP THE RECIPT.\n" });
            if (language == 2)
            {
                foreach (Recipt englishRecipt in englishReciptContent)
                {
                    Console.WriteLine(englishRecipt.ReciptContent);

                }
            }


        }
    }
}
