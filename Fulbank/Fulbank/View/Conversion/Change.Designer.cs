namespace Fulbank.View
{
    partial class Change
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
            Btn_Reverse = new Button();
            Btn_ChValue = new Button();
            Btn_ChCurrency = new Button();
            lbl_TxCh = new Label();
            lbl_FValue = new Label();
            lbl_Equal = new Label();
            lbl_SValue = new Label();
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
            Btn_Leave.TabIndex = 2;
            Btn_Leave.Text = "Quitter";
            Btn_Leave.UseVisualStyleBackColor = false;
            Btn_Leave.Click += Btn_Leave_Click;
            // 
            // Btn_Reverse
            // 
            Btn_Reverse.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Reverse.BackgroundImageLayout = ImageLayout.None;
            Btn_Reverse.FlatStyle = FlatStyle.Flat;
            Btn_Reverse.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Reverse.ForeColor = Color.White;
            Btn_Reverse.Location = new Point(762, 375);
            Btn_Reverse.Name = "Btn_Reverse";
            Btn_Reverse.Size = new Size(250, 100);
            Btn_Reverse.TabIndex = 3;
            Btn_Reverse.Text = "Inverser";
            Btn_Reverse.UseVisualStyleBackColor = false;
            // 
            // Btn_ChValue
            // 
            Btn_ChValue.BackColor = Color.FromArgb(34, 67, 153);
            Btn_ChValue.BackgroundImageLayout = ImageLayout.None;
            Btn_ChValue.FlatStyle = FlatStyle.Flat;
            Btn_ChValue.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_ChValue.ForeColor = Color.White;
            Btn_ChValue.Location = new Point(12, 375);
            Btn_ChValue.Name = "Btn_ChValue";
            Btn_ChValue.Size = new Size(250, 100);
            Btn_ChValue.TabIndex = 4;
            Btn_ChValue.Text = "Changer la valeur";
            Btn_ChValue.UseVisualStyleBackColor = false;
            // 
            // Btn_ChCurrency
            // 
            Btn_ChCurrency.BackColor = Color.FromArgb(34, 67, 153);
            Btn_ChCurrency.BackgroundImageLayout = ImageLayout.None;
            Btn_ChCurrency.FlatStyle = FlatStyle.Flat;
            Btn_ChCurrency.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_ChCurrency.ForeColor = Color.White;
            Btn_ChCurrency.Location = new Point(12, 545);
            Btn_ChCurrency.Name = "Btn_ChCurrency";
            Btn_ChCurrency.Size = new Size(250, 100);
            Btn_ChCurrency.TabIndex = 5;
            Btn_ChCurrency.Text = "Changer de monnaie";
            Btn_ChCurrency.UseVisualStyleBackColor = false;
            // 
            // lbl_TxCh
            // 
            lbl_TxCh.AutoSize = true;
            lbl_TxCh.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TxCh.ForeColor = Color.White;
            lbl_TxCh.Location = new Point(261, 34);
            lbl_TxCh.Name = "lbl_TxCh";
            lbl_TxCh.RightToLeft = RightToLeft.No;
            lbl_TxCh.Size = new Size(456, 69);
            lbl_TxCh.TabIndex = 6;
            lbl_TxCh.Text = "Taux de change";
            // 
            // lbl_FValue
            // 
            lbl_FValue.AutoSize = true;
            lbl_FValue.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FValue.ForeColor = Color.White;
            lbl_FValue.Location = new Point(34, 163);
            lbl_FValue.Name = "lbl_FValue";
            lbl_FValue.RightToLeft = RightToLeft.No;
            lbl_FValue.Size = new Size(198, 69);
            lbl_FValue.TabIndex = 7;
            lbl_FValue.Text = "1 euro";
            // 
            // lbl_Equal
            // 
            lbl_Equal.AutoSize = true;
            lbl_Equal.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Equal.ForeColor = Color.White;
            lbl_Equal.Location = new Point(428, 163);
            lbl_Equal.Name = "lbl_Equal";
            lbl_Equal.RightToLeft = RightToLeft.No;
            lbl_Equal.Size = new Size(65, 69);
            lbl_Equal.TabIndex = 8;
            lbl_Equal.Text = "=";
            // 
            // lbl_SValue
            // 
            lbl_SValue.AutoSize = true;
            lbl_SValue.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SValue.ForeColor = Color.White;
            lbl_SValue.Location = new Point(560, 163);
            lbl_SValue.Name = "lbl_SValue";
            lbl_SValue.RightToLeft = RightToLeft.No;
            lbl_SValue.Size = new Size(414, 69);
            lbl_SValue.TabIndex = 9;
            lbl_SValue.Text = "0,000019 BTC";
            // 
            // Change
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(lbl_SValue);
            Controls.Add(lbl_Equal);
            Controls.Add(lbl_FValue);
            Controls.Add(lbl_TxCh);
            Controls.Add(Btn_ChCurrency);
            Controls.Add(Btn_ChValue);
            Controls.Add(Btn_Reverse);
            Controls.Add(Btn_Leave);
            Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Change";
            Text = "Change";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Leave;
        private Button Btn_Reverse;
        private Button Btn_ChValue;
        private Button Btn_ChCurrency;
        private Label lbl_TxCh;
        private Label lbl_FValue;
        private Label lbl_Equal;
        private Label lbl_SValue;
    }
}