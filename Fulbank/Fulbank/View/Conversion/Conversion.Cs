using Fulbank.ViewModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public string CurrencyValue { get; set; }
        public decimal priceBTCeur;
        public decimal priceBTCusd;
        public decimal priceETHeur;
        public decimal priceETHusd;

        public Conversion(string amountValue, string currencyValue)
        {
            InitializeComponent();
            AmountValue = amountValue;
            CurrencyValue = currencyValue;

            // Assurez-vous que la devise est bien propagée
            Lbl_Type1.Text = CurrencyValue;

            // Charger les prix en arrière-plan
            LoadPricesAsync();
        }


        private async Task LoadPricesAsync()
        {
            try
            {
                // Charger les prix pour chaque paire
                priceBTCeur = await ApiCache.GetCryptoPrice("bitcoin", "eur");
                priceBTCusd = await ApiCache.GetCryptoPrice("bitcoin", "usd");
                priceETHeur = await ApiCache.GetCryptoPrice("ethereum", "eur");
                priceETHusd = await ApiCache.GetCryptoPrice("ethereum", "usd");

                // Vérification des valeurs
                if (priceBTCeur <= 0 || priceBTCusd <= 0 || priceETHeur <= 0 || priceETHusd <= 0)
                {
                    throw new Exception("Le prix de la crypto est égal à zéro ou invalide.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Problème avec les prix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        //private void UpdateLabels(decimal userInput, string desire)
        //{
        //    decimal price;

        //    // Vérifiez la valeur d'entrée
        //    if (userInput <= 0)
        //    {
        //        MessageBox.Show("Erreur : La valeur d'entrée doit être supérieure à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Déterminer le prix selon la devise
        //    if (desire == "eur" || desire == "€")
        //    {
        //        price = priceBTCeur;
        //    }
        //    else if (desire == "usd" || desire == "$")
        //    {
        //        price = priceBTCusd;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Erreur : Devise inconnue pour la mise à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Vérifiez si le prix est valide
        //    if (price <= 0)
        //    {
        //        MessageBox.Show("Erreur : Le prix est égal ou inférieur à zéro. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Calcul de la valeur convertie
        //    decimal convertedValue = (desire == "usd") ? (userInput * price) : (userInput / price);
        //    Lbl_Type1.Text = (desire == "eur") ? "€" : "$"; // Met à jour le type de devise
        //    Lbl_Type2.Text = "BTC"; // Fixer la conversion à BTC
        //    Lbl_M2.Text = convertedValue.ToString("0.######");

        //    // Debugging
        //    Debug.WriteLine($"Converted {userInput} {Lbl_Type1.Text} to {convertedValue} {Lbl_Type2.Text} using price {price}");
        //}

        private void UpdateLabels(decimal userInput, string desire)
        {
            decimal price;

            // Vérifiez la valeur d'entrée
            if (userInput <= 0)
            {
                MessageBox.Show("Erreur : La valeur d'entrée doit être supérieure à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Déterminer le prix selon la devise
            if (desire == "eur" || desire == "€")
            {
                price = priceBTCeur; // Prix du BTC en euros
            }
            else if (desire == "usd" || desire == "$")
            {
                price = priceBTCusd; // Prix du BTC en dollars
            }
            else
            {
                MessageBox.Show("Erreur : Devise inconnue pour la mise à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifiez si le prix est valide
            if (price <= 0)
            {
                MessageBox.Show("Erreur : Le prix est égal ou inférieur à zéro. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal convertedValue;

            // Calcul de la valeur convertie selon la devise
            if (desire == "usd" || desire == "$") // Si on convertit des dollars en BTC
            {
                convertedValue = userInput / price; // On divise par le prix du BTC en dollars pour obtenir des BTC
            }
            else // Si on convertit des euros en BTC
            {
                convertedValue = userInput / price; // On divise par le prix du BTC en euros pour obtenir des BTC
            }

            // Met à jour les labels
            Lbl_Type1.Text = (desire == "eur") ? "€" : "$"; // Met à jour le type de devise
            Lbl_Type2.Text = "BTC"; // Fixer la conversion à BTC
            Lbl_M2.Text = convertedValue.ToString("0.######"); // Affiche le montant converti

            // Debugging
            Debug.WriteLine($"Converted {userInput} {Lbl_Type1.Text} to {convertedValue} {Lbl_Type2.Text} using price {price}");
        }









        //private void UpdateLabelsEth(decimal userInput, string desire)
        //{
        //    decimal price = desire == "eur" ? priceETHeur : priceETHusd;

        //    if (price == 0)
        //    {
        //        MessageBox.Show("Erreur : Le prix de l'ETH est introuvable ou égal à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    decimal convertedValue = desire == "eur" ? userInput / price : userInput * price; // Corrigez ici
        //    Lbl_Type2.Text = "ETH"; // On fixe la crypto-monnaie
        //    Lbl_Type1.Text = desire == "eur" ? "€" : "$"; // La devise devient secondaire
        //    Lbl_M2.Text = convertedValue.ToString("0.######");
        //}
        private void UpdateLabelsEth(decimal userInput, string desire)
        {
            decimal price = desire == "eur" ? priceETHeur : priceETHusd;

            if (price <= 0)
            {
                MessageBox.Show("Erreur : Le prix de l'ETH est introuvable ou égal à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal convertedValue = (desire == "usd") ? (userInput * price) : (userInput / price); // Correction ici
            Lbl_Type2.Text = "ETH"; // On fixe la crypto-monnaie
            Lbl_Type1.Text = (desire == "eur") ? "€" : "$"; // La devise devient secondaire
            Lbl_M2.Text = convertedValue.ToString("0.######");
        }





        public void UpdateLabelsFromConvChoose(string amount, string currency)
        {
            if (!decimal.TryParse(amount, out decimal userInput) || userInput <= 0)
            {
                MessageBox.Show("Erreur : Montant invalide ou négatif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price = 0;
            if (currency == "€/$")
                price = priceBTCeur;
            else if (currency == "Bitcoin")
                price = priceBTCeur;

            if (price == 0)
            {
                MessageBox.Show("Erreur : Le prix de la crypto est égal à zéro. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal convertedValue = currency == "€/$" ? userInput / price : userInput * price;
            Lbl_M2.Text = convertedValue.ToString("0.######") + (currency == "€/$" ? " BTC" : " €");
        }



        private void UpdateLabelsReverse(decimal userInput, string type)
        {
            decimal price;

            if (type == "eur" || type == "€")
                price = priceBTCeur;
            else if (type == "usd" || type == "$")
                price = priceBTCusd;
            else
            {
                MessageBox.Show("Erreur : Devise inconnue pour la mise à jour inversée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (price == 0)
            {
                MessageBox.Show("Erreur : Le prix de la crypto-monnaie est introuvable ou égal à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal convertedValue = userInput * price; // Cela doit rester en multipliant par le prix, correct
            Lbl_Type1.Text = "BTC"; // On fixe la crypto-monnaie
            Lbl_Type2.Text = type == "eur" ? "€" : "$"; // La devise devient secondaire
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

        //private async void Conversion_Load(object sender, EventArgs e)
        //{
        //    await LoadPricesAsync();

        //    if (!string.IsNullOrEmpty(CurrencyValue))
        //    {
        //        Lbl_Type1.Text = CurrencyValue == "Bitcoin" || CurrencyValue == "Ethereum" ? "€" : CurrencyValue;
        //    }
        //    else
        //    {
        //        Lbl_Type1.Text = "€"; // Par défaut
        //    }

        //    if (!string.IsNullOrEmpty(AmountValue))
        //    {
        //        Lbl_M1.Text = AmountValue;
        //        if (decimal.TryParse(AmountValue, out decimal userValue))
        //        {
        //            if (CurrencyValue == "Bitcoin")
        //            {
        //                UpdateLabels(userValue, "eur");
        //            }
        //            else if (CurrencyValue == "Ethereum")
        //            {
        //                UpdateLabelsEth(userValue, "eur");
        //            }
        //            else
        //            {
        //                UpdateLabels(userValue, Lbl_Type1.Text == "€" ? "eur" : "usd");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erreur : Valeur non valide pour AmountValue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        Lbl_M1.Text = "0"; // Par défaut
        //    }
        //}

        private async void Conversion_Load(object sender, EventArgs e)
        {
            await LoadPricesAsync();

            if (!string.IsNullOrEmpty(CurrencyValue))
            {
                // Assurez-vous que la devise est affichée correctement
                Lbl_Type1.Text = CurrencyValue == "Bitcoin" || CurrencyValue == "Ethereum" ? "€" : CurrencyValue;
            }
            else
            {
                Lbl_Type1.Text = "€"; // Par défaut
            }

            if (!string.IsNullOrEmpty(AmountValue))
            {
                Lbl_M1.Text = AmountValue;
                if (decimal.TryParse(AmountValue, out decimal userValue))
                {
                    // Convertir en fonction de la devise
                    if (CurrencyValue == "Bitcoin")
                    {
                        UpdateLabels(userValue, "eur"); // Conversion de Bitcoin en Euro
                    }
                    else if (CurrencyValue == "Ethereum")
                    {
                        UpdateLabelsEth(userValue, "eur"); // Conversion d'Ethereum en Euro
                    }
                    else
                    {
                        UpdateLabels(userValue, Lbl_Type1.Text == "€" ? "eur" : "usd"); // Conversion en fonction de la devise
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : Valeur non valide pour AmountValue.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Lbl_M1.Text = "0"; // Par défaut
            }
        }





        private void ChangeType()
        {
            // Validation de l'entrée utilisateur
            if (!decimal.TryParse(Lbl_M1.Text, out decimal userValue))
            {
                MessageBox.Show("Erreur : Valeur dans Lbl_M1.Text invalide ou vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Changement des labels et mise à jour dynamique
            if (Lbl_Type1.Text == "€")
            {
                Lbl_Type1.Text = "$";
                Lbl_Type2.Text = "BTC"; // Conversion en BTC
                UpdateLabels(userValue, "usd"); // Convertit 10 € en BTC
            }
            else if (Lbl_Type1.Text == "$")
            {
                Lbl_Type1.Text = "€";
                Lbl_Type2.Text = "BTC"; // Conversion en BTC
                UpdateLabels(userValue, "eur"); // Convertit 10 $ en BTC
            }
            else if (Lbl_Type1.Text == "BTC")
            {
                Lbl_Type1.Text = "ETH";
                Lbl_Type2.Text = "€"; // Conversion en EUR depuis ETH
                UpdateLabelsEth(userValue, "eur");
            }
            else if (Lbl_Type1.Text == "ETH")
            {
                Lbl_Type1.Text = "BTC";
                Lbl_Type2.Text = "$"; // Conversion en USD depuis BTC
                UpdateLabels(userValue, "usd");
            }
            else
            {
                MessageBox.Show($"Erreur : Type inconnu ({Lbl_Type1.Text}).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_Rev_Click(object sender, EventArgs e)
        {
            ChangeType();
        }

        private async void Btn_Change_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(Lbl_M1.Text, out decimal userValue))
            {
                MessageBox.Show("Erreur : Valeur dans Lbl_M1.Text invalide ou vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Lbl_Type1.Text == "BTC" || Lbl_Type1.Text == "ETH")
            {
                // Si la crypto est à gauche (Lbl_Type1)
                if (Lbl_Type1.Text == "BTC")
                {
                    Lbl_Type1.Text = "ETH";
                    UpdateLabelsEth(userValue, Lbl_Type2.Text == "€" ? "eur" : "usd");
                }
                else if (Lbl_Type1.Text == "ETH")
                {
                    Lbl_Type1.Text = "BTC";
                    UpdateLabels(userValue, Lbl_Type2.Text == "€" ? "eur" : "usd");
                }
            }
            else if (Lbl_Type2.Text == "BTC" || Lbl_Type2.Text == "ETH")
            {
                // Si la crypto est à droite (Lbl_Type2)
                if (Lbl_Type2.Text == "BTC")
                {
                    Lbl_Type2.Text = "ETH";
                    UpdateLabelsEth(userValue, Lbl_Type1.Text == "€" ? "eur" : "usd");
                }
                else if (Lbl_Type2.Text == "ETH")
                {
                    Lbl_Type2.Text = "BTC";
                    UpdateLabels(userValue, Lbl_Type1.Text == "€" ? "eur" : "usd");
                }
            }
            else
            {
                MessageBox.Show("Erreur : Aucune crypto-monnaie valide dans les labels.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LogLabels() //Pour des logs temporaires
        {
            MessageBox.Show($"Lbl_Type1: {Lbl_Type1.Text}, Lbl_Type2: {Lbl_Type2.Text}", "Debug Info");
        }
    }
}
