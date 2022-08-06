using Microsoft.Data.Sqlite;

namespace controlOfContacts.Database;

public class DatabaseSetup
{
    private readonly DatabaseConfig _databaseConfig;

    public DatabaseSetup(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }

    private void CreateContactTable()
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Contacts(
                id int not null primary key,
                name varchar(100) not null,
                email varchar(100) not null,
                telephone varchar(12) not null
            );
        ";

        command.ExecuteNonQuery();
        connection.Close();
    }
}
