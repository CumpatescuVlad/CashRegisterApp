using System;
using System.IO;


namespace BankCustomerDatabaseSimulator
{
    public class Customer
    {

        private string _customerName;

        private string _customerId;

        private string _customerAdress;

        private string _customerCardNumber;

        public string customerName { get => _customerName; set => _customerName = "Customer Name: " + value; }

        public string customerId { get => _customerId; set => _customerId = "Customer ID: " + value; }

        public string customerAdress { get => _customerAdress; set => _customerAdress = "Customer Adress: " + value; }

        public string customerCardNumber { get => _customerCardNumber; set => _customerCardNumber = "Customer Card Number:" + value; }

        public void InsertCustomerData(string path)
        {

            Console.Write("\nEnter Customer Name: ");

            customerName = Console.ReadLine();

            Console.Write("Enter Customer ID: ");

            customerId = Console.ReadLine();

            Console.Write("Enter Customer Adress: ");

            customerAdress = Console.ReadLine();

            Console.Write("Enter Customer Credit Card Number: ");

            customerCardNumber = Console.ReadLine();

            File.WriteAllText(path, customerName);

            File.AppendAllText(path, "\n" + customerId);

            File.AppendAllText(path, "\n" + customerAdress);

            File.AppendAllText(path, "\n" + customerCardNumber);



        }
        public string EncryptionMethod(string property)
        {


            string cut = "*****" + property.Substring(property.Length - 2, 2);

            return cut;

        }
        public void CreateCustomerEncryptedData(string path2)
        {
            Customer manage = new Customer();

            File.WriteAllText(path2, $"Customer Name: {manage.EncryptionMethod(customerName)}");

            File.AppendAllText(path2, $"\nCustomer Id: {manage.EncryptionMethod(customerId)}");

            File.AppendAllText(path2, $"\nCustomer Adress: {manage.EncryptionMethod(customerAdress)}");

            File.AppendAllText(path2, $"\nCustomer Card Number: {manage.EncryptionMethod(customerCardNumber)}");




        }
        public void StoreNumberOfCustomers()
        {

            Console.Write("\nEnter the number of customers you want to store (MAX 5)\n\nNumber of customers......");

            int numberOfCustomers = int.Parse(Console.ReadLine());

            bool isRunning = true;

            while (isRunning)
            {
                switch (numberOfCustomers)
                {
                    case 0:

                        isRunning = false;

                        break;

                    case 1:

                        AddOneCustomer();

                        return;

                    case 2:

                        AddTwoCustomers();

                        return;

                    case 3:
                        AddThreeCustomers();

                        return;

                    case 4:
                        AddFourCustomers();

                        return;

                    case 5:
                        AddFiveCustomers();

                        return;

                    

                }
            }



        }
        public void AddOneCustomer()
        {
            Customer manage = new Customer();

            Console.WriteLine("\nEnter First Customer Data: ");

            manage.InsertCustomerData("C:/Customer Data/Customer.txt");

            manage.CreateCustomerEncryptedData("C:/Customer Data/CustomerSecure.txt");


        }
        public void AddTwoCustomers()
        {
            Customer manage = new Customer();

            AddOneCustomer();

            Console.WriteLine("\nEnter Second Customer Data: ");

            manage.InsertCustomerData("C:/Customer Data/Customer2.txt");

            manage.CreateCustomerEncryptedData("C:/Customer Data/CustomerSecure2.txt");


        }
        public void AddThreeCustomers()
        {
            Customer manage = new Customer();

            AddTwoCustomers();

            Console.WriteLine("\nEnter Third Customer Data: ");

            manage.InsertCustomerData("C:/Customer Data/Customer3.txt");

            manage.CreateCustomerEncryptedData("C:/Customer Data/CustomerSecure3.txt");





        }
        public void AddFourCustomers()
        {
            Customer manage = new Customer();

            AddThreeCustomers();

            Console.WriteLine("\nEnter Forth Customer Data: ");

            manage.InsertCustomerData("C:/Customer Data/Customer4.txt");

            manage.CreateCustomerEncryptedData("C:/Customer Data/CustomerSecure4.txt");


        }
        public void AddFiveCustomers()
        {
            Customer manage = new Customer();

            AddFourCustomers();

            Console.WriteLine("\nEnter Fifth Customer Data: ");

            manage.InsertCustomerData("C:/Customer Data/Customer5.txt");

            manage.CreateCustomerEncryptedData("C:/Customer Data/CustomerSecure5.txt");



        }
        public void ReadCustomerEncryptedData()
        {
            Customer manage = new Customer();

            Console.WriteLine("\nFirst Customer`s Data: \n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/CustomerSecure.txt"));

            Console.WriteLine("\nSecond Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/CustomerSecure2.txt"));

            Console.WriteLine("\nThird Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/CustomerSecure3.txt"));

            Console.WriteLine("\nForth Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/CustomerSecure4.txt"));

            Console.WriteLine("\nFifth Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/CustomerSecure5.txt"));



        }
        public void ReadCustomerOriginalData()
        {

            Console.WriteLine("\n---------ORIGINAL DATA------\n");

            Console.WriteLine("\nFirst Customer`s Data: ");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/Customer.txt"));

            Console.WriteLine("\nSecond Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/Customer2.txt"));

            Console.WriteLine("\nThird Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/Customer3.txt"));

            Console.WriteLine("\nForth Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/Customer4.txt"));

            Console.WriteLine("\nFifth Customer`s Data\n");

            Console.WriteLine(File.ReadAllText("C:/Customer Data/Customer5.txt"));

            


        }
        public void SecurityCheck()
        {

            int pin = 2003;

            Console.Write("\nTo acces original data type the security pin......");

            int readpin = int.Parse(Console.ReadLine());

            if (readpin == pin)
            {
                ReadCustomerOriginalData();

            }
            else
            {
                for (int i = 2; i >= 1; i--)
                {
                    Console.WriteLine("\n!!!Wrong Pin!!!\n");

                    Console.WriteLine($"Attempts left: {i} \n");

                    Console.Write("Pin: ");

                    readpin = int.Parse(Console.ReadLine());

                    if (readpin == pin)
                    {

                        ReadCustomerOriginalData();

                        return;

                    }

                }



            }






        }
        public void Menu()
        {
            Console.WriteLine("\nPress 1 to add a new Customer\n2 To display stored customers\nPress 0 to exit ");

            Console.WriteLine();

            Console.Write("You Selected......");
            try
            {
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        StoreNumberOfCustomers();
                        break;
                    case 2:
                        ReadCustomerEncryptedData();
                        SecurityCheck();
                        Console.ReadLine();
                        break;

                }
            }
            catch
            {
                Console.WriteLine();

                Console.WriteLine("!!!!ONLY NUMBERS ARE ALLOWED");

                Console.WriteLine();

                Main();

            }

        }

        public static void Main()
        {
            Customer manage = new Customer();

            manage.Menu();

        }

    }

}
