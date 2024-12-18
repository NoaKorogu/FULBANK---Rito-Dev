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

namespace Fulbank.View
{
    public partial class Deposit : Form
    {
        int userId = SessionManager.CurrentUser;
        int ammount = 0;
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

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
            FormHP form = new FormHP();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
            try
            {
                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand
                (
                    "START TRANSACTION;" +
                    "UPDATE `Account` SET balance = balance + @ammount WHERE idHolder = @currentUser AND idCurrency = 1;" +
                    "UPDATE Terminals SET balance = balance + @ammount WHERE id = 1;" +
                    "INSERT INTO Operation(account1, account2, amount1, exchangeRate, idAction, _date, idUser, idTerminal)" +
                    "VALUES ((SELECT id FROM Account WHERE idHolder = @currentUser AND idCurrency = 1), NULL, @ammount, 1, 2, NOW(), @currentUser, 1);" +
                    "COMMIT;", db.Connection)
                )
                {
                    cmd.Parameters.AddWithValue("@ammount", ammount);
                    cmd.Parameters.AddWithValue("@currentUser", userId);

                    cmd.ExecuteNonQuery();
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private void Btn_Add5_Click(object sender, EventArgs e)
        {
            ammount += 5;
            Lbl_Ammount.Text = ammount.ToString() + " €";
        }

        private void Btn_Add10_Click(object sender, EventArgs e)
        {
            ammount += 10;
            Lbl_Ammount.Text = ammount.ToString() + " €";
        }

        private void Btn_Add100_Click(object sender, EventArgs e)
        {
            ammount += 100;
            Lbl_Ammount.Text = ammount.ToString() + " €";
        }

        private void Btn_Rmv5_Click(object sender, EventArgs e)
        {
            if (ammount >= 5)
            {
                ammount -= 5;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas déposer cette somme !");
            }
        }

        private void Btn_Rmv10_Click(object sender, EventArgs e)
        {
            if (ammount >= 10)
            {
                ammount -= 10;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas déposer cette somme !");
            }
        }

        private void Btn_Rmv100_Click(object sender, EventArgs e)
        {
            if (ammount >= 100)
            {
                ammount -= 100;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas déposer cette somme !");
            }
        }
    }
}
