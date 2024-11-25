namespace Fulbank.View
{
    partial class Conversion
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
            Btn_Leave = new Button();
            Btn_Valid = new Button();
            Btn_Tx = new Button();
            Btn_Money = new Button();
            Btn_Rev = new Button();
            Btn_Change = new Button();
            Lbl_M1 = new Label();
            Lbl_Arrow = new Label();
            Lbl_M2 = new Label();
            Lbl_Title = new Label();
            Lbl_Type1 = new Label();
            Lbl_Type2 = new Label();
            SuspendLayout();
            // 
            // Btn_Leave
            // 
            Btn_Leave.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Leave.BackgroundImageLayout = ImageLayout.None;
            Btn_Leave.FlatStyle = FlatStyle.Flat;
            Btn_Leave.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Leave.ForeColor = Color.White;
            Btn_Leave.Location = new Point(12, 545);
            Btn_Leave.Name = "Btn_Leave";
            Btn_Leave.Size = new Size(250, 100);
            Btn_Leave.TabIndex = 3;
            Btn_Leave.Text = "Quitter";
            Btn_Leave.UseVisualStyleBackColor = false;
            Btn_Leave.Click += Btn_Leave_Click;
            // 
            // Btn_Valid
            // 
            Btn_Valid.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Valid.BackgroundImageLayout = ImageLayout.None;
            Btn_Valid.FlatStyle = FlatStyle.Flat;
            Btn_Valid.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Valid.ForeColor = Color.White;
            Btn_Valid.Location = new Point(762, 545);
            Btn_Valid.Name = "Btn_Valid";
            Btn_Valid.Size = new Size(250, 100);
            Btn_Valid.TabIndex = 4;
            Btn_Valid.Text = "Valider";
            Btn_Valid.UseVisualStyleBackColor = false;
            // 
            // Btn_Tx
            // 
            Btn_Tx.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Tx.BackgroundImageLayout = ImageLayout.None;
            Btn_Tx.FlatStyle = FlatStyle.Flat;
            Btn_Tx.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Tx.ForeColor = Color.White;
            Btn_Tx.Location = new Point(762, 375);
            Btn_Tx.Name = "Btn_Tx";
            Btn_Tx.Size = new Size(250, 100);
            Btn_Tx.TabIndex = 5;
            Btn_Tx.Text = "Regarder le taux";
            Btn_Tx.UseVisualStyleBackColor = false;
            Btn_Tx.Click += Btn_Tx_Click;
            // 
            // Btn_Money
            // 
            Btn_Money.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Money.BackgroundImageLayout = ImageLayout.None;
            Btn_Money.FlatStyle = FlatStyle.Flat;
            Btn_Money.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Money.ForeColor = Color.White;
            Btn_Money.Location = new Point(12, 375);
            Btn_Money.Name = "Btn_Money";
            Btn_Money.Size = new Size(250, 100);
            Btn_Money.TabIndex = 6;
            Btn_Money.Text = "Choisir la somme";
            Btn_Money.UseVisualStyleBackColor = false;
            Btn_Money.Click += Btn_Money_Click;
            // 
            // Btn_Rev
            // 
            Btn_Rev.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Rev.BackgroundImageLayout = ImageLayout.None;
            Btn_Rev.FlatStyle = FlatStyle.Flat;
            Btn_Rev.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Rev.ForeColor = Color.White;
            Btn_Rev.Location = new Point(762, 205);
            Btn_Rev.Name = "Btn_Rev";
            Btn_Rev.Size = new Size(250, 100);
            Btn_Rev.TabIndex = 7;
            Btn_Rev.Text = "Changer la monnaie";
            Btn_Rev.UseVisualStyleBackColor = false;
            Btn_Rev.Click += Btn_Rev_Click;
            // 
            // Btn_Change
            // 
            Btn_Change.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Change.BackgroundImageLayout = ImageLayout.None;
            Btn_Change.FlatStyle = FlatStyle.Flat;
            Btn_Change.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Change.ForeColor = Color.White;
            Btn_Change.Location = new Point(12, 205);
            Btn_Change.Name = "Btn_Change";
            Btn_Change.Size = new Size(250, 100);
            Btn_Change.TabIndex = 8;
            Btn_Change.Text = "Changer la crypto";
            Btn_Change.UseVisualStyleBackColor = false;
            Btn_Change.Click += Btn_Change_Click;
            // 
            // Lbl_M1
            // 
            Lbl_M1.AutoSize = true;
            Lbl_M1.ForeColor = Color.White;
            Lbl_M1.Location = new Point(157, 91);
            Lbl_M1.Name = "Lbl_M1";
            Lbl_M1.Size = new Size(32, 36);
            Lbl_M1.TabIndex = 9;
            Lbl_M1.Text = "0";
            // 
            // Lbl_Arrow
            // 
            Lbl_Arrow.AutoSize = true;
            Lbl_Arrow.ForeColor = Color.White;
            Lbl_Arrow.Location = new Point(497, 91);
            Lbl_Arrow.Name = "Lbl_Arrow";
            Lbl_Arrow.Size = new Size(42, 36);
            Lbl_Arrow.TabIndex = 10;
            Lbl_Arrow.Text = "->";
            // 
            // Lbl_M2
            // 
            Lbl_M2.AutoSize = true;
            Lbl_M2.ForeColor = Color.White;
            Lbl_M2.Location = new Point(717, 91);
            Lbl_M2.Name = "Lbl_M2";
            Lbl_M2.Size = new Size(32, 36);
            Lbl_M2.TabIndex = 11;
            Lbl_M2.Text = "0";
            // 
            // Lbl_Title
            // 
            Lbl_Title.AutoSize = true;
            Lbl_Title.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Title.ForeColor = Color.White;
            Lbl_Title.Location = new Point(419, 35);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new Size(208, 42);
            Lbl_Title.TabIndex = 12;
            Lbl_Title.Text = "Conversion";
            // 
            // Lbl_Type1
            // 
            Lbl_Type1.AutoSize = true;
            Lbl_Type1.ForeColor = Color.White;
            Lbl_Type1.Location = new Point(308, 91);
            Lbl_Type1.Name = "Lbl_Type1";
            Lbl_Type1.Size = new Size(32, 36);
            Lbl_Type1.TabIndex = 13;
            Lbl_Type1.Text = "€";
            // 
            // Lbl_Type2
            // 
            Lbl_Type2.AutoSize = true;
            Lbl_Type2.ForeColor = Color.White;
            Lbl_Type2.Location = new Point(852, 91);
            Lbl_Type2.Name = "Lbl_Type2";
            Lbl_Type2.Size = new Size(74, 36);
            Lbl_Type2.TabIndex = 14;
            Lbl_Type2.Text = "BTC";
            // 
            // Conversion
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(Lbl_Type2);
            Controls.Add(Lbl_Type1);
            Controls.Add(Lbl_Title);
            Controls.Add(Lbl_M2);
            Controls.Add(Lbl_Arrow);
            Controls.Add(Lbl_M1);
            Controls.Add(Btn_Change);
            Controls.Add(Btn_Rev);
            Controls.Add(Btn_Money);
            Controls.Add(Btn_Tx);
            Controls.Add(Btn_Valid);
            Controls.Add(Btn_Leave);
            Font = new Font("Microsoft Sans Serif", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Conversion";
            Text = "Conversion";
            Load += Conversion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Leave;
        private Button Btn_Valid;
        private Button Btn_Tx;
        private Button Btn_Money;
        private Button Btn_Rev;
        private Button Btn_Change;
        private Label Lbl_M1;
        private Label Lbl_Arrow;
        private Label Lbl_M2;
        private Label Lbl_Title;
        private Label Lbl_Type1;
        private Label Lbl_Type2;
    }
}