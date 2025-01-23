using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

using NamesControlLib;
using NamesControlLib.Errors;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NamesControlServer.Database
{
    /// <summary>
    /// Represents database layer.
    /// Implements communication with database.
    /// </summary>
    internal static class DatabaseManager
    {
        /// <summary>
        /// Set and oppen connection to database.
        /// </summary>
        /// <returns> Opened connection. </returns>
        private static SqlConnection OpenConnection()
        {
            // Relative path from executable file to database
            string relativePath = @"..\..\..\Database\NamesDat.mdf";
            // Makes absolute path from relative path for current machine (filesystem)
            string absolutePath = Path.GetFullPath(relativePath);

            SqlConnectionStringBuilder conStringBuilder = new()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = absolutePath,
                IntegratedSecurity = true,
                ConnectTimeout = 30
            };

            SqlConnection connection = new(conStringBuilder.ConnectionString);
            connection.Open();

            return connection;
        }

        /// <summary>
        /// Closes opened connection.
        /// </summary>
        /// <param name="connection"> connection to be clossed </param>
        private static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        /// <summary>
        /// Process the whole query in database.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private static int RunQuery(string query)
        {
            SqlConnection connection = OpenConnection();

            SqlCommand command = new(query, connection);
            var reader = command.ExecuteReader();

            int recordsAffected = reader.RecordsAffected;

            CloseConnection(connection);

            return recordsAffected;
        }

        /// <summary>
        /// Realization of adding queries. 
        /// </summary>
        public static ErrorType AddRecord(string firstName, string secondName)
        {
            string query =
                $"INSERT INTO Names (FirstName, SecondName) " +
                $"VALUES ('{firstName}', '{secondName}');";
            RunQuery(query);
            return ErrorType.None;
        }

        /// <summary>
        /// Realization of removing Record.
        /// </summary>
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

        /// <summary>
        /// Realization of Editing record.
        /// </summary>
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
        /// <summary>
        /// Gets the current state of table.
        /// </summary>
        /// <returns></returns>
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
