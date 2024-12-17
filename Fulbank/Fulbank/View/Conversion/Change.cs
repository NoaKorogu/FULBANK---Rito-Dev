using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fulbank.ViewModel;
using Newtonsoft.Json.Serialization;

namespace Fulbank.View
{
    public partial class Change : Form
    {
        private decimal priceBTCeur;
        private decimal priceBTCusd;
        private decimal priceETHeur;
        private decimal priceETHusd;

        public Change()
        {
            InitializeComponent();
            LoadPricesAsync(); // Appeler la méthode async dans le constructeur
        }

        private async Task LoadPricesAsync()
        {
            try
            {
                priceBTCeur = await ApiCache.GetCryptoPrice("bitcoin", "eur");
                await Task.Delay(1000); // Délai de 1 seconde
                priceBTCusd = await ApiCache.GetCryptoPrice("bitcoin", "usd");
                await Task.Delay(1000); // Délai de 1 seconde
                priceETHeur = await ApiCache.GetCryptoPrice("ethereum", "eur");
                await Task.Delay(1000); // Délai de 1 seconde
                priceETHusd = await ApiCache.GetCryptoPrice("ethereum", "usd");
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur de requête HTTP : {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void UpdateLabelsBitcoin(decimal userInput, string wanted)
        {
            decimal price = wanted == "eur" ? priceBTCeur : priceBTCusd;
            decimal eutobitcoin = 1 / price;
            lbl_SValue.Text = eutobitcoin.ToString("0.######");
            lbl_FValue2.Text = "1";
            lbl_SValue2.Text = price.ToString("0.######");
            lbl_TypeR.Text = "BTC";
            lbl_TypeR2.Text = "BTC";
            lbl_TypeL.Text = wanted == "eur" ? "€" : "$";
            lbl_TypeL2.Text = wanted == "eur" ? "€" : "$";

            decimal userValue = userInput;
            lbl_FValue.Text = userValue.ToString("0.######");
            decimal convertedValue = userValue * eutobitcoin;
            lbl_SValue.Text = convertedValue.ToString("0.######");
        }

        private void UpdateLabelsEth(decimal userInput, string wanted)
        {
            decimal price = wanted == "eur" ? priceETHeur : priceETHusd;
            decimal eutoEth = 1 / price;
            lbl_SValue.Text = eutoEth.ToString("0.######");
            lbl_FValue2.Text = "1";
            lbl_SValue2.Text = price.ToString("0.######");
            lbl_TypeR.Text = "Eth";
            lbl_TypeR2.Text = "Eth";
            lbl_TypeL.Text = wanted == "eur" ? "€" : "$";
            lbl_TypeL2.Text = wanted == "eur" ? "€" : "$";

            decimal userValue = userInput;
            lbl_FValue.Text = userValue.ToString("0.######");
            decimal convertedValue = userValue * eutoEth;
            lbl_SValue.Text = convertedValue.ToString("0.######");
        }

        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            string amountValue = "0"; // ou toute autre valeur par défaut
            string currencyValue = "eur"; // ou toute autre valeur par défaut

            Conversion conversation = new Conversion(amountValue, currencyValue);
            conversation.Dock = DockStyle.Fill;
            conversation.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversation);
            conversation.Show();
        }

        private async void Change_Load(object sender, EventArgs e)
        {
            await LoadPricesAsync(); // Charger les prix lors du chargement de la page
            UpdateLabelsBitcoin(1, "eur"); // Mettre à jour les labels après le chargement des prix
        }

        private void Btn_ChCurrency_Click(object sender, EventArgs e)
        {
            if (lbl_TypeL.Text == "€")
            {
                if (lbl_TypeR.Text == "BTC")
                {
                    UpdateLabelsBitcoin(1, "usd");
                }
                else
                {
                    UpdateLabelsEth(1, "usd");
                }
            }
            else
            {
                if (lbl_TypeR.Text == "BTC")
                {
                    UpdateLabelsBitcoin(1, "eur");
                }
                else
                {
                    UpdateLabelsEth(1, "eur");
                }
            }
        }

        private void Btn_ChValue_Click(object sender, EventArgs e)
        {
            if (lbl_TypeR2.Text == "BTC")
            {
                if (lbl_TypeL.Text == "€")
                {
                    UpdateLabelsEth(1, "eur");
                }
                else
                {
                    UpdateLabelsEth(1, "usd");
                }
            }
            else
            {
                if (lbl_TypeL.Text == "€")
                {
                    UpdateLabelsBitcoin(1, "eur");
                }
                else
                {
                    UpdateLabelsBitcoin(1, "usd");
                }
            }
        }
    }
}
