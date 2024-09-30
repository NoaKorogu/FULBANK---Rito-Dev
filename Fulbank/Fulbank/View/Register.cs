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
            Form form = new FormHP();
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

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
