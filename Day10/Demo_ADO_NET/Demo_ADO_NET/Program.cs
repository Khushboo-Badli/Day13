using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ADO_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string ConString = "Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";
            SqlConnection conn = new SqlConnection(ConString);
            string queery = "select * from khushboo_empolyee";
            conn.Open();
            SqlCommand cmd = new SqlCommand(queery, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + " ");

                }
                Console.WriteLine(" ");
            }

        }

    }
}
