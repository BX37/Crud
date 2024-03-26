using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Crud
{
    public partial class FormMS : Form
    {

        private Utilisateur utilisateurAModifier;
        private DBConnection laNewconnexion;
        ChoixColors choixdelaCouleur = new ChoixColors();
        Tools utilitaire = new Tools();
        Form1 formDos;
        public string SomeDataProperty { get; private set; }
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
        public FormMS(Utilisateur selectedClient, DBConnection laConnexion, ChoixColors ChoixDeCouleur, Form1 formUno)
        {
            InitializeComponent();
            utilisateurAModifier = selectedClient;
            laNewconnexion = laConnexion;
            choixdelaCouleur = ChoixDeCouleur;
            formDos = formUno;

            textBoxNom.Text = utilisateurAModifier.UtilisateurNom;
            textBoxPrenom.Text = utilisateurAModifier.UtilisateurPrenom;
            textBoxLogin.Text = utilisateurAModifier.UtilisateurLogin;
            textBoxMdp.Text = "*";
            comboBoxNiveau.Text = utilisateurAModifier.UtilisateurNiveau;

            if (utilisateurAModifier.UtilisateurArchive == true)
            {
                checkBoxArchive.Checked = true;
            }
            else { checkBoxArchive.Checked = false; }
            modificationCouleurs(choixdelaCouleur);
        }

        private void BTSAVE_Click(object sender, EventArgs e)
        {
            utilisateurAModifier.UtilisateurNom = textBoxNom.Text;
            utilisateurAModifier.UtilisateurPrenom = textBoxPrenom.Text;
            utilisateurAModifier.UtilisateurLogin = textBoxLogin.Text;
            string MDPHashe;
            string MDP;
            utilisateurAModifier.UtilisateurNiveau = comboBoxNiveau.Text;
            if (checkBoxArchive.Checked)
            { utilisateurAModifier.UtilisateurArchive = true; }
            else utilisateurAModifier.UtilisateurArchive = false;

            if (textBoxMdp.Text.Contains("*"))
            {
                if (!utilitaire.VerifDoublonLogin(utilisateurAModifier))
                {
                    utilitaire.sauvegarderUtilisateurModifierSansMDP(utilisateurAModifier, laNewconnexion);
                }
                else { MessageBox.Show("attention Login déjà utilisé"); }
            }
            else
            {
                MDP = textBoxMdp.Text;
                MDPHashe = Hashage.MakeMD5Hash(MDP);
                utilisateurAModifier.UtilisateurMDP = Hashage.SalerLeMDP(MDPHashe);
                if (!utilitaire.VerifDoublonLogin(utilisateurAModifier))
                {
                    utilitaire.sauvegarderUtilisateurModifier(utilisateurAModifier, laNewconnexion);
                }
                else { MessageBox.Show("attention Login déjà utilisé"); }
            }

            SomeDataProperty = "Données à renvoyer au formulaire principal";
            DialogResult = DialogResult.OK;

        }


        private void BTAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            utilitaire.SupprimerUtilisateur(laNewconnexion, utilisateurAModifier);
            formDos.suppUser(utilisateurAModifier);
            SomeDataProperty = "Données à renvoyer au formulaire principal";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void modificationCouleurs(ChoixColors choixdelaCouleur)
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
                    // Bleu plutot clair 23; 133; 130
                    rouge3 = 10;
                    vert3 = 10;
                    bleu3 = 10;
                    // Bleu Nuit pour couleur écriture dans TB 
                    rouge4 = 10;
                    vert4 = 24;
                    bleu4 = 40;
                    ApplicationCouleurs();
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
                    ApplicationCouleurs();
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
                    ApplicationCouleurs();
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
            textBoxNom.ForeColor = Color.FromArgb(0, 139, 139);
            textBoxPrenom.ForeColor = Color.FromArgb(0, 139, 139);
            textBoxLogin.ForeColor = Color.FromArgb(0, 139, 139);
            textBoxMdp.ForeColor = Color.FromArgb(0, 139, 139);
            comboBoxNiveau.ForeColor = Color.FromArgb(0, 139, 139);
            labelPrenom.ForeColor = Color.FromArgb(255, 255, 255);
            labelName.ForeColor = Color.FromArgb(255, 255, 255);
            labelLogin.ForeColor = Color.FromArgb(255, 255, 255);
            labelMdp.ForeColor = Color.FromArgb(255, 255, 255);
            labelNiveau.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void ApplicationCouleurs()
        {

            this.BackColor = Color.FromArgb(rouge1, vert1, bleu1);
            panel1.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            panel2.BackColor = Color.FromArgb(rouge2, vert2, bleu2);
            labelName.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelPrenom.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelLogin.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelMdp.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            labelNiveau.ForeColor = Color.FromArgb(rouge1, vert1, bleu1);
            textBoxNom.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            textBoxPrenom.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            textBoxLogin.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            textBoxMdp.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
            comboBoxNiveau.ForeColor = Color.FromArgb(rouge4, vert4, bleu4);
        }
        private void BTColorBlue_Click(object sender, EventArgs e)
        {
            choixdelaCouleur.Couleur = 1;
            modificationCouleurs(choixdelaCouleur);
        }

        private void BTColorRed_Click(object sender, EventArgs e)
        {
            choixdelaCouleur.Couleur = 2;
            modificationCouleurs(choixdelaCouleur);
        }

        private void BTColorGreen_Click(object sender, EventArgs e)
        {
            choixdelaCouleur.Couleur = 3;
            modificationCouleurs(choixdelaCouleur);
        }

        public ChoixColors retourCouleur()
        {
            return choixdelaCouleur;
        }
    }
}