using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using NamesControlLib.Messages;

namespace NamesControlServer.Database
{
    internal class DatabaseManager
    {
        private SqlConnection Connection { get; set; }

        public DatabaseManager()
        {
            // TODO: modify AttachDbFilename to relative path
            var connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\prace\\eprin\\pripadovka\\NamesControl\\NamesControlServer\\Database\\NamesDat.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new(connectionString);

            connection.Open();

            Connection = connection;
        }

        public static void AddRecord()
        {

        }

        public static void RemoveRecord()
        {

        }

        public static void EditRecord()
        {

        }

        public static void GetGrid()
        {

        }
    }
}
