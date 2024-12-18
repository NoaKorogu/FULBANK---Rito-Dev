namespace Fulbank.View.transfer
{
    partial class ChooseUser
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
            Btn_Valid = new Button();
            Btn_Cancel = new Button();
            dgvTransfer = new DataGridView();
            lbl_username = new Label();
            Txtbox_Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
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
            Btn_Valid.TabIndex = 21;
            Btn_Valid.Text = "Confirmer";
            Btn_Valid.UseVisualStyleBackColor = false;
            Btn_Valid.Click += Btn_Valid_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.FromArgb(34, 67, 153);
            Btn_Cancel.BackgroundImageLayout = ImageLayout.None;
            Btn_Cancel.FlatStyle = FlatStyle.Flat;
            Btn_Cancel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Cancel.ForeColor = Color.White;
            Btn_Cancel.Location = new Point(12, 545);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(250, 100);
            Btn_Cancel.TabIndex = 22;
            Btn_Cancel.Text = "Annuler";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // dgvTransfer
            // 
            dgvTransfer.BackgroundColor = Color.FromArgb(128, 194, 236);
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Location = new Point(255, 167);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 51;
            dgvTransfer.Size = new Size(499, 372);
            dgvTransfer.TabIndex = 23;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(167, 60);
            lbl_username.Name = "lbl_username";
            lbl_username.RightToLeft = RightToLeft.No;
            lbl_username.Size = new Size(124, 29);
            lbl_username.TabIndex = 26;
            lbl_username.Text = "Chercher :";
            // 
            // Txtbox_Search
            // 
            Txtbox_Search.BackColor = Color.FromArgb(128, 194, 236);
            Txtbox_Search.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtbox_Search.ForeColor = Color.White;
            Txtbox_Search.Location = new Point(339, 63);
            Txtbox_Search.Name = "Txtbox_Search";
            Txtbox_Search.Size = new Size(311, 28);
            Txtbox_Search.TabIndex = 25;
            Txtbox_Search.TextChanged += Txtbox_Search_TextChanged;
            // 
            // ChooseUser
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(lbl_username);
            Controls.Add(Txtbox_Search);
            Controls.Add(dgvTransfer);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Valid);
            Font = new Font("Microsoft Sans Serif", 19.8000011F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "ChooseUser";
            Text = "ChooseUser";
            Load += ChooseUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Valid;
        private Button Btn_Cancel;
        private DataGridView dgvTransfer;
        private Label lbl_username;
        private TextBox Txtbox_Search;
    }
}