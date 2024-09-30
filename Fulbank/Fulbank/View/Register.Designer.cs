namespace Fulbank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_valid = new Button();
            btn_cancel = new Button();
            lbl_bvn = new Label();
            label1 = new Label();
            TxtboxUsername = new TextBox();
            label2 = new Label();
            TxtboxPasswrd = new TextBox();
            SuspendLayout();
            // 
            // btn_valid
            // 
            btn_valid.BackColor = Color.FromArgb(34, 67, 153);
            btn_valid.BackgroundImageLayout = ImageLayout.None;
            btn_valid.FlatStyle = FlatStyle.Flat;
            btn_valid.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_valid.ForeColor = Color.White;
            btn_valid.Location = new Point(1012, 495);
            btn_valid.Name = "btn_valid";
            btn_valid.Size = new Size(350, 150);
            btn_valid.TabIndex = 0;
            btn_valid.Text = "Valider";
            btn_valid.UseVisualStyleBackColor = false;
            btn_valid.Click += btn_valid_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(34, 67, 153);
            btn_cancel.BackgroundImageLayout = ImageLayout.None;
            btn_cancel.Enabled = false;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(12, 495);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(350, 150);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Annuler";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_bvn
            // 
            lbl_bvn.AutoSize = true;
            lbl_bvn.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_bvn.ForeColor = Color.White;
            lbl_bvn.Location = new Point(352, 57);
            lbl_bvn.Name = "lbl_bvn";
            lbl_bvn.RightToLeft = RightToLeft.No;
            lbl_bvn.Size = new Size(707, 69);
            lbl_bvn.TabIndex = 2;
            lbl_bvn.Text = "Rentrez vos informations ";
            lbl_bvn.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(352, 164);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(293, 42);
            label1.TabIndex = 3;
            label1.Text = "Nom d'utilisateur";
            label1.Click += label1_Click_1;
            // 
            // TxtboxUsername
            // 
            TxtboxUsername.BackColor = Color.FromArgb(128, 194, 236);
            TxtboxUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtboxUsername.ForeColor = Color.White;
            TxtboxUsername.Location = new Point(352, 234);
            TxtboxUsername.Name = "TxtboxUsername";
            TxtboxUsername.Size = new Size(311, 34);
            TxtboxUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(352, 298);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(243, 42);
            label2.TabIndex = 5;
            label2.Text = "Mot de passe";
            label2.Click += label2_Click;
            // 
            // TxtboxPasswrd
            // 
            TxtboxPasswrd.BackColor = Color.FromArgb(128, 194, 236);
            TxtboxPasswrd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtboxPasswrd.ForeColor = Color.White;
            TxtboxPasswrd.Location = new Point(352, 363);
            TxtboxPasswrd.Name = "TxtboxPasswrd";
            TxtboxPasswrd.Size = new Size(311, 34);
            TxtboxPasswrd.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1374, 755);
            Controls.Add(TxtboxPasswrd);
            Controls.Add(label2);
            Controls.Add(TxtboxUsername);
            Controls.Add(label1);
            Controls.Add(lbl_bvn);
            Controls.Add(btn_cancel);
            Controls.Add(btn_valid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_valid;
        private Button btn_cancel;
        private Label lbl_bvn;
        private Label label1;
        private TextBox TxtboxUsername;
        private Label label2;
        private TextBox TxtboxPasswrd;
    }
}
