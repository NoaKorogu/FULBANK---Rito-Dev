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
            dataGridView1 = new DataGridView();
            lbl_username = new Label();
            Txtbox_Search = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(128, 194, 236);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(255, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 372);
            dataGridView1.TabIndex = 23;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(167, 60);
            lbl_username.Name = "lbl_username";
            lbl_username.RightToLeft = RightToLeft.No;
            lbl_username.Size = new Size(153, 36);
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
            Txtbox_Search.Size = new Size(311, 34);
            Txtbox_Search.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 67, 153);
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(706, 60);
            button1.Name = "button1";
            button1.Size = new Size(97, 38);
            button1.TabIndex = 24;
            button1.Text = "Chercher";
            button1.UseVisualStyleBackColor = false;
            // 
            // ChooseUser
            // 
            AutoScaleDimensions = new SizeF(19F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(lbl_username);
            Controls.Add(Txtbox_Search);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Valid);
            Font = new Font("Microsoft Sans Serif", 19.8000011F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "ChooseUser";
            Text = "ChooseUser";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Valid;
        private Button Btn_Cancel;
        private DataGridView dataGridView1;
        private Label lbl_username;
        private TextBox Txtbox_Search;
        private Button button1;
    }
}