using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.IO;
using System.Reflection;

namespace TestProject
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //File.WriteAllText(@"E:\CODE REPOS\File.csv", $"{2},{34}");

            //EncryptFile(@"E:\CODE REPOS\File.csv");

            //int myNum = 15;
            /*
            unsafe 
            {
                int* numPointer = & myNum;

                Console.WriteLine(*numPointer);//Value
                Console.WriteLine((int)&myNum);//Memory Adress
            }
            */

            string product = "2x23459824";

            int numberOfProducts = int.Parse(product.Substring(0, 1));

            int barcode = int.Parse(product.Substring(2, 8));

            Console.WriteLine(numberOfProducts);
            Console.WriteLine(barcode);
            

        }
        public static string CreateCar()
        {
            List<Vehicles> cars= new List<Vehicles>();

            cars.Add(new Vehicles { Name = "C2", YearOfManufacturing = 1993, Brand = "Volvo" });
            cars.Add(new Vehicles { Brand = "Dacia", YearOfManufacturing = 2003, Name = "Logan" });
            cars.Add(new Vehicles { Name = "X6", YearOfManufacturing = 2006, Brand = "BMW" });

         
            foreach (Vehicles car in cars)
            {
                Console.WriteLine($"This car is {car.Name} , is manufactored by {car.Brand} is {2022 - car.YearOfManufacturing} old ."); 
            }

            return "The End";
        }
        public static void EncryptFile(string path)
        {


            File.Encrypt(path);

        }

     
        
    }
}
