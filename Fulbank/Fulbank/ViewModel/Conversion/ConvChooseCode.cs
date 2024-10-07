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

        public void AddAmount(int amounts)
        {
            if (_form.Lbl_AmountControl != null)
            {
                int currentAmount;
                if (int.TryParse(_form.Lbl_AmountControl.Text, out currentAmount))
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

        public void SupAmount(int amounts)
        {
            if (_form.Lbl_AmountControl != null)
            {
                int currentAmount;
                if (int.TryParse(_form.Lbl_AmountControl.Text, out currentAmount))
                {
                    int newAmount = currentAmount - amounts;
                    if (newAmount >= 0)
                    {
                        _form.Lbl_AmountControl.Text = newAmount.ToString();
                    }
                    else
                    {
                        // Gérer le cas où la nouvelle valeur serait inférieure à 0
                        newAmount = 0;
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
    }
}
