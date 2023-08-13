using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = CFROM-LAPTOP\\SQLEXPRESS;" +
                "Initial Catalog=AP;" +
                "Integrated Security=true";
            
            string paramValue = "DC";

            string queryString1 = "SELECT VendorID, VendorName, VendorCity, VendorState, VendorPhone " +
                "FROM Vendors " +
                "WHERE VendorState = @givenState " +
                "ORDER BY VendorCity, VendorName";

            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                Console.WriteLine("Query 1");
                SqlCommand command = new SqlCommand(queryString1, connection1);
                command.Parameters.AddWithValue("@givenState", paramValue);
                try
                {
                    connection1.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0,3}{1,35}{2,15}{3,5}{4,20}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
            }

            string queryString2 = "INSERT INTO Terms " +
                "VALUES ('Net due 100 days', 100)";

            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                Console.WriteLine("Query 2");
                SqlCommand command = new SqlCommand(queryString2, connection2);
                try
                {
                    connection2.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            string queryString3 = "SELECT SUM(InvoiceTotal) " +
                "FROM Invoices";

            using (SqlConnection connection3 = new SqlConnection(connectionString))
            {
                Console.WriteLine("Query 3");
                SqlCommand command = new SqlCommand(queryString3, connection3);
                try
                {
                    connection3.Open();
                    decimal result = Math.Round((decimal)command.ExecuteScalar(), 2);
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
