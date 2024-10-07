namespace Fulbank.View
{
    public partial class Welcome : Form
    {
        public static Panel MainPanel;
        public Welcome()
        {
            InitializeComponent();
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.ForeColor = Color.White;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Dock = DockStyle.Fill;
            login.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(login);
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Dock = DockStyle.Fill;
            register.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(register);
            register.Show();
        }
    }
}
