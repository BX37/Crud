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
            dataGridView1 = new DataGridView();
            buttonRetour = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 173);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1104, 75);
            dataGridView1.TabIndex = 0;
            // 
            // buttonRetour
            // 
            buttonRetour.Location = new Point(388, 271);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(94, 29);
            buttonRetour.TabIndex = 1;
            buttonRetour.Text = "Retour";
            buttonRetour.UseVisualStyleBackColor = true;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // Form2DetailOuvragecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 328);
            Controls.Add(buttonRetour);
            Controls.Add(panel1);
            Name = "Form2DetailOuvragecs";
            Text = "Form2DetailOuvragecs";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button buttonRetour;
    }
}