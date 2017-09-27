using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //query
            string SelectAllStudents = "select * from Students";

            //string conn =
            //    "Server=tcp:easj2016100.database.windows.net,1433; Database = HotelDB; Persist Security Info = False; User ID = martin; Password =Pass1234; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
            //https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand(v=vs.110).aspx


            //string link til database
            string conn =
                "Server=tcp:studentdb.database.windows.net,1433;Initial Catalog=StudentDB;Persist Security Info=False;User ID=magnus;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(SelectAllStudents, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        //Så længe der er noget i databasen vil den skrive det ud
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            Console.WriteLine(id + " " + name);
                        }

                    }

                }
            }

            Console.ReadLine();

        }
    }
    }

