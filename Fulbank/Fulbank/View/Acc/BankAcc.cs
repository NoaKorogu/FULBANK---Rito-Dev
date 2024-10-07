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
    public partial class BankAcc : Form
    {
        public BankAcc()
        {
            InitializeComponent();
        }

        public void Btn_Leave_Click(object sender, EventArgs e)
        {
            FormHP formhp = new FormHP();
            formhp.Dock = DockStyle.Fill;
            formhp.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(formhp);
            formhp.Show();
        }


    }
}
