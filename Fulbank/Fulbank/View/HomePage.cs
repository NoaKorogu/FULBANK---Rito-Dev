using Fulbank.Model;
using Fulbank.View.Acc;
using Fulbank.View.transfer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormHP : Form
    {
        int userId = SessionManager.CurrentUser;
        public FormHP()
        {
            InitializeComponent();
        }

        private void FormHP_Load(object sender, EventArgs e)
        {
            loggedUser();
        }
        private void loggedUser()
        {
            try
            {

                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT username FROM Users WHERE id=@userID", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string username = row["username"].ToString();

                        lbl_user.Text = "Connecté en tant que :\n" + username;
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }
        private void Btn_Withdraw_Click(object sender, EventArgs e)
        {
            Withdraw form = new Withdraw();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            Welcome form = new Welcome();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Conversion conversation = new Conversion();
            conversation.Dock = DockStyle.Fill;
            conversation.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversation);
            conversation.Show();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Dock = DockStyle.Fill;
            deposit.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void Btn_BAcc_Click(object sender, EventArgs e)
        {
            BankAcc bankacc = new BankAcc();
            bankacc.Dock = DockStyle.Fill;
            bankacc.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(bankacc);
            bankacc.Show();
        }

        private void Btn_CAcc_Click(object sender, EventArgs e)
        {
            CryptoAcc cryptoacc = new CryptoAcc();
            cryptoacc.Dock = DockStyle.Fill;
            cryptoacc.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(cryptoacc);
            cryptoacc.Show();
        }

        private void Btn_Payment_Click(object sender, EventArgs e)
        {
            ChooseUser paymentTransfer = new ChooseUser();
            paymentTransfer.Dock = DockStyle.Fill;
            paymentTransfer.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(paymentTransfer);
            paymentTransfer.Show();
        }
    }
}
