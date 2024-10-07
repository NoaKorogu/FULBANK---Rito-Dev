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
    public partial class amount : Form
    {
        public amount()
        {
            InitializeComponent();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            FormHP formHP = new FormHP();
            formHP.Dock = DockStyle.Fill;
            formHP.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(formHP);
            formHP.Show();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
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
