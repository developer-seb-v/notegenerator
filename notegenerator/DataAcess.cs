using System.Collections.Generic;
using Microsoft.Data.Sqlite;


namespace notegenerator
{
    public static class DataAcess
    {

        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appdata.db");

        public static void InitializeDatabase()
        {
            // Ensure the database file exists
            if (!File.Exists(dbPath))
            {
                // Just creating the file triggers SQLite to make a new DB when we open a connection
                using (File.Create(dbPath)) { }
            }

            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();

                string createTechsTable = @"
                CREATE TABLE IF NOT EXISTS techs (
                    name TEXT NOT NULL
                );";

                string createOrderingMdsTable = @"
                CREATE TABLE IF NOT EXISTS ordering_mds (
                    name TEXT NOT NULL
                );";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createTechsTable;
                    command.ExecuteNonQuery();

                    command.CommandText = createOrderingMdsTable;
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
