namespace Crud
{
    partial class FormLog
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
            DGVLog = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonGreen = new Button();
            buttonQuitter = new Button();
            buttonBlue = new Button();
            buttonRed = new Button();
            panel3 = new Panel();
            checkBoxCumuler = new CheckBox();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            buttonReset = new Button();
            buttonValider = new Button();
            textBoxID = new TextBox();
            label3ID = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVLog).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // DGVLog
            // 
            DGVLog.AllowDrop = true;
            DGVLog.AllowUserToOrderColumns = true;
            DGVLog.BackgroundColor = Color.Thistle;
            DGVLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLog.Location = new Point(9, 9);
            DGVLog.Name = "DGVLog";
            DGVLog.ReadOnly = true;
            DGVLog.RowHeadersWidth = 51;
            DGVLog.RowTemplate.Height = 29;
            DGVLog.Size = new Size(700, 363);
            DGVLog.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(DGVLog);
            panel1.Location = new Point(139, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 382);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkMagenta;
            panel2.Controls.Add(buttonGreen);
            panel2.Controls.Add(buttonQuitter);
            panel2.Controls.Add(buttonBlue);
            panel2.Controls.Add(buttonRed);
            panel2.Location = new Point(892, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 481);
            panel2.TabIndex = 3;
            // 
            // buttonGreen
            // 
            buttonGreen.BackColor = Color.DarkOrchid;
            buttonGreen.ForeColor = Color.DarkViolet;
            buttonGreen.Location = new Point(35, 84);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(30, 30);
            buttonGreen.TabIndex = 0;
            buttonGreen.UseVisualStyleBackColor = false;
            buttonGreen.Click += buttonGreen_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.Thistle;
            buttonQuitter.FlatStyle = FlatStyle.Popup;
            buttonQuitter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonQuitter.ForeColor = Color.DarkViolet;
            buttonQuitter.Location = new Point(3, 405);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(95, 35);
            buttonQuitter.TabIndex = 0;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonBlue
            // 
            buttonBlue.BackColor = Color.FromArgb(10, 24, 41);
            buttonBlue.Location = new Point(35, 12);
            buttonBlue.Name = "buttonBlue";
            buttonBlue.Size = new Size(30, 30);
            buttonBlue.TabIndex = 1;
            buttonBlue.UseVisualStyleBackColor = false;
            buttonBlue.Click += buttonBlue_Click;
            // 
            // buttonRed
            // 
            buttonRed.BackColor = Color.Crimson;
            buttonRed.Location = new Point(35, 48);
            buttonRed.Name = "buttonRed";
            buttonRed.Size = new Size(30, 30);
            buttonRed.TabIndex = 2;
            buttonRed.UseVisualStyleBackColor = false;
            buttonRed.Click += buttonRed_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Controls.Add(checkBoxCumuler);
            panel3.Controls.Add(buttonReset);
            panel3.Controls.Add(textBoxLogin);
            panel3.Controls.Add(labelLogin);
            panel3.Controls.Add(buttonValider);
            panel3.Controls.Add(textBoxID);
            panel3.Controls.Add(label3ID);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 481);
            panel3.TabIndex = 4;
            // 
            // checkBoxCumuler
            // 
            checkBoxCumuler.AutoSize = true;
            checkBoxCumuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxCumuler.Location = new Point(4, 48);
            checkBoxCumuler.Name = "checkBoxCumuler";
            checkBoxCumuler.Size = new Size(97, 27);
            checkBoxCumuler.TabIndex = 6;
            checkBoxCumuler.Text = "cumuler";
            checkBoxCumuler.UseVisualStyleBackColor = true;
            checkBoxCumuler.CheckedChanged += checkBoxCumuler_CheckedChanged;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(3, 205);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(95, 27);
            textBoxLogin.TabIndex = 8;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.Location = new Point(0, 177);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(78, 25);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login : ";
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Thistle;
            buttonReset.FlatStyle = FlatStyle.Popup;
            buttonReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(3, 364);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(95, 35);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonValider
            // 
            buttonValider.BackColor = Color.Thistle;
            buttonValider.FlatStyle = FlatStyle.Popup;
            buttonValider.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonValider.ForeColor = Color.DarkViolet;
            buttonValider.Location = new Point(3, 405);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(95, 35);
            buttonValider.TabIndex = 3;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = false;
            buttonValider.Click += buttonValider_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(2, 147);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(95, 27);
            textBoxID.TabIndex = 6;
            // 
            // label3ID
            // 
            label3ID.AutoSize = true;
            label3ID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3ID.Location = new Point(0, 119);
            label3ID.Name = "label3ID";
            label3ID.Size = new Size(47, 25);
            label3ID.TabIndex = 2;
            label3ID.Text = "ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 1;
            label2.Text = "Filtres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 18);
            label1.Name = "label1";
            label1.Size = new Size(356, 37);
            label1.TabIndex = 5;
            label1.Text = "Historique des connexions";
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1008, 462);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(10, 24, 40);
            Name = "FormLog";
            Text = "FormLog";
            ((System.ComponentModel.ISupportInitialize)DGVLog).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVLog;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonGreen;
        private Button buttonBlue;
        private Button buttonRed;
        private Button buttonQuitter;
        private Label label1;
        private Label label2;
        private TextBox textBoxID;
        private Label label3ID;
        private Button buttonValider;
        private Button buttonReset;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private CheckBox checkBoxCumuler;
    }
}