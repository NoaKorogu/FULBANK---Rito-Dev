using Microsoft.VisualBasic;
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
    public partial class Conversion : Form
    {
        public string AmountValue { get; set; }
        public Conversion()
        {
            InitializeComponent();
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            FormHP formhp = new FormHP();
            formhp.Dock = DockStyle.Fill;
            formhp.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(formhp);
            formhp.Show();
        }

        private void Btn_Tx_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Dock = DockStyle.Fill;
            change.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(change);
            change.Show();
        }

        private void Btn_Money_Click(object sender, EventArgs e)
        {
            ConvChoose cchoose = new ConvChoose();
            cchoose.Dock = DockStyle.Fill;
            cchoose.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(cchoose);
            cchoose.Show();
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            if (AmountValue != null)
            {
                Lbl_M1.Text = AmountValue;
            }
            else
            {
                Lbl_M1.Text = "0";
            }
        }

        private void Btn_Rev_Click(object sender, EventArgs e)
        {
            string temp = Lbl_Type1.Text;
            Lbl_Type1.Text = Lbl_Type2.Text;
            Lbl_Type2.Text = temp;
            temp = Lbl_M1.Text;
            Lbl_M1.Text = Lbl_M2.Text;
            Lbl_M2.Text = temp;

        }
    }
}
