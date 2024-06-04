using Microsoft.Win32.SafeHandles;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form1 : Form
    {
        List<Utilisateur> contacts = new List<Utilisateur>();
        DBConnection laConnexion = new DBConnection();
        Utilisateur selectedUser = new Utilisateur();
        Utilisateur newUtilisateur = new Utilisateur();
        Tools utilitaire = new Tools();
        ChoixColors choixcouleurs = new ChoixColors();
        Log monLog = new Log();

        int rouge1;
        int vert1;
        int bleu1;
        int rouge2;
        int vert2;
        int bleu2;
        int rouge3;
        int vert3;
        int bleu3;
        int rouge5;
        int vert5;
        int bleu5;
        int rouge6;
        int bleu6;
        int vert6;

        Utilisateur userCo = new Utilisateur();
        Log LogPourDeco = new Log();
        public Form1(Utilisateur UserConnecte, Log NouveauLog)
        {
            InitializeComponent();
            DVGenerique.Refresh();
            laConnexion.Server = "localhost";
            laConnexion.DatabaseName = "belletable";
            laConnexion.UserName = "root";
            laConnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            labelBonjour.Text = "Bonjour " + UserConnecte.UtilisateurPrenom;
            RemplirDGV();
            userCo = UserConnecte;
            LogPourDeco = NouveauLog;
            choixcouleurs.Couleur = 1;
            changementCouleur(choixcouleurs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RemplirDGV()
        {
            if (laConnexion.IsConnect())
            {
                string query = "select ID_User, Nom, Prenom, Login, Archive, Niveau, DateHeureConnexion, DateHeureDeconnexion, NbMauvaisMDP from user;";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string someStringFromColumOne = reader.GetString(1);
                    string someStringFromColumThree = reader.GetString(3);
                    Utilisateur employé = new Utilisateur
                    {
                        UtilisateurID = (int)reader["ID_User"],
                        UtilisateurNom = (string)reader["Nom"],
                        UtilisateurPrenom = (string)reader["Prenom"],
                        UtilisateurLogin = (string)reader["Login"],
                        UtilisateurArchive = (bool)reader["Archive"],
                        UtilisateurNiveau = (string)reader["Niveau"],
                        UtilisateurDerniereConnexion = (DateTime)reader["DateHeureConnexion"],
                        UtilisateurDerniereDeconnexion = (DateTime)reader["DateHeureDeconnexion"],
                        UtilisateurNbMauvaisMDP = (int)reader["NbMauvaisMDP"]
                    };
                    contacts.Add(employé);
                }
                reader.Close();
            }
            DVGenerique.DataSource = contacts;
            DVGenerique.Columns["UtilisateurID"].Visible = false;
            DVGenerique.Columns["UtilisateurMDP"].Visible = false;
        }
        private void BTOuvrir_Click(object sender, EventArgs e)
        {

            if (DVGenerique.SelectedCells.Count > 0)
            {
                DataGridViewRow row = DVGenerique.SelectedRows[0];
                selectedUser = (Utilisateur)row.DataBoundItem;
                this.Visible = false;
                FormMS FormModifier = new FormMS(selectedUser, laConnexion, choixcouleurs, this);
                DialogResult result = FormModifier.ShowDialog();

                // une méthode return color qui retourne la couleur. 
                //FormModifier.returncolor(); 
                if (result == DialogResult.OK)
                {
                    refreshDGV();
                }
                else if (result == DialogResult.Cancel)
                {
                }
                choixcouleurs = FormModifier.retourCouleur();
                changementCouleur(choixcouleurs);
                this.Visible = true;
            }

        }
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2Creation Formcrer = new Form2Creation(newUtilisateur, laConnexion, choixcouleurs, this);
            DialogResult result = Formcrer.ShowDialog();
            if (result == DialogResult.OK)
            {
                refreshDGV();
            }
            else if (result == DialogResult.Cancel)
            {
            }

            choixcouleurs = Formcrer.recupCouleurFormCrea();
            changementCouleur(choixcouleurs);
            this.Visible = true;
        }
        int compteurFresh = 0;
        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            compteurFresh = compteurFresh + 1;
            refreshDGV();
            if (compteurFresh > 5)
            {
                DialogResult result = MessageBox.Show(userCo.UtilisateurPrenom + ", tu penses pas que l'atmosphère s'est assez rafraichie là ?", "5 fois ? Vraiment ? ", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    MessageBox.Show("C'est parti pour un voyage en hiver alors ! !");
                    choixcouleurs.Couleur = 4;
                    changementCouleur(choixcouleurs);
                    buttonRefresh.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Très bon choix");
                }
            }
        }
        private void ApplicationCouleurs()
        {
            this.BackColor = Color.FromArgb(rouge1, vert1, bleu1);
            panel1.BackColor = Color.FromArgb(rouge6, vert6, bleu6);
            DVGenerique.BackgroundColor = Color.FromArgb(rouge1, vert1, bleu1);
            panel2.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            labelBonjour.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            panel4.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            BTOuvrir.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            BTOuvrir.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
            buttonRefresh.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            buttonRefresh.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
            buttonLog.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            buttonLog.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
            buttonCreer.BackColor = Color.FromArgb(rouge3, vert3, bleu3);
            buttonCreer.ForeColor = Color.FromArgb(rouge5, vert5, bleu5);
        }
        private void passageEnModeHiver()
        {
            BTColorBlue.Visible = false;
            BTColorGreen.Visible = false;
            BTColorRed.Visible = false;

            panel1.BackColor = Color.FromArgb(0, 255, 255);
            panel2.BackColor = Color.FromArgb(0, 139, 139);
            panel4.BackColor = Color.FromArgb(0, 139, 139);
            BTOuvrir.ForeColor = Color.FromArgb(0, 139, 139);
            buttonLog.ForeColor = Color.FromArgb(0, 139, 139);
            buttonCreer.ForeColor = Color.FromArgb(0, 139, 139);
            buttonRefresh.ForeColor = Color.FromArgb(0, 139, 139);
            this.BackColor = Color.FromArgb(176, 224, 230);
            DVGenerique.BackgroundColor = Color.FromArgb(176, 224, 230);
            labelBonjour.ForeColor = Color.FromArgb(255, 255, 255);
            BTOuvrir.BackColor = Color.FromArgb(255, 255, 255);
            buttonRefresh.BackColor = Color.FromArgb(255, 255, 255);
            buttonLog.BackColor = Color.FromArgb(255, 255, 255);
            buttonCreer.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void refreshDGV()
        {
            DVGenerique.DataSource = null;
            DVGenerique.DataSource = contacts;
            DVGenerique.Columns["UtilisateurID"].Visible = false;
            DVGenerique.Columns["UtilisateurMDP"].Visible = false;
        }

        private void BTColorBlue_Click(object sender, EventArgs e)
        {
            choixcouleurs.Couleur = 1;
            changementCouleur(choixcouleurs);
        }

        private void BTColorRed_Click(object sender, EventArgs e)
        {
            choixcouleurs.Couleur = 2;
            changementCouleur(choixcouleurs);
        }

        private void BTColorGreen_Click(object sender, EventArgs e)
        {
            choixcouleurs.Couleur = 3;
            changementCouleur(choixcouleurs);
        }
        private void changementCouleur(ChoixColors choixcouleurs)
        {
            switch (choixcouleurs.Couleur)
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
                    // Or
                    rouge5 = 191;
                    vert5 = 161;
                    bleu5 = 129;
                    //
                    rouge6 = 191;
                    vert6 = 161;
                    bleu6 = 129;
                    ApplicationCouleurs();
                    break;
                case 2: // Rouge Vif (231; 71; 60) / Blanc fumée (240, 240, 240)
                    // Rouge Vif
                    rouge2 = 231;
                    vert2 = 71;
                    bleu2 = 60;
                    // Blanc fumée
                    rouge1 = 240;
                    vert1 = 240;
                    bleu1 = 240;
                    // blanc
                    rouge3 = 240;
                    vert3 = 240;
                    bleu3 = 240;
                    // Rouge
                    rouge5 = 231;
                    vert5 = 71;
                    bleu5 = 60;
                    //220, 20, 60
                    rouge6 = 220;
                    vert6 = 20;
                    bleu6 = 60;
                    ApplicationCouleurs();
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
                    // 
                    rouge3 = 216;
                    vert3 = 191;
                    bleu3 = 216;
                    //
                    rouge5 = 128;
                    vert5 = 0;
                    bleu5 = 128;
                    // MediumSlateBlue 123	104	238
                    rouge6 = 123;
                    vert6 = 104;
                    bleu6 = 238;
                    ApplicationCouleurs();
                    break;
                case 4:
                    passageEnModeHiver();
                    break;
            }

        }

        private void MAJ(object sender, FormClosedEventArgs e)
        {
            utilitaire.MAJDateTimeDeco(laConnexion, userCo);
            utilitaire.logDeconnexionMAJ(laConnexion, userCo, LogPourDeco);
        }
        public void suppUser(Utilisateur userASupp)
        {
            contacts.Remove(userASupp);

            refreshDGV();

        }
        public void ajoutUserCree(Utilisateur arrivageUser)
        {
            contacts.Add(arrivageUser);
            refreshDGV();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLog NouveauFormlogs = new FormLog(userCo, laConnexion, choixcouleurs);
            DialogResult result = NouveauFormlogs.ShowDialog();

            if (result == DialogResult.OK)
            {
                refreshDGV();
            }
            else if (result == DialogResult.Cancel)
            {
            }

            choixcouleurs = NouveauFormlogs.retourDeCouleur();
            changementCouleur(choixcouleurs);
            this.Visible = true;
        }

        private void BTDeco_Click(object sender, EventArgs e)
        {
            FormLogin NouveauFormlogin = new FormLogin();
            DialogResult result = NouveauFormlogin.ShowDialog();
            this.Visible = false;
            this.Close();
        }
    }
}