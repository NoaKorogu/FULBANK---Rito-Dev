using Fulbank.View.Acc;
using Fulbank.View.transfer;
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
    public partial class FormHP : Form
    {
        public FormHP()
        {
            InitializeComponent();
        }

        private void FormHP_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Withdraw_Click(object sender, EventArgs e)
        {
            Withdraw form = new Withdraw();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form);
            form.Show();
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
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
            string amountValue = "0";
            string currencyValue = "eur";
            Conversion conversation = new Conversion(amountValue, currencyValue);
            conversation.Dock = DockStyle.Fill;
            conversation.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversation);
            conversation.Show();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void Btn_BAcc_Click(object sender, EventArgs e)
        {
            BankAcc bankacc = new BankAcc();
            bankacc.Dock = DockStyle.Fill;
            bankacc.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(bankacc);
            bankacc.Show();
        }

        private void Btn_CAcc_Click(object sender, EventArgs e)
        {
            CryptoAcc cryptoacc = new CryptoAcc();
            cryptoacc.Dock = DockStyle.Fill;
            cryptoacc.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(cryptoacc);
            cryptoacc.Show();
        }

        private void Btn_Payment_Click(object sender, EventArgs e)
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
