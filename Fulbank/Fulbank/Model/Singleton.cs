using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private MySqlConnection connection;

        private Singleton()
        {
            string connectionString = "Server=192.168.56.11; Port=25667;Database=Fulbank; UID=User1; Password=Kanek0Ma4ri4BDDTrnmtWeb;";
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
