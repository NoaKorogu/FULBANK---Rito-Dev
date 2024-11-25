using Fulbank.ViewModel;
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
        public decimal priceBTCeur;
        public decimal priceBTCusd;
        public decimal priceETHeur;
        public decimal priceETHusd;

        public Conversion()
        {
            InitializeComponent();
            LoadPricesAsync(); // Appeler la méthode async dans le constructeur
        }

        private async Task LoadPricesAsync()
        {
            priceBTCeur = await ApiCache.GetCryptoPrice("bitcoin", "eur");
            priceBTCusd = await ApiCache.GetCryptoPrice("bitcoin", "usd");
            priceETHeur = await ApiCache.GetCryptoPrice("ethereum", "eur");
            priceETHusd = await ApiCache.GetCryptoPrice("ethereum", "usd");
        }


        private async Task UpdateLabels(decimal userInput, string desire)
        {
            decimal price = desire == "eur" ? priceBTCeur : priceBTCusd;
            decimal eutoBitcoin = 1 / price;
            decimal userValue = userInput;

            Lbl_M2.Text = eutoBitcoin.ToString("0.######");
            Lbl_Type2.Text = "BTC";
            Lbl_Type1.Text = desire == "eur" ? "€" : "$";

            decimal convertedValue = userValue * eutoBitcoin;
            Lbl_M2.Text = convertedValue.ToString("0.######");
        }

        private async Task UpdateLabelsEth(decimal userInput, string desire)
        {
            decimal price = desire == "eur" ? priceETHeur : priceETHusd;
            decimal eutoEth = 1 / price;
            decimal userValue = userInput;

            Lbl_Type2.Text = "Eth";
            Lbl_Type1.Text = desire == "eur" ? "€" : "$";

            decimal convertedValue = userValue * eutoEth;
            Lbl_M2.Text = convertedValue.ToString("0.######");
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

        private async void Conversion_Load(object sender, EventArgs e) // Marquer la méthode comme async
        {
            if (AmountValue != null)
            {
                Lbl_M1.Text = AmountValue;
                if (decimal.TryParse(AmountValue, out decimal userValue))
                {
                    await UpdateLabels(userValue, "eur"); // Utiliser await pour appeler UpdateLabels
                }
                else
                {
                    MessageBox.Show("Erreur: Valeur non valide.");
                }
            }
            else
            {
                Lbl_M1.Text = "0";
            }
        }

        private async void Btn_Rev_Click(object sender, EventArgs e)
        {
            decimal userValue = decimal.Parse(Lbl_M1.Text);
            if (Lbl_Type2.Text == "BTC")
            {
                if(Lbl_Type1.Text == "€")
                {
                    await UpdateLabels(userValue, "usd");
                }
                else
                {
                    await UpdateLabels(userValue, "eur");
                }
            }
            else 
            {
                if(Lbl_Type1.Text == "€")
                {
                    await UpdateLabelsEth(userValue, "usd");
                }
                else
                {
                    await UpdateLabelsEth(userValue, "eur");
                }
            }
        }

        private async void Btn_Change_Click(object sender, EventArgs e)
        {
            decimal userValue = decimal.Parse(Lbl_M1.Text);

            if (Lbl_Type1.Text == "€")
            {
                if (Lbl_Type2.Text == "BTC")
                {
                    await UpdateLabelsEth(userValue, "eur");
                }
                else
                {
                    await UpdateLabels(userValue, "eur");
                }
            }
            else
            {
                if (Lbl_Type2.Text == "BTC")
                {
                    await UpdateLabelsEth(userValue, "usd");
                }
                else
                {
                    await UpdateLabels(userValue, "usd");
                }
            }
        }
    }
}
