using Fulbank.View;

namespace Fulbank
{
    public partial class Welcome : Form
    {
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
            Form HP = new Form1();
            HP.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }
    }
}
