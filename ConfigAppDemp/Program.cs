using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConfigAppDemp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value1 = ConfigurationManager.AppSettings["k1"];
            //Console.WriteLine(value1);
            //ReadProducts();
            string s = "string";
            string newStr = s.Substring(s.Length + 1);
            Console.WriteLine(newStr);
        }
        static void ReadProducts()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["WingtipToys"].ConnectionString;
            string queryString = "SELECT Id, ProductName FROM dbo.Products";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
            }
        }
    }
}
