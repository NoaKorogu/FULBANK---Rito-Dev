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
            Lbl_Amount.Text = "0.0";
            Lbl_AmountControl.Text = "0";

            if (Lbl_Euro.Text == "€/$")
            {
                Lbl_Euro.Text = "Bitcoin";
                Btn_Cancel.Text = "Passer en monnaie";
                Btn_Rmv10.Text = "Changer de crypto";
                Btn_Add1.Text = "Ajout 0,01";
                Btn_Add10.Text = "Ajout 0,1";
                Btn_Rmv1.Text = "Enlever 0,01";
            }
            else
            {
                Lbl_Euro.Text = "€/$";
                Btn_Cancel.Text = "Passer en crypto";
                Btn_Rmv10.Text = "Enlever 10 €/$";
                Btn_Add1.Text = "Ajout 1 €/$";
                Btn_Add10.Text = "Ajout 10 €/$";
                Btn_Rmv1.Text = "Enlever 1 €/$";
            }
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs saisies
            string theValue = Lbl_Amount.Text;
            string currencyValue = Lbl_Euro.Text;

            // Validation des données saisies
            if (string.IsNullOrEmpty(theValue) || !decimal.TryParse(theValue, out decimal userInput) || userInput <= 0)
            {
                MessageBox.Show("Erreur : Veuillez entrer un montant valide supérieur à 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(currencyValue))
            {
                MessageBox.Show("Erreur : Veuillez sélectionner une devise.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Création de la fenêtre Conversion
            Conversion conversion2 = new Conversion(theValue, currencyValue);
            conversion2.Dock = DockStyle.Fill;
            conversion2.TopLevel = false;

            // Mise à jour des labels avec gestion des erreurs
            try
            {
                conversion2.UpdateLabelsFromConvChoose(theValue, currencyValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Affichage de la fenêtre Conversion
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(conversion2);
            conversion2.Show();
        }


        private void Lbl_Amount_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Add1_Click(object sender, EventArgs e)
        {
            if (Btn_Add1.Text == "Ajout 1 €/$")
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.AddAmount(1);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }
            else
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.AddAmount(0.01m);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }

        }

        private void Btn_Add10_Click(object sender, EventArgs e)
        {
            if (Btn_Add10.Text == "Ajout 10 €/$")
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.AddAmount(10);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }
            else
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.AddAmount(0.1m);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }
        }

        private void Btn_Add100_Click(object sender, EventArgs e)
        {
            if (TxtBx_MoneyAdd.Visible == true)
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.AddAmountFromTextBox(TxtBx_MoneyAdd.Text);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
                TxtBx_MoneyAdd.Visible = false;
            }
            else
            {
                TxtBx_MoneyAdd.Text = "";
                TxtBx_MoneyAdd.Visible = true;
            };
        }

        private void Btn_Rmv1_Click(object sender, EventArgs e)
        {
            if (Btn_Rmv1.Text == "Enlever 1 €/$")
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.SupAmount(1);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }
            else
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.SupAmount(0.01m);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }
        }

        private void Btn_Rmv10_Click(object sender, EventArgs e)
        {
            if (Btn_Rmv10.Text == "Enlever 10 €/$")
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.SupAmount(10);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
            }
            else
            {
                if (Lbl_Euro.Text == "Bitcoin")
                {
                    Lbl_Euro.Text = "Ethereum";
                }
                else
                {
                    Lbl_Euro.Text = "Bitcoin";
                }
            }
        }

        private void Btn_Rmv100_Click(object sender, EventArgs e)
        {
            if (TxtBx_MoneySupp.Visible == true)
            {
                ConvChooseCode convChooseCode = new ConvChooseCode(this);
                convChooseCode.SupAmountFromTextBox(TxtBx_MoneySupp.Text);
                Lbl_Amount.Text = Lbl_AmountControl.Text;
                TxtBx_MoneySupp.Visible = false;
            }
            else
            {
                TxtBx_MoneySupp.Text = "";
                TxtBx_MoneySupp.Visible = true;
            };
        }

        private void ConvChoose_Load(object sender, EventArgs e)
        {
            TxtBx_MoneySupp.Visible = false;
            TxtBx_MoneyAdd.Visible = false;
        }
    }
}
