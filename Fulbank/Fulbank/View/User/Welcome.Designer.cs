namespace Fulbank.View
{
    partial class Welcome
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
            btn_login = new Button();
            btn_register = new Button();
            lbl_bvn = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(34, 67, 153);
            btn_login.BackgroundImageLayout = ImageLayout.None;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(744, 545);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(250, 100);
            btn_login.TabIndex = 0;
            btn_login.Text = "Log in";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(34, 67, 153);
            btn_register.BackgroundImageLayout = ImageLayout.None;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(12, 545);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(250, 100);
            btn_register.TabIndex = 1;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_bvn
            // 
            lbl_bvn.AutoSize = true;
            lbl_bvn.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_bvn.ForeColor = Color.White;
            lbl_bvn.Location = new Point(325, 140);
            lbl_bvn.Name = "lbl_bvn";
            lbl_bvn.RightToLeft = RightToLeft.No;
            lbl_bvn.Size = new Size(345, 69);
            lbl_bvn.TabIndex = 2;
            lbl_bvn.Text = "Bienvenue !";
            lbl_bvn.Click += label1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1006, 721);
            Controls.Add(lbl_bvn);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Button btn_register;
        private Label lbl_bvn;
    }
}
