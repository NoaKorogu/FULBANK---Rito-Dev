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
        public ChooseUser()
        {
            InitializeComponent();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            amount formV = new amount();
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
    }
}
