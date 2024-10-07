namespace Fulbank.View

{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Btn_Valid.FlatStyle = FlatStyle.Flat;
            Btn_Valid.FlatAppearance.BorderSize = 0;
            Btn_Cancel .FlatStyle = FlatStyle.Flat;
            Btn_Cancel.FlatAppearance.BorderSize = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            FormHP form = new FormHP();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();

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
