using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectingToSqlServer
{
    internal class Class4
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=Bhargavi;Initial Catalog=EmployeeDatabase;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Enter Employee id tat you want to delete:");
            int EmployeeID = int.Parse(Console.ReadLine());
            string deleteQuery = "delete from Employee where EmployeeID='" + EmployeeID + "'";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Data is deleted");
            Console.ReadKey();

            sqlConnection.Close();
            
        }
    }
}
