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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            Conversion conversation = new Conversion();
            conversation.Dock = DockStyle.Fill;
            conversation.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversation);
            conversation.Show(); 
        }
    }
}
