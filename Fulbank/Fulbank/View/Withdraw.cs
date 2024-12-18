using Fulbank.Model;
using Fulbank.View.transfer;
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

namespace Fulbank.View
{
    public partial class Withdraw : Form
    {
        int userId = SessionManager.CurrentUser;
        int ammount = 0;
        float currentAmmount = 0;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            loadMoney();
        }

        private void loadMoney()
        {
            try
            {

                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT balance FROM `Account` WHERE idHolder=@userID and idCurrency=1", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        currentAmmount = Convert.ToSingle(row["balance"]);
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            FormHP form = new FormHP();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (currentAmmount >= ammount)
            {
                try
                {
                    Singleton db = Singleton.Instance;
                    db.OpenConnection();

                    using (MySqlCommand cmd = new MySqlCommand
                    (
                        "START TRANSACTION;" +
                        "UPDATE `Account` SET balance = balance - @ammount WHERE idHolder = @currentUser AND idCurrency = 1;" +
                        "UPDATE Terminals SET balance = balance - @ammount WHERE id = 1;" +
                        "INSERT INTO Operation(account1, account2, amount1, exchangeRate, idAction, _date, idUser, idTerminal)" +
                        "VALUES ((SELECT id FROM Account WHERE idHolder = @currentUser AND idCurrency = 1), NULL, @ammount, 1, 1, NOW(), @currentUser, 1);" +
                        "COMMIT;", db.Connection)
                    )
                    { 
                        cmd.Parameters.AddWithValue("@ammount", ammount);
                        cmd.Parameters.AddWithValue("@currentUser", userId);

                        cmd.ExecuteNonQuery();
                    }
                        db.CloseConnection();
                    /* Potentiel rajout d'un timer simulant le temps de sortie des billets */
                    FormHP form = new FormHP();
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(form);
                    form.Show();
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur: {ex.Message}");
                }
            }
            else
            {
                ammount = 0;
                Lbl_ammount.Text = ammount.ToString() + " €";
                MessageBox.Show("Vous ne pouvez pas retirer cette somme !");
            }
            
        }

        private void Btn_Add5_Click(object sender, EventArgs e)
        {
            ammount += 5;
            Lbl_ammount.Text = ammount.ToString() + " €";
        }

        private void Btn_Add10_Click(object sender, EventArgs e)
        {
            ammount += 10;
            Lbl_ammount.Text = ammount.ToString() + " €";
        }

        private void Btn_Add100_Click(object sender, EventArgs e)
        {
            ammount += 100;
            Lbl_ammount.Text = ammount.ToString() + " €";
        }

        private void Btn_Rmv5_Click(object sender, EventArgs e)
        {
            if (ammount >= 5)
            {
                ammount -= 5;
                Lbl_ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas retirer cette somme !");
            }
        }

        private void Btn_Rmv10_Click(object sender, EventArgs e)
        {
            if (ammount >= 10)
            {
                ammount -= 10;
                Lbl_ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas retirer cette somme !");
            }
        }

        private void Btn_Rmv100_Click(object sender, EventArgs e)
        {
            if (ammount >= 100)
            {
                ammount -= 100;
                Lbl_ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas retirer cette somme !");
            }
        }
    }
}
