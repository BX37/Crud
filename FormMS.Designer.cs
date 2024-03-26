namespace Crud
{
    partial class FormMS
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
            BTSAVE = new Button();
            BTAnnuler = new Button();
            labelName = new Label();
            labelPrenom = new Label();
            textBoxNom = new TextBox();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            labelMdp = new Label();
            textBoxPrenom = new TextBox();
            textBoxMdp = new TextBox();
            checkBoxArchive = new CheckBox();
            labelArchive = new Label();
            comboBoxNiveau = new ComboBox();
            buttonSupprimer = new Button();
            panel1 = new Panel();
            labelNiveau = new Label();
            panel2 = new Panel();
            BTColorGreen = new Button();
            BTColorRed = new Button();
            BTColorBlue = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BTSAVE
            // 
            BTSAVE.BackColor = Color.LightGreen;
            BTSAVE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTSAVE.Location = new Point(225, 360);
            BTSAVE.Name = "BTSAVE";
            BTSAVE.Size = new Size(144, 46);
            BTSAVE.TabIndex = 3;
            BTSAVE.Text = "Sauvegarder";
            BTSAVE.UseVisualStyleBackColor = false;
            BTSAVE.Click += BTSAVE_Click;
            // 
            // BTAnnuler
            // 
            BTAnnuler.BackColor = Color.Gray;
            BTAnnuler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTAnnuler.Location = new Point(128, 360);
            BTAnnuler.Name = "BTAnnuler";
            BTAnnuler.Size = new Size(91, 46);
            BTAnnuler.TabIndex = 4;
            BTAnnuler.Text = "Annuler";
            BTAnnuler.UseVisualStyleBackColor = false;
            BTAnnuler.Click += BTAnnuler_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.ButtonFace;
            labelName.Location = new Point(3, 45);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 25);
            labelName.TabIndex = 6;
            labelName.Text = "Nom";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrenom.ForeColor = SystemColors.ButtonFace;
            labelPrenom.Location = new Point(3, 113);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(83, 25);
            labelPrenom.TabIndex = 7;
            labelPrenom.Text = "Prenom";
            // 
            // textBoxNom
            // 
            textBoxNom.BackColor = Color.White;
            textBoxNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNom.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxNom.Location = new Point(126, 23);
            textBoxNom.Multiline = true;
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(346, 46);
            textBoxNom.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxLogin.Location = new Point(127, 150);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(345, 46);
            textBoxLogin.TabIndex = 9;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = SystemColors.ButtonFace;
            labelLogin.Location = new Point(3, 175);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(63, 25);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "Login";
            // 
            // labelMdp
            // 
            labelMdp.AutoSize = true;
            labelMdp.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelMdp.ForeColor = SystemColors.ButtonFace;
            labelMdp.Location = new Point(3, 244);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(54, 25);
            labelMdp.TabIndex = 11;
            labelMdp.Text = "Mdp";
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.BackColor = Color.White;
            textBoxPrenom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPrenom.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxPrenom.Location = new Point(126, 88);
            textBoxPrenom.Multiline = true;
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(346, 46);
            textBoxPrenom.TabIndex = 12;
            // 
            // textBoxMdp
            // 
            textBoxMdp.BackColor = Color.White;
            textBoxMdp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMdp.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxMdp.Location = new Point(128, 219);
            textBoxMdp.Multiline = true;
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.PasswordChar = '*';
            textBoxMdp.Size = new Size(344, 46);
            textBoxMdp.TabIndex = 13;
            // 
            // checkBoxArchive
            // 
            checkBoxArchive.AutoSize = true;
            checkBoxArchive.Location = new Point(511, 51);
            checkBoxArchive.Name = "checkBoxArchive";
            checkBoxArchive.Size = new Size(18, 17);
            checkBoxArchive.TabIndex = 16;
            checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // labelArchive
            // 
            labelArchive.AutoSize = true;
            labelArchive.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelArchive.ForeColor = Color.Gold;
            labelArchive.Location = new Point(478, 23);
            labelArchive.Name = "labelArchive";
            labelArchive.Size = new Size(86, 25);
            labelArchive.TabIndex = 17;
            labelArchive.Text = "Archiver";
            // 
            // comboBoxNiveau
            // 
            comboBoxNiveau.BackColor = Color.White;
            comboBoxNiveau.DisplayMember = "2";
            comboBoxNiveau.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNiveau.ForeColor = Color.FromArgb(23, 133, 130);
            comboBoxNiveau.FormattingEnabled = true;
            comboBoxNiveau.Items.AddRange(new object[] { "Administrateur", "Opérateur" });
            comboBoxNiveau.Location = new Point(126, 294);
            comboBoxNiveau.Name = "comboBoxNiveau";
            comboBoxNiveau.Size = new Size(346, 28);
            comboBoxNiveau.TabIndex = 18;
            comboBoxNiveau.ValueMember = "2";
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.BackColor = Color.Tomato;
            buttonSupprimer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSupprimer.Location = new Point(375, 360);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(91, 46);
            buttonSupprimer.TabIndex = 19;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 71, 60);
            panel1.Controls.Add(labelNiveau);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelPrenom);
            panel1.Controls.Add(labelMdp);
            panel1.Controls.Add(labelLogin);
            panel1.Location = new Point(12, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 508);
            panel1.TabIndex = 20;
            // 
            // labelNiveau
            // 
            labelNiveau.AutoSize = true;
            labelNiveau.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelNiveau.ForeColor = SystemColors.ButtonFace;
            labelNiveau.Location = new Point(3, 301);
            labelNiveau.Name = "labelNiveau";
            labelNiveau.Size = new Size(74, 25);
            labelNiveau.TabIndex = 15;
            labelNiveau.Text = "Niveau";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 71, 60);
            panel2.Controls.Add(BTColorGreen);
            panel2.Controls.Add(BTColorRed);
            panel2.Controls.Add(BTColorBlue);
            panel2.Location = new Point(-35, 421);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 41);
            panel2.TabIndex = 21;
            // 
            // BTColorGreen
            // 
            BTColorGreen.BackColor = Color.DarkMagenta;
            BTColorGreen.Location = new Point(569, 3);
            BTColorGreen.Name = "BTColorGreen";
            BTColorGreen.Size = new Size(30, 30);
            BTColorGreen.TabIndex = 2;
            BTColorGreen.UseVisualStyleBackColor = false;
            BTColorGreen.Click += BTColorGreen_Click;
            // 
            // BTColorRed
            // 
            BTColorRed.BackColor = Color.FromArgb(231, 71, 61);
            BTColorRed.Location = new Point(524, 3);
            BTColorRed.Name = "BTColorRed";
            BTColorRed.Size = new Size(30, 30);
            BTColorRed.TabIndex = 1;
            BTColorRed.UseVisualStyleBackColor = false;
            BTColorRed.Click += BTColorRed_Click;
            // 
            // BTColorBlue
            // 
            BTColorBlue.BackColor = Color.FromArgb(10, 24, 40);
            BTColorBlue.Location = new Point(479, 3);
            BTColorBlue.Name = "BTColorBlue";
            BTColorBlue.Size = new Size(30, 30);
            BTColorBlue.TabIndex = 0;
            BTColorBlue.UseVisualStyleBackColor = false;
            BTColorBlue.Click += BTColorBlue_Click;
            // 
            // FormMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(573, 474);
            Controls.Add(panel1);
            Controls.Add(textBoxPrenom);
            Controls.Add(textBoxNom);
            Controls.Add(buttonSupprimer);
            Controls.Add(BTSAVE);
            Controls.Add(labelArchive);
            Controls.Add(checkBoxArchive);
            Controls.Add(comboBoxNiveau);
            Controls.Add(textBoxLogin);
            Controls.Add(BTAnnuler);
            Controls.Add(textBoxMdp);
            Controls.Add(panel2);
            Name = "FormMS";
            Text = "Modification du compte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTSAVE;
        private Button BTAnnuler;
        private Label labelName;
        private Label labelPrenom;
        private TextBox textBoxNom;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelMdp;
        private TextBox textBoxPrenom;
        private TextBox textBoxMdp;
        private CheckBox checkBoxArchive;
        private Label labelArchive;
        private ComboBox comboBoxNiveau;
        private Button buttonSupprimer;
        private Panel panel1;
        private Label labelNiveau;
        private Panel panel2;
        private Button BTColorGreen;
        private Button BTColorRed;
        private Button BTColorBlue;
    }
}