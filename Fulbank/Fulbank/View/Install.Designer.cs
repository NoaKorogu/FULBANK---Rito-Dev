namespace Fulbank.View
{
    partial class Install
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
            TxtboxUsername = new TextBox();
            Lbl_Location = new Label();
            lbl_bvn = new Label();
            btn_cancel = new Button();
            btn_valid = new Button();
            SuspendLayout();
            // 
            // TxtboxUsername
            // 
            TxtboxUsername.BackColor = Color.FromArgb(128, 194, 236);
            TxtboxUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtboxUsername.ForeColor = Color.White;
            TxtboxUsername.Location = new Point(218, 267);
            TxtboxUsername.Name = "TxtboxUsername";
            TxtboxUsername.Size = new Size(592, 34);
            TxtboxUsername.TabIndex = 5;
            // 
            // Lbl_Location
            // 
            Lbl_Location.AutoSize = true;
            Lbl_Location.ForeColor = Color.White;
            Lbl_Location.Location = new Point(218, 208);
            Lbl_Location.Name = "Lbl_Location";
            Lbl_Location.Size = new Size(592, 36);
            Lbl_Location.TabIndex = 6;
            Lbl_Location.Text = "Veuillez insérer la localisation de l'appareil :";
            // 
            // lbl_bvn
            // 
            lbl_bvn.AutoSize = true;
            lbl_bvn.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_bvn.ForeColor = Color.White;
            lbl_bvn.Location = new Point(352, 57);
            lbl_bvn.Name = "lbl_bvn";
            lbl_bvn.RightToLeft = RightToLeft.No;
            lbl_bvn.Size = new Size(318, 69);
            lbl_bvn.TabIndex = 7;
            lbl_bvn.Text = "Installation";
            lbl_bvn.Click += lbl_bvn_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(34, 67, 153);
            btn_cancel.BackgroundImageLayout = ImageLayout.None;
            btn_cancel.Enabled = false;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(12, 545);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(250, 100);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Annuler";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_valid
            // 
            btn_valid.BackColor = Color.FromArgb(34, 67, 153);
            btn_valid.BackgroundImageLayout = ImageLayout.None;
            btn_valid.FlatStyle = FlatStyle.Flat;
            btn_valid.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_valid.ForeColor = Color.White;
            btn_valid.Location = new Point(744, 545);
            btn_valid.Name = "btn_valid";
            btn_valid.Size = new Size(250, 100);
            btn_valid.TabIndex = 9;
            btn_valid.Text = "Valider";
            btn_valid.UseVisualStyleBackColor = false;
            // 
            // Install
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1006, 721);
            Controls.Add(btn_valid);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_bvn);
            Controls.Add(Lbl_Location);
            Controls.Add(TxtboxUsername);
            Font = new Font("Microsoft Sans Serif", 18F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Install";
            Text = "Install";
            Load += Install_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtboxUsername;
        private Label Lbl_Location;
        private Label lbl_bvn;
        private Button btn_cancel;
        private Button btn_valid;
    }
}