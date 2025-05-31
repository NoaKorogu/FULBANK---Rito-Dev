using Fulbank.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.View.Acc
{
    public partial class CryptoAcc : Form
    {
        int userId = SessionManager.CurrentUser;
        public CryptoAcc()
        {
            InitializeComponent();
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            FormHP formhp = new FormHP();
            formhp.Dock = DockStyle.Fill;
            formhp.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(formhp);
            formhp.Show();
        }

        private void Lbl_Crypto_Click(object sender, EventArgs e)
        {

        }

        private void CryptoAcc_Load(object sender, EventArgs e)
        {
            loadMoney();
        }

        private void loadMoney()
        {
            try
            {

                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT balance FROM `Account` WHERE idHolder=@userID and idCurrency=3", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string balance = row["balance"].ToString();

                        Lbl_BTC.Text = balance + " BTC";
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand("SELECT balance FROM `Account` WHERE idHolder=@userID and idCurrency=4", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string balance = row["balance"].ToString();

                        Lbl_ETH.Text = balance + " Eth";
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }
    }
}
