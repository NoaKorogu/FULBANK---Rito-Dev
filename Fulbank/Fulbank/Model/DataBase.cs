using MySql.Data.MySqlClient;
using System;

public sealed class DatabaseConnection
{
    private static readonly DatabaseConnection instance = new DatabaseConnection();
    private MySqlConnection connection;

    // Cha�ne de connexion � adapter selon vos besoins
    private string connectionString = "Server=172.16.119.101;Database=Fulbank;UID=admin;Password=MDPadminTEST;";

    // Constructeur priv� pour emp�cher l'instanciation � l'ext�rieur
    private DatabaseConnection()
    {
        connection = new MySqlConnection(connectionString);
    }

    public static DatabaseConnection Instance
    {
        get
        {
            return instance;
        }
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
} 