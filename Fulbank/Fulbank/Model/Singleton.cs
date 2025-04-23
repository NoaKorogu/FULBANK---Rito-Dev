using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;  

namespace Fulbank.Model
{
    class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private MySqlConnection connection;

        private Singleton()
        {
            // Configuration file path
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent?.Parent?.Parent?.FullName;
            string configPath = Path.Combine(projectDirectory, "Params", "config.ini");

            //Check if the config file exists
            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException("Fichier de configuration introuvable.", configPath);
            }

            //ini file parser
            var parser = new FileIniDataParser();
            IniData configData = parser.ReadFile(configPath);

            //DataBase params
            string server = configData["MYSQL"]["Host"];
            string database = configData["MYSQL"]["DataBase"];
            string user = configData["MYSQL"]["User"];
            string pwd = configData["MYSQL"]["Password"];

            string connectionString = $"Server={server};Database={database};Uid={user}; Pwd={pwd};";


            connection = new MySqlConnection(connectionString);
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }
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
}
