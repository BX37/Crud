namespace Crud
{
    partial class FormOperateur
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
            DGVLivre = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonConsulter = new Button();
            buttonTest = new Button();
            buttonDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVLivre).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGVLivre
            // 
            DGVLivre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLivre.Location = new Point(6, 6);
            DGVLivre.Name = "DGVLivre";
            DGVLivre.RowHeadersWidth = 51;
            DGVLivre.RowTemplate.Height = 29;
            DGVLivre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVLivre.Size = new Size(890, 466);
            DGVLivre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(DGVLivre);
            panel1.Location = new Point(73, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 479);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.Controls.Add(buttonDetail);
            panel2.Controls.Add(buttonConsulter);
            panel2.Controls.Add(buttonTest);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 49);
            panel2.TabIndex = 2;
            // 
            // buttonConsulter
            // 
            buttonConsulter.Location = new Point(946, 11);
            buttonConsulter.Name = "buttonConsulter";
            buttonConsulter.Size = new Size(94, 29);
            buttonConsulter.TabIndex = 1;
            buttonConsulter.Text = "Consulter";
            buttonConsulter.UseVisualStyleBackColor = true;
            buttonConsulter.Click += buttonConsulter_Click;
            // 
            // buttonTest
            // 
            buttonTest.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTest.Location = new Point(45, 11);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(94, 29);
            buttonTest.TabIndex = 0;
            buttonTest.Text = "button1";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // buttonDetail
            // 
            buttonDetail.Location = new Point(492, 11);
            buttonDetail.Name = "buttonDetail";
            buttonDetail.Size = new Size(111, 29);
            buttonDetail.TabIndex = 2;
            buttonDetail.Text = "Détail";
            buttonDetail.UseVisualStyleBackColor = true;
            buttonDetail.Click += buttonDetail_Click;
            // 
            // FormOperateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 574);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormOperateur";
            Text = "FormOperateur";
            ((System.ComponentModel.ISupportInitialize)DGVLivre).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVLivre;
        private Panel panel1;
        private Panel panel2;
        private Button buttonTest;
        private Button buttonConsulter;
        private Button buttonDetail;
    }
}