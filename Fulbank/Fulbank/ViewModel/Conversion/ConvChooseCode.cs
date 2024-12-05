using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace Fulbank.ViewModel.Conversion
{
    internal class ConvChooseCode
    {
        private ConvChoose _form;

        public ConvChooseCode(ConvChoose form)
        {
            _form = form;

        }

        public void AddAmount(decimal amounts)
        {
            if (_form.Lbl_AmountControl != null)
            {
                decimal currentAmount;
                if (decimal.TryParse(_form.Lbl_AmountControl.Text, out currentAmount))
                {
                    _form.Lbl_AmountControl.Text = (currentAmount + amounts).ToString();
                }
                else
                {
                    // Gérer le cas où la conversion échoue
                    MessageBox.Show("Le format de Lbl_AmountControl.Text n'est pas valide.");
                }
            }
            else
            {
                // Gérer le cas où Lbl_AmountControl est null
                MessageBox.Show("Lbl_AmountControl n'est pas initialisé.");
            }
        }

        public void SupAmount(decimal amounts)
        {
            if (_form.Lbl_AmountControl != null)
            {
                decimal currentAmount;
                if (decimal.TryParse(_form.Lbl_AmountControl.Text, out currentAmount))
                {
                    decimal newAmount = currentAmount - amounts;
                    if (newAmount >= 0)
                    {
                        _form.Lbl_AmountControl.Text = newAmount.ToString();
                    }
                    else
                    {
                        // Gérer le cas où la nouvelle valeur serait inférieure à 0
                        newAmount = 0.0m;
                        _form.Lbl_AmountControl.Text = newAmount.ToString();
                    }
                }
                else
                {
                    // Gérer le cas où la conversion échoue
                    MessageBox.Show("Le format de Lbl_AmountControl.Text n'est pas valide.");
                }
            }
            else
            {
                // Gérer le cas où Lbl_AmountControl est null
                MessageBox.Show("Lbl_AmountControl n'est pas initialisé.");
            }
        }
        public void AddAmountFromTextBox(string amountText)
        {
            if (decimal.TryParse(amountText, out decimal amounts))
            {
                AddAmount(amounts);
            }
            else
            {
                MessageBox.Show("Le format de la valeur ajoutée n'est pas valide.");
            }
        }

        public void SupAmountFromTextBox(string amountText)
        {
            decimal.TryParse(amountText, out decimal amounts);
            SupAmount(amounts);
        }

    }
}
