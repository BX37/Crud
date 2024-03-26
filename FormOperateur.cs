using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormOperateur : Form
    {
        Tools utilitaire = new Tools();
        DBConnection laConnexion = new DBConnection();
        Utilisateur userCo = new Utilisateur();
        Log LogEnCours = new Log();
        List<Livre> ListLivre = new List<Livre>();
        public FormOperateur(Utilisateur utilisateurCo, Log leLog)
        {
            InitializeComponent();
            userCo = utilisateurCo;
            LogEnCours = leLog;
        }
        private void MAJ(object sender, FormClosedEventArgs e)
        {
            utilitaire.MAJDateTimeDeco(laConnexion, userCo);
            utilitaire.logDeconnexionMAJ(laConnexion, userCo, LogEnCours);
        }
        private void RemplirDGV()
        {
            if (laConnexion.IsConnect())
            {
                //string query = "select ID_User, Nom, Prenom, Login, Archive, Niveau from user;";
                string query = "select ID_User, Nom, Prenom, Login, Archive, Niveau, DateHeureConnexion, DateHeureDeconnexion, NbMauvaisMDP from user;";
                var cmd = new MySqlCommand(query, laConnexion.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string someStringFromColumOne = reader.GetString(1);
                    string someStringFromColumThree = reader.GetString(3);
                    Livre LeLivre = new Livre();
                    {
                        LeLivre.Id_Livre = (int)reader["ID_User"],
                        UtilisateurNom = (string)reader["Nom"],
                        UtilisateurPrenom = (string)reader["Prenom"],
                        UtilisateurLogin = (string)reader["Login"],
                        UtilisateurArchive = (bool)reader["Archive"],
                        UtilisateurNiveau = (string)reader["Niveau"],
                        UtilisateurDerniereConnexion = (DateTime)reader["DateHeureConnexion"],
                        UtilisateurDerniereDeconnexion = (DateTime)reader["DateHeureDeconnexion"],
                        UtilisateurNbMauvaisMDP = (int)reader["NbMauvaisMDP"]
                    };
                    ListLivre.Add(LeLivre);
                }
                reader.Close();
            }
            DGVLivre.DataSource = ListLivre;
            DGVLivre.Columns["UtilisateurID"].Visible = false;
            DGVLivre.Columns["UtilisateurMDP"].Visible = false;
        }
    }
}
