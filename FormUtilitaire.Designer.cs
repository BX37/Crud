namespace Crud
{
    partial class FormUtilitaire
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
            buttonDeviensCrypte = new Button();
            label1 = new Label();
            label2 = new Label();
            TBMDP = new TextBox();
            TBMDPCypte = new TextBox();
            SuspendLayout();
            // 
            // buttonDeviensCrypte
            // 
            buttonDeviensCrypte.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeviensCrypte.Location = new Point(273, 170);
            buttonDeviensCrypte.Name = "buttonDeviensCrypte";
            buttonDeviensCrypte.Size = new Size(113, 51);
            buttonDeviensCrypte.TabIndex = 0;
            buttonDeviensCrypte.Text = "->";
            buttonDeviensCrypte.UseVisualStyleBackColor = true;
            buttonDeviensCrypte.Click += buttonDeviensCrypte_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 88);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 1;
            label1.Text = "Données en clair";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 285);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 2;
            label2.Text = "Données cryptées";
            // 
            // TBMDP
            // 
            TBMDP.Location = new Point(273, 85);
            TBMDP.Name = "TBMDP";
            TBMDP.PasswordChar = '*';
            TBMDP.Size = new Size(398, 27);
            TBMDP.TabIndex = 3;
            // 
            // TBMDPCypte
            // 
            TBMDPCypte.Location = new Point(273, 278);
            TBMDPCypte.Name = "TBMDPCypte";
            TBMDPCypte.Size = new Size(398, 27);
            TBMDPCypte.TabIndex = 4;
            // 
            // FormUtilitaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TBMDPCypte);
            Controls.Add(TBMDP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDeviensCrypte);
            Name = "FormUtilitaire";
            Text = "FormUtilitaire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeviensCrypte;
        private Label label1;
        private Label label2;
        private TextBox TBMDP;
        private TextBox TBMDPCypte;
    }
}