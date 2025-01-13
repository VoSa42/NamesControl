using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

using NamesControlLib;
using NamesControlLib.Errors;

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

        private static int RunQuery(string query)
        {
            SqlConnection connection = OpenConnection();

            SqlCommand command = new(query, connection);
            var reader = command.ExecuteReader();

            int recordsAffected = reader.RecordsAffected;

            CloseConnection(connection);

            return recordsAffected;
        }

        public static ErrorType AddRecord(string firstName, string secondName)
        {
            string query =
                $"INSERT INTO Names (FirstName, SecondName) " +
                $"VALUES ('{firstName}', '{secondName}');";
            RunQuery(query);
            return ErrorType.None;
        }

        public static ErrorType RemoveRecord(int id)
        {
            string query =
                $"DELETE FROM Names " +
                $"WHERE Id={id};";
            int recordAffected = RunQuery(query);

            if(recordAffected == 0)
            {
                return ErrorType.RecordNotExist;
            }
            return ErrorType.None;
        }

        public static ErrorType EditRecord(int id, string newFstName, string newSndName)
        {
            string query =
                $"UPDATE Names " +
                $"SET FirstName='{newFstName}', SecondName='{newSndName}' " +
                $"WHERE Id={id};";
            int recordAffected = RunQuery(query);

            if (recordAffected == 0)
            {
                return ErrorType.RecordNotExist;
            }
            return ErrorType.None;
        }

        /** The query maybe should be ran using the RunQuery method.
         * The problem is return value, this method needs specific one
         */
        public static List<NamesTableRow> GetTable()
        {
            SqlConnection connection = OpenConnection();

            List<NamesTableRow> table = [];

            string query = "SELECT Id, FirstName, SecondName FROM Names";

            using (SqlCommand command = new(query, connection))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string fstName = reader.GetString(1);
                    string sndName = reader.GetString(2);
                    table.Add(new(id, fstName, sndName));
                }
            }

            CloseConnection(connection);

            return table;
        }
    }
}
