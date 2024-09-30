using System;
using System.Data.SQLite;

public class DatabaseManager
{
    private string connectionString = "Data Source=tasks.db;Version=3;";

    public DatabaseManager()
    {
        CreateDatabaseAndTable();
    }

    // Create the database and table if not exists
    private void CreateDatabaseAndTable()
    {
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string sql = @"CREATE TABLE IF NOT EXISTS Tasks (
                            TaskID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Description TEXT,
                            DueDate DATETIME,
                            Priority TEXT,
                            IsCompleted BOOLEAN
                           )";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
