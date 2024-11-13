namespace Fulbank.View
{
    partial class MainForm
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
            Pnl_Main = new Panel();
            SuspendLayout();
            // 
            // Pnl_Main
            // 
            Pnl_Main.Dock = DockStyle.Fill;
            Pnl_Main.Location = new Point(0, 0);
            Pnl_Main.Name = "Pnl_Main";
            Pnl_Main.Size = new Size(1024, 768);
            Pnl_Main.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(1024, 768);
            Controls.Add(Pnl_Main);
            Font = new Font("Microsoft Sans Serif", 18F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Main;
    }
}