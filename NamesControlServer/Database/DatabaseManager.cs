using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using NamesControlLib;
using NamesControlLib.Messages;

namespace NamesControlServer.Database
{
    internal static class DatabaseManager
    {

        private static SqlConnection OpenConnection()
        {
            // TODO: modify AttachDbFilename to relative path
            var connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\prace\\eprin\\pripadovka\\NamesControl\\NamesControlServer\\Database\\NamesDat.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new(connectionString);
            con.Open();

            return con;
        }

        private static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }

        public static string? AddRecord()
        {
            return null;
        }

        public static string? RemoveRecord()
        {
            return null;
        }

        public static string? EditRecord()
        {
            return null;
        }

        /** Maybe when the list would be passed as a reference parameter
         * and in the method body would be just modyfied, it wouldd be clearer
         */
        public static List<DatabaseRaw> GetGrid()
        {
            SqlConnection connection = OpenConnection();

            List<DatabaseRaw> grid = [];

            string query = "SELECT Id, FirstName, SecondName FROM Names";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string fstName = reader.GetString(1);
                        string sndName = reader.GetString(2);
                        grid.Add(new(id, fstName, sndName));
                    }
                }
            }

            CloseConnection(connection);

            Console.WriteLine(grid);

            return grid;
        }
    }
}
