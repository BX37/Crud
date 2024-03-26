namespace Crud
{
    partial class FormLogin
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
            textBoxLogin = new TextBox();
            textBoxMDP = new TextBox();
            labelLogin = new Label();
            LabelMDP = new Label();
            buttonConnexion = new Button();
            labelConnexion = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.LightGray;
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLogin.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxLogin.Location = new Point(100, 64);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(374, 53);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxMDP
            // 
            textBoxMDP.BackColor = Color.LightGray;
            textBoxMDP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMDP.ForeColor = Color.FromArgb(23, 133, 130);
            textBoxMDP.Location = new Point(100, 176);
            textBoxMDP.Multiline = true;
            textBoxMDP.Name = "textBoxMDP";
            textBoxMDP.PasswordChar = '*';
            textBoxMDP.Size = new Size(374, 53);
            textBoxMDP.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.FromArgb(191, 161, 129);
            labelLogin.Location = new Point(189, 33);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(199, 28);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Entrez votre login : ";
            // 
            // LabelMDP
            // 
            LabelMDP.AutoSize = true;
            LabelMDP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMDP.ForeColor = Color.FromArgb(191, 161, 129);
            LabelMDP.Location = new Point(151, 145);
            LabelMDP.Name = "LabelMDP";
            LabelMDP.Size = new Size(276, 28);
            LabelMDP.TabIndex = 4;
            LabelMDP.Text = "Entrez votre mot de passe : ";
            // 
            // buttonConnexion
            // 
            buttonConnexion.BackColor = Color.FromArgb(23, 133, 130);
            buttonConnexion.FlatStyle = FlatStyle.Popup;
            buttonConnexion.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConnexion.ForeColor = Color.FromArgb(191, 161, 129);
            buttonConnexion.Location = new Point(100, 279);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(374, 65);
            buttonConnexion.TabIndex = 5;
            buttonConnexion.Text = "Connexion";
            buttonConnexion.UseVisualStyleBackColor = false;
            buttonConnexion.Click += buttonConnexion_Click_1;
            // 
            // labelConnexion
            // 
            labelConnexion.AutoSize = true;
            labelConnexion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelConnexion.ForeColor = Color.FromArgb(191, 161, 129);
            labelConnexion.Location = new Point(132, 247);
            labelConnexion.Name = "labelConnexion";
            labelConnexion.Size = new Size(0, 20);
            labelConnexion.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 24, 40);
            ClientSize = new Size(563, 400);
            Controls.Add(labelConnexion);
            Controls.Add(buttonConnexion);
            Controls.Add(LabelMDP);
            Controls.Add(labelLogin);
            Controls.Add(textBoxMDP);
            Controls.Add(textBoxLogin);
            Name = "FormLogin";
            Text = "Bienvenue, connectez vous pour continuer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxMDP;
        private Label label1;
        private Label labelLogin;
        private Label LabelMDP;
        private Button buttonConnexion;
        private Label labelConnexion;
    }
}