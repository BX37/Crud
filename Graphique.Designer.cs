namespace Crud
{
    partial class Graphique
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
            BTRetour = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(BTRetour);
            panel1.Location = new Point(36, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 485);
            panel1.TabIndex = 0;
            // 
            // BTRetour
            // 
            BTRetour.Location = new Point(49, 14);
            BTRetour.Name = "BTRetour";
            BTRetour.Size = new Size(94, 29);
            BTRetour.TabIndex = 0;
            BTRetour.Text = "Retour";
            BTRetour.UseVisualStyleBackColor = true;
            BTRetour.Click += BTRetour_Click;
            // 
            // Graphique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 545);
            Controls.Add(panel1);
            Name = "Graphique";
            Text = "Graphique";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTRetour;
    }
}