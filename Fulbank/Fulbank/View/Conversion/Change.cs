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
        public Change()
        {
            InitializeComponent();
        }

        private async Task UpdateLabelsBitcoin(decimal userInput, string wanted)
        {
            decimal price = await ApiUsage.Bitcoin(wanted);
            decimal eutobitcoin = 1 / price;
            lbl_SValue.Text = eutobitcoin.ToString("0.######");
            lbl_FValue2.Text = "1";
            lbl_SValue2.Text = price.ToString("0.######");
            lbl_TypeR.Text = "BTC";
            lbl_TypeR2.Text = "BTC";
            if (wanted == "eur")
            {
                lbl_TypeL.Text = "€";
                lbl_TypeL2.Text = "€";
            }
            else
            {
                lbl_TypeL.Text = "$";
                lbl_TypeL2.Text = "$";
            }


            // Utiliser la valeur entrée par l'utilisateur pour calculer et mettre à jour les labels
            decimal userValue = userInput;
            lbl_FValue.Text = userValue.ToString("0.######");
            // Par exemple, convertir l'input de l'utilisateur en bitcoin
            decimal convertedValue = userValue * eutobitcoin;
            lbl_SValue.Text = convertedValue.ToString("0.######"); // Ajouter un label pour afficher la valeur convertie
        }

        private async Task UpdateLabelsEth(decimal userInput, string wanted)
        {
            decimal price = await ApiUsage.Ethereum(wanted);
            decimal eutoEth = 1 / price;
            lbl_SValue.Text = eutoEth.ToString("0.######");
            lbl_FValue2.Text = "1";
            lbl_SValue2.Text = price.ToString("0.######");
            lbl_TypeR.Text = "Eth";
            lbl_TypeR2.Text = "Eth";
            if (wanted == "eur")
            {
                lbl_TypeL.Text = "€";
                lbl_TypeL2.Text = "€";
            }
            else
            {
                lbl_TypeL.Text = "$";
                lbl_TypeL2.Text = "$";
            }

            // Utiliser la valeur entrée par l'utilisateur pour calculer et mettre à jour les labels
            decimal userValue = userInput;
            lbl_FValue.Text = userValue.ToString("0.######");
            // Par exemple, convertir l'input de l'utilisateur en bitcoin
            decimal convertedValue = userValue * eutoEth;
            lbl_SValue.Text = convertedValue.ToString("0.######"); // Ajouter un label pour afficher la valeur convertie
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

        private async void Change_Load(object sender, EventArgs e)
        {
            await UpdateLabelsBitcoin(1, "eur");
        }

        private async void Btn_ChCurrency_Click(object sender, EventArgs e)
        {
            if (lbl_TypeL.Text == "€")
            {
                if (lbl_TypeR.Text == "BTC")
                {
                    await UpdateLabelsBitcoin(1, "usd");
                }
                else
                {
                    await UpdateLabelsEth(1, "usd");
                }
            }
            else
            {
                if (lbl_TypeR.Text == "BTC")
                {
                    await UpdateLabelsBitcoin(1, "eur");
                }
                else
                {
                    await UpdateLabelsEth(1, "eur");
                }
            }
        }

        private async void Btn_ChValue_Click(object sender, EventArgs e)
        {
            if (lbl_TypeR2.Text == "BTC")
            {
                if (lbl_TypeL.Text == "€")
                {
                    await UpdateLabelsEth(1, "eur");
                }
                else
                {
                    await UpdateLabelsEth(1, "usd");
                }
            }

            else
            {
                if (lbl_TypeL.Text == "€")
                {
                    await UpdateLabelsBitcoin(1, "eur");
                }
                else
                {
                    await UpdateLabelsBitcoin(1, "usd");
                }

            }
        }


    }
}
