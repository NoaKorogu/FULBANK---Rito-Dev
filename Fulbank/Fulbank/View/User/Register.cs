using Fulbank.Model;
using MySqlConnector;
using System.Data;

namespace Fulbank.View
{
    public partial class Register : Form
    {
        List<Users> users; // Declaration
        public Register()
        {
            InitializeComponent();
            users = new List<Users>();
        }
        private void Register_Load(object sender, EventArgs e)
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

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Users user in users)
            {
                if (TxtboxUsername.Text != null && TxtboxPasswrd.Text != null && TxtboxPasswrd.Text == TxtboxPasswrdConfirm.Text)
                {
                    check = true;
                    try
                    {
                        Singleton db = Singleton.Instance;
                        db.OpenConnection();

                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Users(id,username,`password`) VALUES(@id, @username, @password)", db.Connection))
                        {
                            cmd.Parameters.AddWithValue("@id", user.getId() + 1);
                            cmd.Parameters.AddWithValue("@username", TxtboxUsername.Text);
                            cmd.Parameters.AddWithValue("@password", TxtboxPasswrd.Text);

                            cmd.ExecuteNonQuery();
                        }

                        Welcome form = new Welcome();
                        form.Dock = DockStyle.Fill;
                        form.TopLevel = false;
                        MainForm.MainPanel.Controls.Clear();
                        MainForm.MainPanel.Controls.Add(form);
                        form.Show();

                        db.CloseConnection();
                    }
                    catch
                    {
                        MessageBox.Show("Il y a une erreur dans la création du compte");
                    }
                }
            }
            if (check == false)
            {
                MessageBox.Show("Il y a une erreur dans la création du compte");
                TxtboxPasswrd.Clear();
                TxtboxPasswrdConfirm.Clear();
            }
            
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Welcome form = new Welcome();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
        }

    }
}
