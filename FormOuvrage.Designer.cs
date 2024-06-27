namespace Crud
{
    partial class FormOuvrage
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
            buttonRetour = new Button();
            panel1 = new Panel();
            DGVLivre = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVLivre).BeginInit();
            SuspendLayout();
            // 
            // buttonRetour
            // 
            buttonRetour.Location = new Point(1078, 514);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(256, 29);
            buttonRetour.TabIndex = 0;
            buttonRetour.Text = "Retour";
            buttonRetour.UseVisualStyleBackColor = true;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(DGVLivre);
            panel1.Location = new Point(21, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1313, 486);
            panel1.TabIndex = 1;
            // 
            // DGVLivre
            // 
            DGVLivre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLivre.Location = new Point(3, 3);
            DGVLivre.Name = "DGVLivre";
            DGVLivre.RowHeadersWidth = 51;
            DGVLivre.RowTemplate.Height = 29;
            DGVLivre.Size = new Size(1307, 480);
            DGVLivre.TabIndex = 0;
            // 
            // FormOuvrage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 555);
            Controls.Add(buttonRetour);
            Controls.Add(panel1);
            Name = "FormOuvrage";
            Text = "FormOuvrage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVLivre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRetour;
        private Panel panel1;
        private DataGridView DGVLivre;
    }
}