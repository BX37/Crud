namespace Crud
{
    partial class Form2Creation
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
            labelNom = new Label();
            labelPrenom = new Label();
            labelLogin = new Label();
            labelMDP = new Label();
            labelNiveau = new Label();
            buttonEnregistrer = new Button();
            buttonAnnuler = new Button();
            textBoxNewNom = new TextBox();
            textBoxNewPrenom = new TextBox();
            textBoxNewLogin = new TextBox();
            textBoxNewMdp = new TextBox();
            label6 = new Label();
            comboBoxNiveau = new ComboBox();
            checkBoxArchive = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            BTColorGreen = new Button();
            BTColorRed = new Button();
            BTColorBlue = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelNom.ForeColor = Color.FromArgb(191, 161, 129);
            labelNom.Location = new Point(3, 63);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(56, 25);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrenom.ForeColor = Color.FromArgb(191, 161, 129);
            labelPrenom.Location = new Point(3, 131);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(83, 25);
            labelPrenom.TabIndex = 1;
            labelPrenom.Text = "Prenom";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.FromArgb(191, 161, 129);
            labelLogin.Location = new Point(3, 193);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(63, 25);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Login";
            // 
            // labelMDP
            // 
            labelMDP.AutoSize = true;
            labelMDP.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelMDP.ForeColor = Color.FromArgb(191, 161, 129);
            labelMDP.Location = new Point(3, 254);
            labelMDP.Name = "labelMDP";
            labelMDP.Size = new Size(54, 25);
            labelMDP.TabIndex = 3;
            labelMDP.Text = "Mdp";
            // 
            // labelNiveau
            // 
            labelNiveau.AutoSize = true;
            labelNiveau.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelNiveau.ForeColor = Color.FromArgb(191, 161, 129);
            labelNiveau.Location = new Point(3, 310);
            labelNiveau.Name = "labelNiveau";
            labelNiveau.Size = new Size(74, 25);
            labelNiveau.TabIndex = 4;
            labelNiveau.Text = "Niveau";
            // 
            // buttonEnregistrer
            // 
            buttonEnregistrer.BackColor = Color.PaleGreen;
            buttonEnregistrer.Location = new Point(304, 328);
            buttonEnregistrer.Name = "buttonEnregistrer";
            buttonEnregistrer.Size = new Size(120, 53);
            buttonEnregistrer.TabIndex = 5;
            buttonEnregistrer.Text = "Enregistrer";
            buttonEnregistrer.UseVisualStyleBackColor = false;
            buttonEnregistrer.Click += buttonEnregistrer_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.Coral;
            buttonAnnuler.Location = new Point(127, 328);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(118, 53);
            buttonAnnuler.TabIndex = 6;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // textBoxNewNom
            // 
            textBoxNewNom.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxNewNom.Location = new Point(118, 23);
            textBoxNewNom.Multiline = true;
            textBoxNewNom.Name = "textBoxNewNom";
            textBoxNewNom.Size = new Size(344, 41);
            textBoxNewNom.TabIndex = 7;
            // 
            // textBoxNewPrenom
            // 
            textBoxNewPrenom.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxNewPrenom.Location = new Point(118, 91);
            textBoxNewPrenom.Multiline = true;
            textBoxNewPrenom.Name = "textBoxNewPrenom";
            textBoxNewPrenom.Size = new Size(344, 41);
            textBoxNewPrenom.TabIndex = 8;
            // 
            // textBoxNewLogin
            // 
            textBoxNewLogin.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxNewLogin.Location = new Point(118, 153);
            textBoxNewLogin.Multiline = true;
            textBoxNewLogin.Name = "textBoxNewLogin";
            textBoxNewLogin.Size = new Size(344, 41);
            textBoxNewLogin.TabIndex = 9;
            // 
            // textBoxNewMdp
            // 
            textBoxNewMdp.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxNewMdp.Location = new Point(118, 214);
            textBoxNewMdp.Multiline = true;
            textBoxNewMdp.Name = "textBoxNewMdp";
            textBoxNewMdp.PasswordChar = '*';
            textBoxNewMdp.Size = new Size(344, 41);
            textBoxNewMdp.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(468, 22);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 12;
            label6.Text = "Archive";
            // 
            // comboBoxNiveau
            // 
            comboBoxNiveau.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNiveau.ForeColor = Color.FromArgb(23, 133, 130);
            comboBoxNiveau.FormattingEnabled = true;
            comboBoxNiveau.Items.AddRange(new object[] { "Administrateur", "Opérateur" });
            comboBoxNiveau.Location = new Point(118, 283);
            comboBoxNiveau.Name = "comboBoxNiveau";
            comboBoxNiveau.Size = new Size(344, 28);
            comboBoxNiveau.TabIndex = 13;
            // 
            // checkBoxArchive
            // 
            checkBoxArchive.AutoSize = true;
            checkBoxArchive.Location = new Point(499, 50);
            checkBoxArchive.Name = "checkBoxArchive";
            checkBoxArchive.Size = new Size(18, 17);
            checkBoxArchive.TabIndex = 14;
            checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 71, 60);
            panel1.Controls.Add(labelMDP);
            panel1.Controls.Add(labelPrenom);
            panel1.Controls.Add(labelNom);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(labelNiveau);
            panel1.Location = new Point(12, -24);
            panel1.Name = "panel1";
            panel1.Size = new Size(85, 561);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 71, 60);
            panel2.Controls.Add(BTColorGreen);
            panel2.Controls.Add(BTColorRed);
            panel2.Controls.Add(BTColorBlue);
            panel2.Location = new Point(0, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 41);
            panel2.TabIndex = 16;
            // 
            // BTColorGreen
            // 
            BTColorGreen.BackColor = Color.DarkViolet;
            BTColorGreen.Location = new Point(516, 3);
            BTColorGreen.Name = "BTColorGreen";
            BTColorGreen.Size = new Size(30, 30);
            BTColorGreen.TabIndex = 2;
            BTColorGreen.UseVisualStyleBackColor = false;
            BTColorGreen.Click += BTColorGreen_Click;
            // 
            // BTColorRed
            // 
            BTColorRed.BackColor = Color.FromArgb(231, 71, 61);
            BTColorRed.Location = new Point(471, 3);
            BTColorRed.Name = "BTColorRed";
            BTColorRed.Size = new Size(30, 30);
            BTColorRed.TabIndex = 1;
            BTColorRed.UseVisualStyleBackColor = false;
            BTColorRed.Click += BTColorRed_Click;
            // 
            // BTColorBlue
            // 
            BTColorBlue.BackColor = Color.FromArgb(10, 24, 40);
            BTColorBlue.Location = new Point(426, 3);
            BTColorBlue.Name = "BTColorBlue";
            BTColorBlue.Size = new Size(30, 30);
            BTColorBlue.TabIndex = 0;
            BTColorBlue.UseVisualStyleBackColor = false;
            BTColorBlue.Click += BTColorBlue_Click;
            // 
            // Form2Creation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 24, 40);
            ClientSize = new Size(558, 468);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(checkBoxArchive);
            Controls.Add(comboBoxNiveau);
            Controls.Add(label6);
            Controls.Add(textBoxNewMdp);
            Controls.Add(textBoxNewLogin);
            Controls.Add(textBoxNewPrenom);
            Controls.Add(buttonAnnuler);
            Controls.Add(buttonEnregistrer);
            Controls.Add(textBoxNewNom);
            Name = "Form2Creation";
            Text = "Création de compte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelPrenom;
        private Label labelLogin;
        private Label labelMDP;
        private Label labelNiveau;
        private Button buttonEnregistrer;
        private Button buttonAnnuler;
        private TextBox textBoxNewNom;
        private TextBox textBoxNewPrenom;
        private TextBox textBoxNewLogin;
        private TextBox textBoxNewMdp;
        private Label label6;
        private ComboBox comboBoxNiveau;
        private CheckBox checkBoxArchive;
        private Panel panel1;
        private Panel panel2;
        private Button BTColorGreen;
        private Button BTColorRed;
        private Button BTColorBlue;
    }
}