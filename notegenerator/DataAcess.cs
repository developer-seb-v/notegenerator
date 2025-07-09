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

        public static List<string> GetTechs()
        {
            var techs = new List<string>();
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT name FROM techs";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            techs.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return techs;
        }

        public static List<string> GetOrderingMds()
        {
            var orderingMds = new List<string>();
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT name FROM ordering_mds";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderingMds.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return orderingMds;
        }

        public static void AddTech(string techName)
        {
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO techs (name) VALUES (@name)";
                    command.Parameters.AddWithValue("@name", techName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddOrderingMd(string mdName)
        {
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO ordering_mds (name) VALUES (@name)";
                    command.Parameters.AddWithValue("@name", mdName);
                    command.ExecuteNonQuery();
                }
            }
        }

        
    }
}
