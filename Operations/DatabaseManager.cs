using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class DatabaseManager
    {
        public SqlConnection _sqlConnection;
        
        
        public DatabaseManager()
        {
            ConnectDb();
        }

        private void ConnectDb()
        {
            var con = @"Server=FUDALA-KOMPUTER\SQLEXPRESS;Database=radosh_rent_car;Trusted_Connection=True;";
            _sqlConnection = new SqlConnection(con);
            _sqlConnection.Open();
        }
        
        //public void AllCustomer()
        //{
        //    var sql = " SELECT * FROM customers";
        //    var cmd = new SqlCommand(sql, _sqlConnection);
        //    SqlDataReader rdr = cmd.ExecuteReader();

        //    while (rdr.Read())
        //    {
        //        Console.WriteLine($"|{rdr.GetInt32(0),-4}| {rdr.GetString(1),-6}| {rdr.GetString(2),-6}|{rdr.GetString(3),-10}|{rdr.GetString(4),-10}|{rdr.GetString(5),-14}|");
        //    }

        //}
        //public void ParticularPerson(string firstName, string lastName)
        //{
        //    var sql = $"Select * from customers where first_name='{firstName}' and last_name='{lastName}'";
        //    var cmd = new SqlCommand(sql, _sqlConnection);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Console.WriteLine($"|{dr.GetInt32(0),-4}| {dr.GetString(1),-6}| {dr.GetString(2),-6}|{dr.GetString(3),-10}|{dr.GetString(4),-10}|{dr.GetString(5),-14}|");

        //    }
        //}
        //public void AddNewCustomer(string firstName, string lastName, string phoneNumber, string address, string description)
        //{
        //    var sql = $"INSERT INTO students VALUE('{firstName}','{lastName}','{phoneNumber},'{address}','{description}');";
        //    var cmd = new SqlCommand(sql, _sqlConnection);
        //    cmd.ExecuteNonQuery();
        //    Console.WriteLine($"Dodano klienta : {firstName} {lastName}");
        //}
    

    }
}
