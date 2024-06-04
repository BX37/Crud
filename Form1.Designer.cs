namespace Crud
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
            DVGenerique = new DataGridView();
            BTOuvrir = new Button();
            buttonCreer = new Button();
            buttonRefresh = new Button();
            panel1 = new Panel();
            labelBonjour = new Label();
            panel2 = new Panel();
            BTDeco = new Button();
            BTColorBlue = new Button();
            buttonLog = new Button();
            BTColorGreen = new Button();
            BTColorRed = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DVGenerique).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // DVGenerique
            // 
            DVGenerique.BackgroundColor = Color.PowderBlue;
            DVGenerique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGenerique.GridColor = Color.FromArgb(23, 133, 130);
            DVGenerique.Location = new Point(20, 12);
            DVGenerique.MultiSelect = false;
            DVGenerique.Name = "DVGenerique";
            DVGenerique.RowHeadersWidth = 51;
            DVGenerique.RowTemplate.Height = 29;
            DVGenerique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DVGenerique.Size = new Size(1055, 351);
            DVGenerique.TabIndex = 13;
            // 
            // BTOuvrir
            // 
            BTOuvrir.BackColor = Color.White;
            BTOuvrir.FlatAppearance.BorderColor = Color.FromArgb(23, 133, 130);
            BTOuvrir.FlatStyle = FlatStyle.Popup;
            BTOuvrir.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BTOuvrir.ForeColor = Color.FromArgb(191, 161, 129);
            BTOuvrir.Location = new Point(43, 4);
            BTOuvrir.Name = "BTOuvrir";
            BTOuvrir.Size = new Size(189, 39);
            BTOuvrir.TabIndex = 14;
            BTOuvrir.Text = "Ouvrir";
            BTOuvrir.UseVisualStyleBackColor = false;
            BTOuvrir.Click += BTOuvrir_Click;
            // 
            // buttonCreer
            // 
            buttonCreer.BackColor = Color.White;
            buttonCreer.FlatStyle = FlatStyle.Popup;
            buttonCreer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreer.ForeColor = Color.DarkCyan;
            buttonCreer.Location = new Point(951, 4);
            buttonCreer.Name = "buttonCreer";
            buttonCreer.Size = new Size(189, 39);
            buttonCreer.TabIndex = 15;
            buttonCreer.Text = "Créer";
            buttonCreer.UseVisualStyleBackColor = false;
            buttonCreer.Click += buttonCreer_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.White;
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.FromArgb(191, 161, 129);
            buttonRefresh.Location = new Point(495, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(189, 39);
            buttonRefresh.TabIndex = 16;
            buttonRefresh.Text = "Rafraichir";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(DVGenerique);
            panel1.Location = new Point(11, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 375);
            panel1.TabIndex = 17;
            // 
            // labelBonjour
            // 
            labelBonjour.AutoSize = true;
            labelBonjour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBonjour.ForeColor = Color.FromArgb(10, 24, 40);
            labelBonjour.Location = new Point(474, 8);
            labelBonjour.Name = "labelBonjour";
            labelBonjour.Size = new Size(0, 28);
            labelBonjour.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(BTColorBlue);
            panel2.Controls.Add(buttonLog);
            panel2.Controls.Add(BTColorGreen);
            panel2.Controls.Add(labelBonjour);
            panel2.Controls.Add(BTColorRed);
            panel2.Location = new Point(-1, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1319, 46);
            panel2.TabIndex = 22;
            // 
            // BTDeco
            // 
            BTDeco.BackColor = Color.White;
            BTDeco.FlatAppearance.BorderColor = Color.FromArgb(23, 133, 130);
            BTDeco.FlatStyle = FlatStyle.Popup;
            BTDeco.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BTDeco.ForeColor = Color.FromArgb(191, 161, 129);
            BTDeco.Location = new Point(1141, 215);
            BTDeco.Name = "BTDeco";
            BTDeco.Size = new Size(189, 39);
            BTDeco.TabIndex = 17;
            BTDeco.Text = "Déconnexion";
            BTDeco.UseVisualStyleBackColor = false;
            BTDeco.Click += BTDeco_Click;
            // 
            // BTColorBlue
            // 
            BTColorBlue.BackColor = Color.FromArgb(10, 24, 40);
            BTColorBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTColorBlue.Location = new Point(12, 8);
            BTColorBlue.Name = "BTColorBlue";
            BTColorBlue.Size = new Size(31, 31);
            BTColorBlue.TabIndex = 20;
            BTColorBlue.UseVisualStyleBackColor = false;
            BTColorBlue.Click += BTColorBlue_Click;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = Color.White;
            buttonLog.FlatStyle = FlatStyle.Popup;
            buttonLog.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLog.ForeColor = Color.FromArgb(191, 161, 129);
            buttonLog.Location = new Point(920, 4);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(189, 39);
            buttonLog.TabIndex = 22;
            buttonLog.Text = "Consulter logs";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += buttonLog_Click;
            // 
            // BTColorGreen
            // 
            BTColorGreen.BackColor = Color.DarkMagenta;
            BTColorGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTColorGreen.Location = new Point(111, 8);
            BTColorGreen.Name = "BTColorGreen";
            BTColorGreen.Size = new Size(31, 31);
            BTColorGreen.TabIndex = 21;
            BTColorGreen.UseVisualStyleBackColor = false;
            BTColorGreen.Click += BTColorGreen_Click;
            // 
            // BTColorRed
            // 
            BTColorRed.BackColor = Color.Crimson;
            BTColorRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTColorRed.Location = new Point(60, 8);
            BTColorRed.Name = "BTColorRed";
            BTColorRed.Size = new Size(31, 31);
            BTColorRed.TabIndex = 19;
            BTColorRed.UseVisualStyleBackColor = false;
            BTColorRed.Click += BTColorRed_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(BTOuvrir);
            panel4.Controls.Add(buttonRefresh);
            panel4.Controls.Add(buttonCreer);
            panel4.Location = new Point(-32, 472);
            panel4.Name = "panel4";
            panel4.Size = new Size(1362, 46);
            panel4.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1123, 529);
            Controls.Add(BTDeco);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            FormClosed += MAJ;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DVGenerique).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonPointInterrogation;
        private Label LBCompteur;
        private TextBox TBselection;
        private Label label1;
        private DataGridView DVGenerique;
        private Button BTOuvrir;
        private Button buttonCreer;
        private Button buttonRefresh;
        private Panel panel1;
        private Label labelBonjour;
        private Button BTColorRed;
        private Button BTColorBlue;
        private Button BTColorGreen;
        private Panel panel2;
        private Panel panel3;
        private Button buttonLog;
        private Panel panel4;
        private Button BTDeco;
    }
}