namespace Crud
{
    partial class Form2DetailOuvragecs
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
            panel1 = new Panel();
            label5 = new Label();
            CBEtatLivre = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TBCommentaire = new TextBox();
            TBEditeur = new TextBox();
            TBAuteur = new TextBox();
            TBTitre = new TextBox();
            buttonRetour = new Button();
            panel2 = new Panel();
            labelLivre = new Label();
            buttonInventorier = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CBEtatLivre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TBCommentaire);
            panel1.Controls.Add(TBEditeur);
            panel1.Controls.Add(TBAuteur);
            panel1.Controls.Add(TBTitre);
            panel1.Location = new Point(34, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 485);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 238);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 8;
            label5.Text = "Etat du livre";
            // 
            // CBEtatLivre
            // 
            CBEtatLivre.FormattingEnabled = true;
            CBEtatLivre.Items.AddRange(new object[] { "1 - Neuf", "2 - Très bon", "3 - Bon", "4 - Acceptable", "5 - Abimé" });
            CBEtatLivre.Location = new Point(50, 266);
            CBEtatLivre.Name = "CBEtatLivre";
            CBEtatLivre.Size = new Size(151, 28);
            CBEtatLivre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 315);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 6;
            label4.Text = "Ajout d'un commentaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 162);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 5;
            label3.Text = "Editeur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 85);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Auteur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 8);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 1;
            label1.Text = "Titre";
            // 
            // TBCommentaire
            // 
            TBCommentaire.Location = new Point(50, 353);
            TBCommentaire.Multiline = true;
            TBCommentaire.Name = "TBCommentaire";
            TBCommentaire.Size = new Size(903, 84);
            TBCommentaire.TabIndex = 3;
            // 
            // TBEditeur
            // 
            TBEditeur.Location = new Point(50, 190);
            TBEditeur.Multiline = true;
            TBEditeur.Name = "TBEditeur";
            TBEditeur.ReadOnly = true;
            TBEditeur.Size = new Size(903, 34);
            TBEditeur.TabIndex = 2;
            // 
            // TBAuteur
            // 
            TBAuteur.Location = new Point(50, 113);
            TBAuteur.Multiline = true;
            TBAuteur.Name = "TBAuteur";
            TBAuteur.ReadOnly = true;
            TBAuteur.Size = new Size(903, 34);
            TBAuteur.TabIndex = 1;
            // 
            // TBTitre
            // 
            TBTitre.Location = new Point(50, 36);
            TBTitre.Multiline = true;
            TBTitre.Name = "TBTitre";
            TBTitre.ReadOnly = true;
            TBTitre.Size = new Size(903, 34);
            TBTitre.TabIndex = 0;
            // 
            // buttonRetour
            // 
            buttonRetour.Location = new Point(932, 9);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(94, 29);
            buttonRetour.TabIndex = 1;
            buttonRetour.Text = "Retour";
            buttonRetour.UseVisualStyleBackColor = true;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(buttonRetour);
            panel2.Controls.Add(labelLivre);
            panel2.Location = new Point(1, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 49);
            panel2.TabIndex = 2;
            // 
            // labelLivre
            // 
            labelLivre.AutoSize = true;
            labelLivre.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelLivre.Location = new Point(61, 13);
            labelLivre.Name = "labelLivre";
            labelLivre.Size = new Size(65, 25);
            labelLivre.TabIndex = 0;
            labelLivre.Text = "label1";
            // 
            // buttonInventorier
            // 
            buttonInventorier.Location = new Point(933, 576);
            buttonInventorier.Name = "buttonInventorier";
            buttonInventorier.Size = new Size(94, 29);
            buttonInventorier.TabIndex = 3;
            buttonInventorier.Text = "Inventorier";
            buttonInventorier.UseVisualStyleBackColor = true;
            buttonInventorier.Click += buttonInventorier_Click;
            // 
            // Form2DetailOuvragecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 639);
            Controls.Add(buttonInventorier);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2DetailOuvragecs";
            Text = "Form2DetailOuvragecs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRetour;
        private Panel panel2;
        private Label labelLivre;
        private TextBox TBEditeur;
        private TextBox TBAuteur;
        private TextBox TBTitre;
        private ComboBox CBEtatLivre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TBCommentaire;
        private Label label5;
        private Button buttonInventorier;
    }
}