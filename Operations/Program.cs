using System;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            while (true)
            {
                ColorChanger.MainColor("Radosh Rent Car - Obsługa klienta");
                ColorChanger.OptionColor("Co chcesz zrobić? \n 1. Dodaj Klienta\n 2. Wyświetl liste klientów \n 3.Edytuj dane klienta");
                int option;
                var valid = int.TryParse(Console.ReadLine(), out option);
                Customer customer = new Customer();
                CustomerService customerService = new CustomerService();

                if (valid)
                {


                    switch(option)
                    {
                        case 1:
                            
                            Console.WriteLine("Podawaj dane poprzedzając enterem");
                            Console.WriteLine("Podaj Imie i nazwisko");
                            name = Console.ReadLine();
                            string[] subs = name.Split(' ');
                            customer.FirstName = subs[0];
                            customer.LastName = subs[1];
                            Console.WriteLine("Podaj numer telefonu");
                            customer.PhoneNumber = Console.ReadLine();
                            Console.WriteLine("Podaj Adres");
                            customer.Address = Console.ReadLine();
                            Console.WriteLine("Jeżeli chcesz dodaj opis do klienta");
                            customer.Description = Console.ReadLine();

                            customerService.AddCustomer(customer);



                            break;
                         case 2:
                                customerService.CheckAllCustomers();

                                break;
                         case 3:
                            Console.WriteLine("Podaj imie i nazwisko poprzedzając każde enterem");
                            customer.FirstName = Console.ReadLine();
                            customer.LastName = Console.ReadLine();
                            customerService.ModifyCustomer(customer);


                            break;


                    }

                    }

                }
            

            //var customer = new Customer
            //{
            //    FirstName = "Andrzej",
            //    LastName = "Trololo"
            //};

            //var customerService = new CustomerService();
            //customerService.AddCustomer(customer);

            //DatabaseManager databaseManager = new DatabaseManager();
            //databaseManager.ConnectDb();

            //DatabaseManager databaseManager1 = new DatabaseManager();
            //databaseManager.ParticularPerson("Janusz","Nowak");
            //databaseManager1.AddNewCustomer("Kamil","Radosz","123456789","Kolorowa 12","Fajny Klient");


        }
    }
}
