using Fulbank.Model;
using MySqlConnector;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fulbank.View.transfer
{
    public partial class amount : Form
    {
        public string beneficiary_name { get; set; }
        int beneficiary_id = 0;
        int userId = SessionManager.CurrentUser;
        string Sender = SessionManager.CurrentUserName;
        float ammount = 0;
        float currentAmmount = 0;
        public amount()
        {
            InitializeComponent();
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (currentAmmount >= ammount)
            {
                try
                {
                    Singleton db = Singleton.Instance;
                    db.OpenConnection();

                    using (MySqlCommand cmd = new MySqlCommand
                    (
                        "START TRANSACTION;" +
                        "UPDATE `Account` SET balance = balance - @ammount WHERE idHolder = @currentUser and idCurrency = 1;" +
                        "UPDATE `Account` SET balance = balance + @ammount WHERE idHolder = @beneficiaryId and idCurrency = 1;" +
                        "INSERT INTO Operation(account1, account2, amount1, exchangeRate, idAction, _date, idUser, idTerminal)" +
                        "VALUES ((SELECT id FROM Account WHERE idHolder = @currentUser AND idCurrency = 1)," +
                        "(SELECT id FROM Account WHERE idHolder = @beneficiaryId AND idCurrency = 1)," +
                        "@ammount, 1, 3, NOW(), @currentUser, 1);" +
                        "COMMIT;", db.Connection)
                    )
                    {
                        cmd.Parameters.AddWithValue("@ammount", ammount);
                        cmd.Parameters.AddWithValue("@currentUser", userId);
                        cmd.Parameters.AddWithValue("@beneficiaryId", beneficiary_id);

                        cmd.ExecuteNonQuery();
                    }
                    db.CloseConnection();

                    GenerateTransferReceipt();

                    FormHP formHP = new FormHP();
                    formHP.Dock = DockStyle.Fill;
                    formHP.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(formHP);
                    formHP.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur: {ex.Message}");
                }
            }
            else
            {
                ammount = 0;
                Lbl_Ammount.Text = ammount.ToString() + " €";
                MessageBox.Show("Vous ne pouvez pas faire un virement de cette somme !");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ChooseUser paymentTransfer = new ChooseUser();
            paymentTransfer.Dock = DockStyle.Fill;
            paymentTransfer.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(paymentTransfer);
            paymentTransfer.Show();
        }

        private void loadMoney()
        {
            try
            {

                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT balance FROM `Account` WHERE idHolder=@userID and idCurrency=1", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        currentAmmount = Convert.ToSingle(row["balance"]);
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private void amount_Load(object sender, EventArgs e)
        {
            loadMoney();
            Lbl_Beneficiary.Text = "Virement vers :\n" + beneficiary_name;
            try
            {
                Singleton db = Singleton.Instance;
                db.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM Users WHERE username = @beneficiary;", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@beneficiary", beneficiary_name);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        beneficiary_id = Convert.ToInt32(result); // Stocke l'ID dans beneficiary_id
                    }
                    else
                    {
                        MessageBox.Show("Le resultat est null");
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private void Btn_Add1_Click(object sender, EventArgs e)
        {
            if (currentAmmount >= 1)
            {
                ammount += 1;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vou ne pouvez pas faire un virement de cette somme");
            }
        }

        private void Btn_Add10_Click(object sender, EventArgs e)
        {
            if (currentAmmount >= 10)
            {
                ammount += 10;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vou ne pouvez pas faire un virement de cette somme");
            }
        }

        private void Btn_Add100_Click(object sender, EventArgs e)
        {
            if (currentAmmount >= 100)
            {
                ammount += 100;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vou ne pouvez pas faire un virement de cette somme");
            }
        }

        private void Btn_Rmv1_Click(object sender, EventArgs e)
        {
            if (ammount >= 1)
            {
                ammount -= 1;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas faire un virement de cette somme !");
            }
        }

        private void Btn_Rmv10_Click(object sender, EventArgs e)
        {
            if (ammount >= 10)
            {
                ammount -= 10;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas faire un virement de cette somme !");
            }
        }

        private void Btn_Rmv100_Click(object sender, EventArgs e)
        {
            if (ammount >= 100)
            {
                ammount -= 100;
                Lbl_Ammount.Text = ammount.ToString() + " €";
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas faire un virement de cette somme !");
            }
        }

        private void GenerateTransferReceipt()
        {
            try
            {

                // Définir les informations du reçu
                string action = "Virement";
                string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                string montant = ammount.ToString() + " €";
                string debiteur = Sender;
                string beneficiaire = beneficiary_name;


                // Générer le fichier PDF avec QuestPDF
                string outputPath = $"D:/Guignolle/RitoDevs/Fulbank/Recus/Recu_{DateTime.Now:ddMMyyyy_HHmmss}.pdf";

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.DefaultTextStyle(x => x.FontSize(12).FontColor(Colors.Black));

                        page.Content()
                            .Column(column =>
                            {
                                column.Item().Text("Fulbank").FontSize(18).Bold().AlignCenter();
                                column.Item().Text("----------------------------").AlignCenter();
                                column.Item().Text($"Action : {action}").FontSize(14);
                                column.Item().Text($"Date : {date}").FontSize(14);

                                column.Item().Text($"Montant : {montant}").FontSize(14).Bold();
                                column.Item().PaddingVertical(10).Text("----------------------------");

                                column.Item().Text($"Débiteur : {debiteur}").FontSize(14);
                                column.Item().Text($"Bénéficiaire : {beneficiaire}").FontSize(14);
                                column.Item().Text("----------------------------").AlignCenter();
                            });
                    });
                });

                // Enregistrer le PDF ACTUELLEMENT ne fonctionne pas
                document.GeneratePdf(outputPath);
                MessageBox.Show("PDF enregistré avec succès");

                // Afficher un aperçu et demander confirmation
                string previewMessage = $"Prévisualisation du Reçu :\n\n" +
                        $"----------------------------\n" +
                        $"   Fulbank\n" +
                        $"----------------------------\n" +
                        $"  Action : {action}\n" +
                        $"  Date : {date}\n\n" +
                        $"  Montant : {montant}\n" +
                        $"-----------------------------\n" +
                        $"  Débiteur : {debiteur}\n" +
                        $"  Bénéficiaire : {beneficiaire}\n" +
                        $"----------------------------\n\n" +
                        "Voulez-vous imprimer ce reçu ?";

                var result = MessageBox.Show(previewMessage, "Confirmation d'impression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PrintReceipt(outputPath);
                    MessageBox.Show("Le reçu a été imprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Impression annulée.", "Annulé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération du reçu : {ex.Message}\n{ex.StackTrace}");
            }
        }


        private void PrintReceipt(string documentPath)
        {
            try
            {
                // Utiliser Edge pour imprimer
                Process printProcess = new Process();
                printProcess.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                printProcess.StartInfo.Arguments = $"/print \"{documentPath}\""; // Argument pour imprimer un fichier PDF
                //printProcess.StartInfo.CreateNoWindow = true;
                printProcess.StartInfo.UseShellExecute = true;

                printProcess.Start();
                printProcess.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'impression : {ex.Message}");
            }
        }
    }
}