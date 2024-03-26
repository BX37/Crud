using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form2Creation : Form
    {
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
        Form1 formDos;
        Tools utilitaire = new Tools();

        public Form2Creation(Utilisateur ArrivageUtilisateur, DBConnection Laconnexion, ChoixColors ChoixDeCouleur, Form1 formUno)
        {
            InitializeComponent();
            formDos = formUno;
            choixcouleurs = ChoixDeCouleur;
            modificationCouleurs(choixcouleurs);

        }
        public string SomeDataProperty { get; private set; }

        Utilisateur ArrivageUtilisateur = new Utilisateur();
        DBConnection Laconnexion = new DBConnection();
        ChoixColors choixcouleurs = new ChoixColors();

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            ArrivageUtilisateur.UtilisateurNom = textBoxNewNom.Text;
            ArrivageUtilisateur.UtilisateurPrenom = textBoxNewPrenom.Text;
            ArrivageUtilisateur.UtilisateurLogin = textBoxNewLogin.Text;
            string newUserMdp = textBoxNewMdp.Text;
            string newUserMdpHasher = Hashage.MakeMD5Hash(newUserMdp);
            string MDPHasherSaler = Hashage.SalerLeMDP(newUserMdpHasher);
            ArrivageUtilisateur.UtilisateurMDP = MDPHasherSaler;
            ArrivageUtilisateur.UtilisateurNiveau = comboBoxNiveau.Text;
            if (checkBoxArchive.Checked)
            {
                ArrivageUtilisateur.UtilisateurArchive = true;
            }
            else { ArrivageUtilisateur.UtilisateurArchive = false; }
            ArrivageUtilisateur.UtilisateurDerniereConnexion = DateTime.MinValue;
            ArrivageUtilisateur.UtilisateurDerniereDeconnexion = DateTime.MinValue;
            ArrivageUtilisateur.UtilisateurNbMauvaisMDP = 0;
            if (!utilitaire.VerifDoublonLogin(ArrivageUtilisateur))
            {
                utilitaire.EnregistrerUnUtilisateur(ArrivageUtilisateur);
                utilitaire.getID(ArrivageUtilisateur);
                formDos.ajoutUserCree(ArrivageUtilisateur);
                SomeDataProperty = "Données à renvoyer au formulaire principal";
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("attention Login déjà utilisé");
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            // Vous pouvez laisser SomeDataProperty inchangé si nécessaire
            // Définissez DialogResult sur Annuler et fermez le formulaire
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        public void modificationCouleurs(ChoixColors choixcouleurs)
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
                    // Bleu plutot clair 23; 133; 130
                    rouge3 = 10;
                    vert3 = 10;
                    bleu3 = 10;
                    // Bleu Nuit pour couleur écriture dans TB 
                    rouge4 = 10;
                    vert4 = 24;
                    bleu4 = 40;
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
                    //
                    rouge3 = 10;
                    vert3 = 10;
                    bleu3 = 10;
                    // Rouge Vif pour couleur écriture dans TB
                    rouge4 = 231;
                    vert4 = 71;
                    bleu4 = 60;
                    ApplicationCouleur();
                    break;
                case 3:
                    // thistle   216;191;216
                    rouge1 = 216;
                    vert1 = 191;
                    bleu1 = 216;
                    //Purple 128,0,128
                    rouge2 = 128;
                    vert2 = 0;
                    bleu2 = 128;
                    //
                    rouge3 = 10;
                    vert3 = 10;
                    bleu3 = 10;
                    //
                    rouge4 = 128;
                    vert4 = 0;
                    bleu4 = 128;
                    ApplicationCouleur();
                    break;
                    case 4:
                    ApplicationHiver();
                    break;
            }

            
        }
        private void ApplicationHiver()
        {
            BTColorBlue.Visible = false;
            BTColorGreen.Visible = false;   
            BTColorRed.Visible = false;
            this.BackColor = Color.FromArgb(176, 224, 230);
            panel1.BackColor = Color.FromArgb(0, 139, 139);
            panel2.BackColor = Color.FromArgb(0, 139, 139);
            textBoxNewNom.ForeColor = Color.FromArgb(0, 139, 139);
            textBoxNewPrenom.ForeColor = Color.FromArgb(0, 139, 139);
            textBoxNewLogin.ForeColor = Color.FromArgb(0, 139, 139);
            textBoxNewMdp.ForeColor = Color.FromArgb(0, 139, 139);
            comboBoxNiveau.ForeColor = Color.FromArgb(0, 139, 139);
            labelPrenom.ForeColor = Color.FromArgb(255, 255, 255);
            labelNom.ForeColor = Color.FromArgb(255, 255, 255);
            labelLogin.ForeColor = Color.FromArgb(255, 255, 255);
            labelMDP.ForeColor = Color.FromArgb(255, 255, 255);
            labelNiveau.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void ApplicationCouleur()
        {
            this.BackColor = Color.FromArgb(rouge1, vert1, bleu1);
            panel1.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            panel2.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            textBoxNewNom.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            textBoxNewPrenom.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            textBoxNewLogin.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            textBoxNewMdp.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            comboBoxNiveau.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            labelPrenom.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelNom.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelLogin.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelMDP.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelNiveau.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
        }
        private void BTColorBlue_Click(object sender, EventArgs e)
        {
            choixcouleurs.Couleur = 1;
            modificationCouleurs(choixcouleurs);
        }

        private void BTColorRed_Click(object sender, EventArgs e)
        {
            choixcouleurs.Couleur = 2;
            modificationCouleurs(choixcouleurs);
        }

        private void BTColorGreen_Click(object sender, EventArgs e)
        {
            choixcouleurs.Couleur = 3;
            modificationCouleurs(choixcouleurs);
        }
        public ChoixColors recupCouleurFormCrea()
        {
            return choixcouleurs;
        }
    }
}
