using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.ViewModel.Conversion
{
    using Fulbank.Model;
    using MySqlConnector;
    using System.Data;

    public static class UserAccount
    {
        // Mappe le code devise à l'idCurrency de la base
        public static int GetCurrencyId(string currencyCode)
        {
            return currencyCode switch
            {
                "eur" => 1,
                "usd" => 2,
                "btc" => 3,
                "eth" => 4,
                _ => throw new ArgumentException("Devise inconnue")
            };
        }

        public static decimal GetBalance(string currencyCode)
        {
            int userId = SessionManager.CurrentUser;
            int currencyId = GetCurrencyId(currencyCode);
            decimal balance = 0;
            try
            {
                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT balance FROM Account WHERE idHolder=@userID AND idCurrency=@currencyID", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);
                    cmd.Parameters.AddWithValue("@currencyID", currencyId);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        balance = Convert.ToDecimal(result);
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du solde : {ex.Message}");
            }

            return balance;
        }
    }
}
