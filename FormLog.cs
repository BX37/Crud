using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Linq;

namespace Crud
{
    public partial class FormLog : Form
    {
        List<Log> listLog = new List<Log>();
        List<Log> listLog2 = new List<Log>();
        List<Log> listLogApresLinq = new List<Log>();
        List<Utilisateur> listUser = new List<Utilisateur>();
        private Utilisateur utilisateurAModifier;
        private DBConnection laConnexion;
        ChoixColors choixdelaCouleur = new ChoixColors();
        Tools utilitaire = new Tools();
        Form1 formDos;

        int rouge1;
        int vert1;
        int bleu1;
        int rouge2;
        int vert2;
        int bleu2;
        int rouge3;
        int vert3;
        int bleu3;
        int rouge4;
        int vert4;
        int bleu4;
        int rouge5;
        int vert5;
        int bleu5;
        public FormLog(Utilisateur userConnecte, DBConnection connexion, ChoixColors couleurSelected)
        {
            InitializeComponent();
            laConnexion = connexion;
            choixdelaCouleur = couleurSelected;
            changementCouleur(choixdelaCouleur);

            DGVLog.Refresh();
            laConnexion.Server = "localhost";
            laConnexion.DatabaseName = "belletable";
            laConnexion.UserName = "root";
            laConnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            RemplirDGVLog();
        }
        private void RemplirDGVLog()
        {
            if (laConnexion.IsConnect())
            {
                string query = "select ID_Log, ID_User, Login, logDateTimeConnexion, logDateTimeDeconnexion from log;";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string someStringFromColumOne = reader.GetString(1);
                    string someStringFromColumThree = reader.GetString(3);
                    Log unLog = new Log
                    {
                        Log_ID = (int)reader["ID_Log"],
                        Log_Id_User = (int)reader["ID_User"],
                        Log_Login = (string)reader["Login"],
                        Log_DateTimeConnexion = (DateTime)reader["logDateTimeConnexion"],
                        Log_DateTimeDeconnexion = (DateTime)reader["logDateTimeDeconnexion"]
                    };
                    listLog.Add(unLog);
                }
                reader.Close();
            }
            DGVLog.DataSource = listLog;
        }
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            choixdelaCouleur.Couleur = 1;
            changementCouleur(choixdelaCouleur);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            choixdelaCouleur.Couleur = 2;
            changementCouleur(choixdelaCouleur);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            choixdelaCouleur.Couleur = 3;
            changementCouleur(choixdelaCouleur);
        }

        private void changementCouleur(ChoixColors choixdelaCouleur)
        {
            switch (choixdelaCouleur.Couleur)
            {
                case 1: // Bleu nuit (10; 24; 40) / or ( 191; 161; 129 )  ->  default
                    // Bleu Nuit
                    rouge1 = 10;
                    vert1 = 24;
                    bleu1 = 40;
                    // Or
                    rouge2 = 191;
                    vert2 = 161;
                    bleu2 = 129;
                    // Bleu plutot clair 23; 133; 130  Bouton 
                    rouge3 = 23;
                    vert3 = 133;
                    bleu3 = 130;
                    //
                    rouge4 = 191;
                    vert4 = 161;
                    bleu4 = 129;
                    // Or
                    rouge5 = 191;
                    vert5 = 161;
                    bleu5 = 129;
                    ApplicationCouleur();
                    break;
                case 2: // Rouge Vif (231; 71; 60) / Blanc fumée (240, 240, 240)
                    // Blanc fumée
                    rouge1 = 240;
                    vert1 = 240;
                    bleu1 = 240;
                    // Rouge Vif
                    rouge2 = 231;
                    vert2 = 71;
                    bleu2 = 60;
                    // blanc
                    rouge3 = 240;
                    vert3 = 240;
                    bleu3 = 240;
                    //
                    rouge4 = 220;
                    vert4 = 20;
                    bleu4 = 60;
                    // Crimson 220, 20, 60
                    rouge5 = 220;
                    vert5 = 20;
                    bleu5 = 60;
                    ApplicationCouleur();
                    break;
                case 3:
                    // thistle  - 216;191;216
                    rouge1 = 216;
                    vert1 = 191;
                    bleu1 = 216;
                    // Purple 128,0,128
                    rouge2 = 128;
                    vert2 = 0;
                    bleu2 = 128;
                    // thistle 
                    rouge3 = 216;
                    vert3 = 191;
                    bleu3 = 216;
                    //
                    rouge4 = 128;
                    vert4 = 0;
                    bleu4 = 128;
                    // MediumSlateBlue 123	104	238
                    rouge5 = 123;
                    vert5 = 104;
                    bleu5 = 238;
                    ApplicationCouleur();
                    break;
                case 4:
                    ApplicationHiver();
                    break;
            }
        }
        public void ApplicationHiver()
        {
            buttonBlue.Visible = false;
            buttonGreen.Visible = false;
            buttonRed.Visible = false;
            panel1.BackColor = Color.FromArgb(0, 255, 255);
            panel2.BackColor = Color.FromArgb(0, 139, 139);
            panel3.BackColor = Color.FromArgb(0, 139, 139);
            label1.ForeColor = Color.FromArgb(0, 139, 139);
            this.BackColor = Color.FromArgb(176, 224, 230);
            DGVLog.BackgroundColor = Color.FromArgb(176, 224, 230);
            buttonQuitter.ForeColor = Color.FromArgb(0, 139, 139);
            buttonQuitter.BackColor = Color.FromArgb(255, 255, 255);
            buttonValider.ForeColor = Color.FromArgb(0, 139, 139);
            buttonValider.BackColor = Color.FromArgb(255, 255, 255);
            buttonReset.ForeColor = Color.FromArgb(0, 139, 139);
            buttonReset.BackColor = Color.FromArgb(255, 255, 255);
            label2.ForeColor = Color.FromArgb(176, 224, 230);
            label3ID.ForeColor = Color.FromArgb(176, 224, 230);

        }
        public void ApplicationCouleur()
        {
            this.BackColor = Color.FromArgb(rouge1, vert1, bleu1);
            label2.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            label3ID.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            DGVLog.BackgroundColor = Color.FromArgb(rouge1, vert1, bleu1);
            panel1.BackColor = Color.FromArgb(rouge5, vert5, bleu5); //
            panel2.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            label1.ForeColor = Color.FromArgb(rouge2, vert2, bleu2);
            panel3.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            buttonQuitter.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            buttonQuitter.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
            buttonValider.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            buttonValider.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
            buttonReset.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            buttonReset.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
        }
        public ChoixColors retourDeCouleur()
        {
            return choixdelaCouleur;
        }
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // remplirDGV2 pour les tests, avec une requete SQL donc pas idéal.
            //remplirDGV2();
            int idUser = int.Parse(textBoxID.Text);
            string login = (textBoxLogin.Text);
            if (!checkBoxCumuler.Checked)
            {
                listLogApresLinq.Clear();
                LinqDGV(idUser, login);
            }
            else
            {
                LinqDGV(idUser, login);
            }

        }
        public void remplirDGV2()
        {
            {
                int id = int.Parse(textBoxID.Text);
                DGVLog.DataSource = null;
                DGVLog.ClearSelection();
                listLog2.Clear();
                if (laConnexion.IsConnect())
                {

                    string query = "select ID_Log, ID_User, Login, logDateTimeConnexion, logDateTimeDeconnexion from log where ID_user = @id";
                    var cmd = new MySqlCommand(query, laConnexion.Connection);
                    cmd.Parameters.AddWithValue("@ID", id);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string someStringFromColumOne = reader.GetString(1);
                        string someStringFromColumThree = reader.GetString(3);
                        Log undeuxiemeLog = new Log
                        {
                            Log_ID = (int)reader["ID_Log"],
                            Log_Id_User = (int)reader["ID_User"],
                            Log_Login = (string)reader["Login"],
                            Log_DateTimeConnexion = (DateTime)reader["logDateTimeConnexion"],
                            Log_DateTimeDeconnexion = (DateTime)reader["logDateTimeDeconnexion"]
                        };
                        listLog2.Add(undeuxiemeLog);
                    }
                    reader.Close();
                }
                DGVLog.DataSource = listLog2;
            }
        }
        public void LinqDGV(int idUser, string login)
        {
            var result = listLog.Where(p => p.Log_Id_User == idUser || p.Log_Login == login);

            foreach (var item in result)
            {
                listLogApresLinq.Add(item);
            }
            DGVLog.DataSource = null;
            DGVLog.DataSource = listLogApresLinq;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetDGV();

        }
        public void resetDGV()
        {
            DGVLog.DataSource = null;
            DGVLog.DataSource = listLog;
        }

        private void checkBoxCumuler_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCumuler.Checked)
            {
                listLogApresLinq.Clear();
            }
            else resetDGV();

        }

        private void BTE51_Click(object sender, EventArgs e)
        {
            {
                DGVLog.DataSource = null;
                DGVLog.ClearSelection();
                listLog2.Clear();
                if (laConnexion.IsConnect())
                {

                    string query = @"
            SELECT ID_User, Nom, Prenom, Login
            FROM user
            WHERE ID_User NOT IN (
                SELECT ID_User
                FROM log
                WHERE logDateTimeConnexion >= DATE_SUB(NOW(), INTERVAL 5 DAY)
                GROUP BY ID_User
                HAVING COUNT(*) >= 2
            )";
                    var cmd = new MySqlCommand(query, laConnexion.Connection);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Utilisateur leUser = new Utilisateur
                        {
                            UtilisateurID = (int)reader["ID_User"],
                            UtilisateurNom = (string)reader["Nom"],
                            UtilisateurPrenom = (string)reader["Prenom"],
                            UtilisateurLogin = (string)reader["Login"]
                        };
                        listUser.Add(leUser);
                    }
                    reader.Close();
                }
                DGVLog.DataSource = listUser;
            }
        }

        private void BTE52_Click(object sender, EventArgs e)
        {
            DGVLog.DataSource = null;
            DGVLog.ClearSelection();
            listUser.Clear();
            if (laConnexion.IsConnect())
            {
                string query = @"
            SELECT u.ID_User, u.Nom, u.Prenom, u.Login
            FROM user u
            INNER JOIN log l ON u.ID_User = l.ID_User
            WHERE DAYOFWEEK(l.logDateTimeConnexion) = 1";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Utilisateur leUser = new Utilisateur
                    {
                        UtilisateurID = (int)reader["ID_User"],
                        UtilisateurNom = (string)reader["Nom"],
                        UtilisateurPrenom = (string)reader["Prenom"],
                        UtilisateurLogin = (string)reader["Login"]
                    };
                    listUser.Add(leUser);
                }
                reader.Close();
            }
            DGVLog.DataSource = listUser;
        }
    }

}
