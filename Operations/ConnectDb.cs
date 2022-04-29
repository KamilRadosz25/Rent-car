using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Operations
{
     class ConnectDb
    {
        private  SqlConnection _sqlConnection;
        
        public ConnectDb()
        {
            ConnectToDatabase();
            
        }
        
        public void ConnectToDatabase()
        {
            string connectionString = @"Server=FUDALA-KOMPUTER\SQLEXPRESS;Database=radosh_rent_car;Trusted_Connection=True;";
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }   
        /*public void Test()
        {
            var sql = "SELECT @@version";
            using var cmd = new SqlCommand(sql, _sqlConnection);
            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"MSSQL Version:  {version}");

        }
        public  void ExampleSelect(string query)
        {
            using var cmd = new SqlCommand(query, _sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);

            }

            reader.Close();
        }
        private static void ReadSingleRow(IDataRecord dataRecord) 
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", dataRecord[0], dataRecord[1], dataRecord[2], dataRecord[3], dataRecord[4], dataRecord[5]));
            }
            
        */


       



    }
}
