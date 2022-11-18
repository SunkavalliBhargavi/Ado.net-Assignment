using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectingToSqlServer
{
    internal class Class3
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=Bhargavi;Initial Catalog=EmployeeDatabase;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Enter Employee id");
            int EmployeeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the salary that you want to change");
            int Salary = int.Parse(Console.ReadLine()); 
            string updateQuery = "update Employee set Salary='"+Salary+"' where EmployeeID='"+EmployeeID+"'";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Data updated");
            sqlConnection.Close();
            Console.ReadKey();
        }
    }
}
