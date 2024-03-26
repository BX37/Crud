using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class FormLogin : Form
    {
        Tools utilitaire = new Tools();
        
        public FormLogin()
        {
            InitializeComponent();
        }

        DBConnection Laconnexion = new DBConnection();

        private void buttonConnexion_Click_1(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxMDP.Text;
            string motDePasseSecurise = Hashage.MakeMD5Hash(password);
            string MDPSaler = Hashage.SalerLeMDP(motDePasseSecurise);

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez saisir un nom d'utilisateur et un mot de passe.");
                return;
            }

            // Vérifiez les informations de connexion
            if (utilitaire.VerifierInformationsConnexion(login, MDPSaler))
            {
                if (!utilitaire.VerifArchive(login, MDPSaler))
                {
                    labelConnexion.Text = "Connexion réussie !";
                    Utilisateur utilisateurCO = new Utilisateur();
                    Log nouveauLog = new Log();
                    utilisateurCO = utilitaire.recupUser(login, MDPSaler);
                    utilitaire.MAJDateTimeLogin(Laconnexion, utilisateurCO);
                    utilitaire.logNouvelleConnexion(Laconnexion, utilisateurCO, nouveauLog);
                    if(utilisateurCO.UtilisateurNiveau == "Administrateur")
                    {
                        Form1 leForm1 = new Form1(utilisateurCO, nouveauLog);
                        leForm1.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        FormOperateur leFormOpe = new FormOperateur(utilisateurCO, nouveauLog);
                        leFormOpe.Show();
                        this.Visible = false;
                    }
                    
                }
                else
                {
                    labelConnexion.Text = "L'utilisateur est archivé, connexion impossible.";
                }
            }
            else
            {
                labelConnexion.Text = "Nom d'utilisateur ou mot de passe incorrect.";
                utilitaire.MauvaisMDP(login);
            }
        }
    }
}