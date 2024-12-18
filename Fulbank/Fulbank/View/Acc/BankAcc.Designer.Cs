namespace Fulbank.View
{
    partial class BankAcc
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
            lbl_money = new Label();
            SuspendLayout();
            // 
            // Btn_Leave
            // 
            Btn_Leave.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Leave.BackgroundImageLayout = ImageLayout.None;
            Btn_Leave.FlatStyle = FlatStyle.Flat;
            Btn_Leave.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Leave.ForeColor = Color.White;
            Btn_Leave.Location = new Point(647, 559);
            Btn_Leave.Margin = new Padding(3, 2, 3, 2);
            Btn_Leave.Name = "Btn_Leave";
            Btn_Leave.Size = new Size(297, 156);
            Btn_Leave.TabIndex = 2;
            Btn_Leave.Text = "Quitter";
            Btn_Leave.UseVisualStyleBackColor = false;
            Btn_Leave.Click += Btn_Leave_Click;
            // 
            // lbl_money
            // 
            lbl_money.AutoSize = true;
            lbl_money.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_money.ForeColor = Color.White;
            lbl_money.Location = new Point(363, 153);
            lbl_money.Name = "lbl_money";
            lbl_money.Size = new Size(310, 108);
            lbl_money.TabIndex = 3;
            lbl_money.Text = "0,00 €";
            lbl_money.TextAlign = ContentAlignment.TopCenter;
            // 
            // BankAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(lbl_money);
            Controls.Add(Btn_Leave);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BankAcc";
            Text = "BankAcc";
            Load += BankAcc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Leave;
        private Label lbl_money;
    }
}