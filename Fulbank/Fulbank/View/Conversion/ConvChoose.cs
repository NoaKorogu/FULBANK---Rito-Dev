using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fulbank.ViewModel.Conversion;

namespace Fulbank.View
{
    public partial class ConvChoose : Form
    {

        public ConvChoose()
        {
            InitializeComponent();
            Lbl_AmountControl = new Label();
            Lbl_AmountControl.Text = "0";
        }
        public Label Lbl_AmountControl { get; set; }

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
            string TheValue = Lbl_Amount.Text;
            Conversion conversion2 = new Conversion();
            conversion2.AmountValue = TheValue;
            conversion2.Dock = DockStyle.Fill;
            conversion2.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversion2);
            conversion2.Show();
        }

        private void Lbl_Amount_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Add1_Click(object sender, EventArgs e)
        {
            ConvChooseCode convChooseCode = new ConvChooseCode(this);
            convChooseCode.AddAmount(1);
            Lbl_Amount.Text = Lbl_AmountControl.Text;
        }

        private void Btn_Add10_Click(object sender, EventArgs e)
        {
            ConvChooseCode convChooseCode = new ConvChooseCode(this);
            convChooseCode.AddAmount(10);
            Lbl_Amount.Text = Lbl_AmountControl.Text;
        }

        private void Btn_Add100_Click(object sender, EventArgs e)
        {
            ConvChooseCode convChooseCode = new ConvChooseCode(this);
            convChooseCode.AddAmount(100);
            Lbl_Amount.Text = Lbl_AmountControl.Text;
        }

        private void Btn_Rmv1_Click(object sender, EventArgs e)
        {
            ConvChooseCode convChooseCode = new ConvChooseCode(this);
            convChooseCode.SupAmount(1);
            Lbl_Amount.Text = Lbl_AmountControl.Text;
        }

        private void Btn_Rmv10_Click(object sender, EventArgs e)
        {
            ConvChooseCode convChooseCode = new ConvChooseCode(this);
            convChooseCode.SupAmount(10);
            Lbl_Amount.Text = Lbl_AmountControl.Text;
        }

        private void Btn_Rmv100_Click(object sender, EventArgs e)
        {
            ConvChooseCode convChooseCode = new ConvChooseCode(this);
            convChooseCode.SupAmount(100);
            Lbl_Amount.Text = Lbl_AmountControl.Text;
        }
    }
}
