namespace Fulbank.View
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
            Btn_Valid = new Button();
            Btn_Cancel = new Button();
            lbl_bvn = new Label();
            lbl_username = new Label();
            TxtboxUsername = new TextBox();
            lbl_password = new Label();
            TxtboxPasswrd = new TextBox();
            Btn_Hide = new Button();
            Lbl_Care = new Label();
            SuspendLayout();
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
            Btn_Valid.TabIndex = 0;
            Btn_Valid.Text = "Valider";
            Btn_Valid.UseVisualStyleBackColor = false;
            Btn_Valid.Click += btn_valid_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Cancel.BackgroundImageLayout = ImageLayout.Center;
            Btn_Cancel.FlatStyle = FlatStyle.Flat;
            Btn_Cancel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Cancel.ForeColor = Color.White;
            Btn_Cancel.Location = new Point(12, 545);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(250, 100);
            Btn_Cancel.TabIndex = 1;
            Btn_Cancel.Text = "Annuler";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += btn_cancel_Click;
            // 
            // lbl_bvn
            // 
            lbl_bvn.AutoSize = true;
            lbl_bvn.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_bvn.ForeColor = Color.White;
            lbl_bvn.Location = new Point(195, 51);
            lbl_bvn.Name = "lbl_bvn";
            lbl_bvn.RightToLeft = RightToLeft.No;
            lbl_bvn.Size = new Size(707, 69);
            lbl_bvn.TabIndex = 2;
            lbl_bvn.Text = "Rentrez vos informations ";
            lbl_bvn.Click += label1_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(354, 170);
            lbl_username.Name = "lbl_username";
            lbl_username.RightToLeft = RightToLeft.No;
            lbl_username.Size = new Size(293, 42);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Nom d'utilisateur";
            lbl_username.Click += label1_Click_1;
            // 
            // TxtboxUsername
            // 
            TxtboxUsername.BackColor = Color.FromArgb(128, 194, 236);
            TxtboxUsername.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtboxUsername.ForeColor = Color.White;
            TxtboxUsername.Location = new Point(354, 233);
            TxtboxUsername.Name = "TxtboxUsername";
            TxtboxUsername.Size = new Size(349, 34);
            TxtboxUsername.TabIndex = 4;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(354, 290);
            lbl_password.Name = "lbl_password";
            lbl_password.RightToLeft = RightToLeft.No;
            lbl_password.Size = new Size(243, 42);
            lbl_password.TabIndex = 5;
            lbl_password.Text = "Mot de passe";
            lbl_password.Click += label2_Click;
            // 
            // TxtboxPasswrd
            // 
            TxtboxPasswrd.BackColor = Color.FromArgb(128, 194, 236);
            TxtboxPasswrd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtboxPasswrd.ForeColor = Color.White;
            TxtboxPasswrd.Location = new Point(354, 349);
            TxtboxPasswrd.Name = "TxtboxPasswrd";
            TxtboxPasswrd.Size = new Size(349, 34);
            TxtboxPasswrd.TabIndex = 6;
            TxtboxPasswrd.TextChanged += TxtboxPasswrd_TextChanged;
            // 
            // Btn_Hide
            // 
            Btn_Hide.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Hide.BackgroundImageLayout = ImageLayout.None;
            Btn_Hide.FlatStyle = FlatStyle.Flat;
            Btn_Hide.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Hide.ForeColor = Color.White;
            Btn_Hide.Location = new Point(762, 375);
            Btn_Hide.Name = "Btn_Hide";
            Btn_Hide.Size = new Size(250, 100);
            Btn_Hide.TabIndex = 17;
            Btn_Hide.Text = "Caché / Visible";
            Btn_Hide.UseVisualStyleBackColor = false;
            Btn_Hide.Click += Btn_Hide_Click;
            // 
            // Lbl_Care
            // 
            Lbl_Care.AutoSize = true;
            Lbl_Care.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Care.ForeColor = Color.Red;
            Lbl_Care.Location = new Point(425, 326);
            Lbl_Care.Name = "Lbl_Care";
            Lbl_Care.RightToLeft = RightToLeft.No;
            Lbl_Care.Size = new Size(0, 20);
            Lbl_Care.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(Lbl_Care);
            Controls.Add(Btn_Hide);
            Controls.Add(TxtboxPasswrd);
            Controls.Add(lbl_password);
            Controls.Add(TxtboxUsername);
            Controls.Add(lbl_username);
            Controls.Add(lbl_bvn);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Valid);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Valid;
        private Button Btn_Cancel;
        private Label lbl_bvn;
        private Label lbl_username;
        private TextBox TxtboxUsername;
        private Label lbl_password;
        private TextBox TxtboxPasswrd;
        private Button Btn_Hide;
        private Label Lbl_Care;
    }
}
