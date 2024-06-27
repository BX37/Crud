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
    public partial class FormOuvrage : Form
    {
        DBConnection laConnexion = new DBConnection();
        List<Livre> ListLivre = new List<Livre>();
        Tools utilitaire = new Tools();
        Utilisateur userCo = new Utilisateur();
        Log LogEnCours = new Log();

        public FormOuvrage(DBConnection laCo, Utilisateur User, Log leLog)
        {
            LogEnCours = leLog;
            userCo = User;
            laConnexion = laCo;
            InitializeComponent();
            RemplirDGVLivre();
        }
        public void RemplirDGVLivre()
        {
            if (laConnexion.IsConnect())
            {
                string query2 = "select * from livre;";
                var cmd2 = new MySqlCommand(query2, laConnexion.Connection);
                var reader12 = cmd2.ExecuteReader();

                while (reader12.Read())
                {
                    Livre LeLivre = new Livre
                    {
                        ID_Livre = (int)reader12["ID_livre"],
                        Identifiant_Livre = (string)reader12["Identifiant"],
                        NoticeBNF_Livre = (int)reader12["NoticeBNF"],
                        TypeNotice_Livre = (string)reader12["TypeNotice"],
                        TypeDocument_Livre = (string)reader12["TypeDocument"],
                        Localisation_Livre = (string)reader12["Localisation"],
                        Exemplaire_Livre = (string)reader12["Exemplaires"],
                        Titre_Livre = (string)reader12["Titre"],
                        Auteur_Livre = (string)reader12["Auteur"],
                        Editeur_Livre = (string)reader12["Editeur"],
                        Date_Livre = (string)reader12["Date"],
                        Description_Livre = (string)reader12["Description"],
                        Sujet_Livre = (string)reader12["Sujet"],
                        Langue_Livre = (string)reader12["Langue"],
                        Format_Livre = (string)reader12["Format"]
                    };

                    ListLivre.Add(LeLivre);
                }
                reader12.Close();
            }
            DGVLivre.DataSource = ListLivre;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void MAJ(object sender, FormClosedEventArgs e)
        {
            utilitaire.MAJDateTimeDeco(laConnexion, userCo);
            utilitaire.logDeconnexionMAJ(laConnexion, userCo, LogEnCours);
        }
    }
}
