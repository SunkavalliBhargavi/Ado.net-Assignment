using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectingToSqlServer
{
    internal class Class2
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=Bhargavi;Initial Catalog=EmployeeDatabase;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string updateQuery = "update Employee set Salary=9000 where EmployeeID=101";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            Console.WriteLine("Data updated");
            sqlConnection.Close();
            Console.ReadKey();

        }
    }
}
