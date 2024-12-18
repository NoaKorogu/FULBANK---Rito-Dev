namespace Fulbank.View
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Add5 = new Button();
            Btn_Add10 = new Button();
            Btn_Add100 = new Button();
            Btn_Cancel = new Button();
            Btn_Valid = new Button();
            Btn_Rmv100 = new Button();
            Btn_Rmv10 = new Button();
            Btn_Rmv5 = new Button();
            Lbl_Ammount = new Label();
            SuspendLayout();
            // 
            // Btn_Add5
            // 
            Btn_Add5.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Add5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Add5.Location = new Point(12, 35);
            Btn_Add5.Name = "Btn_Add5";
            Btn_Add5.Size = new Size(250, 100);
            Btn_Add5.TabIndex = 0;
            Btn_Add5.Text = "Ajout 5 euros";
            Btn_Add5.UseVisualStyleBackColor = false;
            Btn_Add5.Click += Btn_Add5_Click;
            // 
            // Btn_Add10
            // 
            Btn_Add10.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Add10.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Add10.Location = new Point(12, 205);
            Btn_Add10.Name = "Btn_Add10";
            Btn_Add10.Size = new Size(250, 100);
            Btn_Add10.TabIndex = 1;
            Btn_Add10.Text = "Ajout 10 euros";
            Btn_Add10.UseVisualStyleBackColor = false;
            Btn_Add10.Click += Btn_Add10_Click;
            // 
            // Btn_Add100
            // 
            Btn_Add100.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Add100.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Add100.Location = new Point(12, 375);
            Btn_Add100.Name = "Btn_Add100";
            Btn_Add100.Size = new Size(250, 100);
            Btn_Add100.TabIndex = 2;
            Btn_Add100.Text = "Ajout 100 euros";
            Btn_Add100.UseVisualStyleBackColor = false;
            Btn_Add100.Click += Btn_Add100_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Cancel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Cancel.Location = new Point(12, 545);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(250, 100);
            Btn_Cancel.TabIndex = 3;
            Btn_Cancel.Text = "Annuler";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Btn_Valid
            // 
            Btn_Valid.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Valid.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Valid.Location = new Point(735, 545);
            Btn_Valid.Name = "Btn_Valid";
            Btn_Valid.Size = new Size(250, 100);
            Btn_Valid.TabIndex = 7;
            Btn_Valid.Text = "Confirmer";
            Btn_Valid.UseVisualStyleBackColor = false;
            Btn_Valid.Click += Btn_Valid_Click;
            // 
            // Btn_Rmv100
            // 
            Btn_Rmv100.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Rmv100.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Rmv100.Location = new Point(735, 375);
            Btn_Rmv100.Name = "Btn_Rmv100";
            Btn_Rmv100.Size = new Size(250, 100);
            Btn_Rmv100.TabIndex = 6;
            Btn_Rmv100.Text = "Enlever 100 euros";
            Btn_Rmv100.UseVisualStyleBackColor = false;
            Btn_Rmv100.Click += Btn_Rmv100_Click;
            // 
            // Btn_Rmv10
            // 
            Btn_Rmv10.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Rmv10.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Rmv10.Location = new Point(735, 205);
            Btn_Rmv10.Name = "Btn_Rmv10";
            Btn_Rmv10.Size = new Size(250, 100);
            Btn_Rmv10.TabIndex = 5;
            Btn_Rmv10.Text = "Enlever 10 euros";
            Btn_Rmv10.UseVisualStyleBackColor = false;
            Btn_Rmv10.Click += Btn_Rmv10_Click;
            // 
            // Btn_Rmv5
            // 
            Btn_Rmv5.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Rmv5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Rmv5.Location = new Point(735, 35);
            Btn_Rmv5.Name = "Btn_Rmv5";
            Btn_Rmv5.Size = new Size(250, 100);
            Btn_Rmv5.TabIndex = 4;
            Btn_Rmv5.Text = "Enlever 5 euros";
            Btn_Rmv5.UseVisualStyleBackColor = false;
            Btn_Rmv5.Click += Btn_Rmv5_Click;
            // 
            // Lbl_Ammount
            // 
            Lbl_Ammount.AutoSize = true;
            Lbl_Ammount.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Ammount.Location = new Point(445, 72);
            Lbl_Ammount.Name = "Lbl_Ammount";
            Lbl_Ammount.Size = new Size(103, 29);
            Lbl_Ammount.TabIndex = 8;
            Lbl_Ammount.Text = "000.00 €";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(Lbl_Ammount);
            Controls.Add(Btn_Valid);
            Controls.Add(Btn_Rmv100);
            Controls.Add(Btn_Rmv10);
            Controls.Add(Btn_Rmv5);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Add100);
            Controls.Add(Btn_Add10);
            Controls.Add(Btn_Add5);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Add5;
        private Button Btn_Add10;
        private Button Btn_Add100;
        private Button Btn_Cancel;
        private Button Btn_Valid;
        private Button Btn_Rmv100;
        private Button Btn_Rmv10;
        private Button Btn_Rmv5;
        private Label Lbl_Ammount;
    }
}