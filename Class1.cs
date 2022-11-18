using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectingToSqlServer
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=Bhargavi;Initial Catalog=EmployeeDatabase;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Please Enter Employee Name:");
            String EmployeeName = Console.ReadLine();
            Console.WriteLine("Please Enter Employee Id:");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Salary");
            int Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter City Name");
            string City = Console.ReadLine();
            string insertQuery = "insert into Employee(EmployeeName,EmployeeID,Salary,City)Values('" + EmployeeName + "','" + EmployeeID + "','" + Salary + "','" + City + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data is inserted");
            sqlConnection.Close();
            Console.ReadKey();
        }
    }
}
            