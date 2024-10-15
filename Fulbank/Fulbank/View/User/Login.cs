using MySqlConnector;
using Fulbank.Model;
using System.Data;

namespace Fulbank.View

{
    public partial class Form1 : Form
    {
        List<Users> users; // Declaration

        public Form1()
        {
            InitializeComponent();
            Btn_Valid.FlatStyle = FlatStyle.Flat;
            Btn_Valid.FlatAppearance.BorderSize = 0;
            Btn_Cancel.FlatStyle = FlatStyle.Flat;
            Btn_Cancel.FlatAppearance.BorderSize = 0;

            users = new List<Users>(); // Initialize the list
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadUsers(); // Load users when the form loads
        }

        private void loadUsers()
        {

            try
            {
                Singleton db = Singleton.Instance;
                db.OpenConnection();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users", db.Connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int id = Convert.ToInt32(row["id"]);
                            string username = row["username"].ToString();
                            string password = row["password"].ToString();

                            Users monUser = new Users(id, username, password);
                            users.Add(monUser);
                        }
                    } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        
        private void btn_valid_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Users user in users)
            {
                if (TxtboxUsername.Text != null && TxtboxUsername.Text == user.getUsername() && TxtboxPasswrd != null && TxtboxPasswrd.Text == user.getPassword())
                {
                    check = true;
                    FormHP form = new FormHP();
                    form.Dock = DockStyle.Fill;
                    form.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(form);
                    form.Show();
                    break;
                }
            }
            if (check == false)
            {
                MessageBox.Show("Le user n'existe pas !");
                TxtboxPasswrd.Clear();
            }

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Welcome form = new Welcome();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
