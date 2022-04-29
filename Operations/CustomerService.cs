using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{

    internal class CustomerService
    {
         private DatabaseManager _dbManager;

         public CustomerService()
         {
             _dbManager = new DatabaseManager();
         }
       
 
        public void CheckAllCustomers()
        {
            var sql = " SELECT * FROM customers";
            using var cmd = new SqlCommand(sql, _dbManager._sqlConnection);
            using SqlDataReader customers = cmd.ExecuteReader();
            while (customers.Read())
            {
                Console.WriteLine($"{customers.GetInt32(0),-4}|{customers.GetString(1),-10}|{customers.GetString(2),-10}|{customers.GetString(3),-10}|{customers.GetString(4),-10}|{customers.GetString(5),-10}|");
            }
        }
        public void AddCustomer(Customer customer)
        {
            var fn = customer.FirstName;
            var ln = customer.LastName;
            var pn = customer.PhoneNumber;
            var ad = customer.Address;
            var ds = customer.Description;
            var sql = $"INSERT INTO customers VALUES ('{fn}','{ln}','{pn}','{ad}','{ds}')";
            using var cmd = new SqlCommand(sql, _dbManager._sqlConnection);
            cmd.ExecuteNonQuery();
            ColorChanger.AcceptColor("Udało się dodać klienta");

        }
        public void ModifyCustomer(Customer customer)
        {
            string sql = null;
            var fn = customer.FirstName;
            var ln = customer.LastName;
            var pn = customer.PhoneNumber;
            var ad = customer.Address;
            var ds = customer.Description = null;// ??
            Console.WriteLine("Wybierz co chcesz zmienić 1.Address \n 2.Numer Telefonu 3.\n Dodaj/Zmień opis");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"wprowadz nowy adres dla: {fn} {ln}");
                    ad = Console.ReadLine();
                    sql = $"UPDATE customers set address='{ad}' where first_name={fn} and last_name={ln}";
                    break;
                case 2:
                    Console.WriteLine($"wprowadz nowy numer kontaktowy dla: {fn} {ln}");
                    pn = Console.ReadLine();
                    sql = $"UPDATE customers set phone_number='{pn}' where first_name={fn} and last_name={ln}";
                    break;
                case 3:
                    Console.WriteLine($"wprowadz nowy opis dla: {fn} {ln}");
                    ds = Console.ReadLine();
                    sql = $"UPDATE customers set description='{ds}' where first_name='{fn}' and last_name='{ln}'";
                    break;
            }
            using var cmd = new SqlCommand(sql, _dbManager._sqlConnection);
            cmd.ExecuteNonQuery();
            //Console.WriteLine($"Udało się zmodyfikować użytkownika: {fn} {ln}");// Add method AcceptColor
            ColorChanger.AcceptColor($"Udało się zmodyfikowac użytkownika: {fn} {ln}");
        }
        public void SpecificDataCustomer(Customer customer)
        {
            var fn = customer.FirstName;
            var ln = customer.LastName;
            var sql = $"SELECT * from customers where first_name='{fn}' and last_name='{fn}'";
            using var cmd = new SqlCommand(sql, _dbManager._sqlConnection);
            using SqlDataReader customers = cmd.ExecuteReader();
            while (customers.Read())
            {
                Console.WriteLine($"{customers.GetInt32(0),-4}|{customers.GetString(1),-10}|{customers.GetString(2),-10}|{customers.GetString(3),-10}|{customers.GetString(4),-10}|{customers.GetString(5),-10}|");
            }


        }
    }
}
