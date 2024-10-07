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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Valid_Click(object sender, EventArgs e)
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
            Welcome form = new Welcome();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
        }
    }
}
