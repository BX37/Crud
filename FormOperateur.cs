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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Fonts;

namespace Crud
{
    public partial class FormOperateur : Form
    {
        Tools utilitaire = new Tools();
        DBConnection laConnexion = new DBConnection();
        Utilisateur userCo = new Utilisateur();
        Log LogPourDeco = new Log();
        List<Livre> ListInventorier = new List<Livre>();
        Livre selectedLivre = new Livre();

        public FormOperateur(Utilisateur utilisateurCo, Log leLog)
        {
            InitializeComponent();
            laConnexion.Server = "localhost";
            laConnexion.DatabaseName = "belletable";
            laConnexion.UserName = "root";
            laConnexion.Password = Crypto.Decrypt("Wmij8pPWECP0WBekexqbrA==");
            userCo = utilisateurCo;
            LogPourDeco = leLog;
            RemplirDGVLivre();
            DGVLivre.Refresh();
            this.FormClosed += new FormClosedEventHandler(MAJ);
        }

        private void MAJ(object sender, FormClosedEventArgs e)
        {
            utilitaire.MAJDateTimeDeco(laConnexion, userCo);
            utilitaire.logDeconnexionMAJ(laConnexion, userCo, LogPourDeco);
        }
        public void RemplirDGVLivre()
        {
            if (laConnexion.IsConnect())
            {
                string query2 = "select *  from livre where ID_Livre not in(select ID_Livre from inventaire) limit 30;";
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

                    ListInventorier.Add(LeLivre);
                }
                reader12.Close();
            }
            DGVLivre.DataSource = ListInventorier;
            DGVLivre.Columns["Titre_Livre"].Width = 271;
            DGVLivre.Columns["Auteur_Livre"].Width = 271;
            DGVLivre.Columns["Editeur_Livre"].Width = 271;
            DGVLivre.Columns["ID_Livre"].Visible = false;
            DGVLivre.Columns["Identifiant_Livre"].Visible = false;
            DGVLivre.Columns["NoticeBNF_Livre"].Visible = false;
            DGVLivre.Columns["TypeNotice_Livre"].Visible = false;
            DGVLivre.Columns["TypeDocument_Livre"].Visible = false;
            DGVLivre.Columns["Localisation_Livre"].Visible = false;
            DGVLivre.Columns["Exemplaire_Livre"].Visible = false;
            DGVLivre.Columns["Date_Livre"].Visible = false;
            DGVLivre.Columns["Description_Livre"].Visible = false;
            DGVLivre.Columns["Sujet_Livre"].Visible = false;
            DGVLivre.Columns["Langue_Livre"].Visible = false;
            DGVLivre.Columns["Format_Livre"].Visible = false;
        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {
            FormOuvrage formOuvrage = new FormOuvrage(laConnexion, userCo, LogPourDeco);
            DialogResult result = formOuvrage.ShowDialog();
            this.Visible = false;

            if (result == DialogResult.OK)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
            this.Visible = true;
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DGVLivre.SelectedRows[0];
            selectedLivre = (Livre)row.DataBoundItem;
            Livre LivreSelection = new Livre();
            LivreSelection = selectedLivre;
            this.Visible = false;
            Form2DetailOuvragecs FormDetail = new Form2DetailOuvragecs(LivreSelection, laConnexion, LogPourDeco, userCo);
            DialogResult result = FormDetail.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
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
