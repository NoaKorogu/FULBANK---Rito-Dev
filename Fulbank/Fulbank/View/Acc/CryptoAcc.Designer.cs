namespace Fulbank.View.Acc
{
    partial class CryptoAcc
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
            Lbl_BTC = new Label();
            Lbl_ETH = new Label();
            SuspendLayout();
            // 
            // Btn_Leave
            // 
            Btn_Leave.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Leave.BackgroundImageLayout = ImageLayout.None;
            Btn_Leave.FlatStyle = FlatStyle.Flat;
            Btn_Leave.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Leave.ForeColor = Color.White;
            Btn_Leave.Location = new Point(762, 545);
            Btn_Leave.Name = "Btn_Leave";
            Btn_Leave.Size = new Size(250, 100);
            Btn_Leave.TabIndex = 3;
            Btn_Leave.Text = "Quitter";
            Btn_Leave.UseVisualStyleBackColor = false;
            Btn_Leave.Click += Btn_Leave_Click;
            // 
            // Lbl_BTC
            // 
            Lbl_BTC.AutoSize = true;
            Lbl_BTC.Font = new Font("Microsoft Sans Serif", 72F);
            Lbl_BTC.ForeColor = Color.White;
            Lbl_BTC.Location = new Point(81, 37);
            Lbl_BTC.Name = "Lbl_BTC";
            Lbl_BTC.Size = new Size(661, 108);
            Lbl_BTC.TabIndex = 4;
            Lbl_BTC.Text = "0.000000 BTC";
            Lbl_BTC.Click += Lbl_Crypto_Click;
            // 
            // Lbl_ETH
            // 
            Lbl_ETH.AutoSize = true;
            Lbl_ETH.Font = new Font("Microsoft Sans Serif", 72F);
            Lbl_ETH.ForeColor = Color.White;
            Lbl_ETH.Location = new Point(81, 273);
            Lbl_ETH.Name = "Lbl_ETH";
            Lbl_ETH.Size = new Size(661, 108);
            Lbl_ETH.TabIndex = 5;
            Lbl_ETH.Text = "0.000000 ETH";
            // 
            // CryptoAcc
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(Lbl_ETH);
            Controls.Add(Lbl_BTC);
            Controls.Add(Btn_Leave);
            Font = new Font("Microsoft Sans Serif", 19.8000011F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "CryptoAcc";
            Text = "CryptoAcc";
            Load += CryptoAcc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Leave;
        private Label Lbl_BTC;
        private Label Lbl_ETH;
    }
}