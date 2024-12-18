using Fulbank.Model;
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

namespace Fulbank.View.transfer
{
    public partial class ChooseUser : Form
    {
        int userId = SessionManager.CurrentUser;
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            amount formV = new amount();
            string beneficiary = dgvTransfer.Rows[0].Cells[0].Value.ToString();
            formV.beneficiary_name = beneficiary;
            formV.Dock = DockStyle.Fill;
            formV.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(formV);
            formV.Show();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            FormHP formC = new FormHP();
            formC.Dock = DockStyle.Fill;
            formC.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(formC);
            formC.Show();
        }

        private void ChooseUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void Txtbox_Search_TextChanged(object sender, EventArgs e)
        {
            string beneficiary = Txtbox_Search.Text + "%";
            try
            {
                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE username LIKE @beneficiary AND id!=@currentUser;", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@beneficiary", beneficiary);
                    cmd.Parameters.AddWithValue("@currentUser", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dgvTransfer.Columns.Count == 0)
                    {
                        DataGridViewColumn usernameColumn = new DataGridViewTextBoxColumn();
                        usernameColumn.HeaderText = "Username";
                        usernameColumn.DataPropertyName = "username";
                        usernameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvTransfer.Columns.Add(usernameColumn);
                    }
                    dgvTransfer.Rows.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string username = row["username"].ToString();
                        string password = row["password"].ToString();

                        // Add each user's username to the DataGridView
                        dgvTransfer.Rows.Add(username);
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