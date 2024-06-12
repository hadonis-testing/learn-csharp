using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace CS15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = "database.db";

            using (var connection = new SqliteConnection(stringBuilder.ConnectionString))
            {
                connection.Open();
                Console.WriteLine($"Status: {connection.State}");

                using (var cmd = new SqliteCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM student";

                    var dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Console.WriteLine($"- Data: {dataReader["name"]}");
                    }
                }

                connection.Close();
                Console.WriteLine($"Status: {connection.State}");
            }
        }
    }
}
