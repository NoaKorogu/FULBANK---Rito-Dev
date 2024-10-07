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
    public partial class ConvChoose : Form
    {
        public ConvChoose()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Conversion conversion = new Conversion();
            conversion.Dock = DockStyle.Fill;
            conversion.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversion);
            conversion.Show();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            Conversion conversion2 = new Conversion();
            conversion2.Dock = DockStyle.Fill;
            conversion2.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversion2);
            conversion2.Show();
        }
    }
}
