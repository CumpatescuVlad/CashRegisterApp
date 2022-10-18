using System;

namespace ATM
{
    internal class Program
    {


        static void Main()
        {
            
            Console.WriteLine("Introduceti Cardul   Insert Card");

            Console.ReadKey();

            Console.WriteLine("Apasati 1 pentru ROMANA or Press 2 for ENGLISH");

            AtmLanguageSelector();

            



        }
        public static void AtmLanguageSelector()
        {
            Romanian romanian = new Romanian();

            English english = new English();

            int.TryParse(Console.ReadLine(), out int language);

            switch (language)
            {
                case 1:

                    romanian.RomanianMenu();

                    break;

                case 2:

                    english.EnglishMenu();

                    break;

            }

        }


    }
}
