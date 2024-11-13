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

        public Conversion()
        {
            InitializeComponent();
        }

        private async Task UpdateLabels(decimal userInput)
        {
            decimal price = await ApiUsage.Bitcoin("eur");
            decimal eutobitcoin = 1 / price;

            // Utiliser la valeur entrée par l'utilisateur pour calculer et mettre à jour les labels
            decimal userValue = userInput;
            Lbl_M2.Text = userValue.ToString("0.######");
            // Par exemple, convertir l'input de l'utilisateur en bitcoin
            decimal convertedValue = userValue * eutobitcoin;
            Lbl_M2.Text = convertedValue.ToString("0.######"); // Ajouter un label pour afficher la valeur convertie
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
                    await UpdateLabels(userValue); // Utiliser await pour appeler UpdateLabels
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
