using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

using NamesControlLib;
using NamesControlLib.Messages;

namespace NamesControlServer.Database
{
    internal static class DatabaseManager
    {
        private static string? GetThisFilePath([CallerFilePath] string? path = null)
        {
            return path;
        }

        private static SqlConnection OpenConnection()
        {
            string? path = GetThisFilePath();
            string? directory = Path.GetDirectoryName(path);

            SqlConnectionStringBuilder conStringBuilder = new()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = $"{directory}\\NamesDat.mdf",
                IntegratedSecurity = true,
                ConnectTimeout = 30
            };

            SqlConnection connection = new(conStringBuilder.ConnectionString);
            connection.Open();

            return connection;
        }

        private static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        private static void RunQuery(string query)
        {
            SqlConnection connection = OpenConnection();

            SqlCommand command = new(query, connection);
            _ = command.ExecuteReader();

            CloseConnection(connection);
        }

        public static string? AddRecord(string firstName, string secondName)
        {
            string query =
                $"INSERT INTO Names (FirstName, SecondName) " +
                $"VALUES ('{firstName}', '{secondName}');";
            RunQuery(query);
            return null;
        }

        public static string? RemoveRecord(int id)
        {
            string query =
                $"DELETE FROM Names " +
                $"WHERE Id={id};";
            RunQuery(query);
            return null;
        }

        public static string? EditRecord(int id, string newFstName, string newSndName)
        {
            string query =
                $"UPDATE Names " +
                $"SET FirstName='{newFstName}', SecondName='{newSndName}' " +
                $"WHERE Id={id};";
            RunQuery(query);
            return null;
        }

        /** The query maybe should be ran using the RunQuery method.
         * The problem is return value, this method needs specific one
         */
        public static List<DatabaseRaw> GetGrid()
        {
            SqlConnection connection = OpenConnection();

            List<DatabaseRaw> grid = [];

            string query = "SELECT Id, FirstName, SecondName FROM Names";

            using (SqlCommand command = new(query, connection))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string fstName = reader.GetString(1);
                    string sndName = reader.GetString(2);
                    grid.Add(new(id, fstName, sndName));
                }
            }

            CloseConnection(connection);

            return grid;
        }
    }
}
