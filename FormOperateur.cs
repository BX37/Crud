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
        Log LogEnCours = new Log();
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
            LogEnCours = leLog;
            DGVLivre.Refresh();
        }
        private void MAJ(object sender, FormClosedEventArgs e)
        {
            utilitaire.MAJDateTimeDeco(laConnexion, userCo);
            utilitaire.logDeconnexionMAJ(laConnexion, userCo, LogEnCours);
        }
        public void RemplirDGVLivre()
        {
            if (laConnexion.IsConnect())
            {
                string query2 = "select ID_Livre, Titre, Editeur, noticeBNF from livre where ID_Livre not in(select ID_Livre from inventaire) limit 30;";
                var cmd2 = new MySqlCommand(query2, laConnexion.Connection);
                var reader12 = cmd2.ExecuteReader();

                while (reader12.Read())
                {
                    Livre LeLivre = new Livre
                    {
                        ID_Livre = (int)reader12["ID_livre"],
                        NoticeBNF_Livre = (int)reader12["NoticeBNF"],
                        Titre_Livre = (string)reader12["Titre"],
                        Editeur_Livre = (string)reader12["Editeur"],
                    };

                    ListInventorier.Add(LeLivre);
                }
                reader12.Close();
            }
            DGVLivre.Columns["ID_livre"].Visible = false;
            DGVLivre.DataSource = ListInventorier;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            // Ajout d'une page au document
            PdfPage page = document.AddPage();
            // Obtention du dessinateur pour la page
            XGraphics gfx = XGraphics.FromPdfPage(page);
            // Création d'une police
            XFont font = new XFont("Arial", 12.0, XFontStyle.Regular);
            // Dessin du texte sur la page
            gfx.DrawString("Ceci est un exemple de texte dans un fichier PDF créé avec C#.", font,
           XBrushes.Black,
            new XRect(30, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            // Sauvegarde du document PDF
            string pdfFilePath = "C:\\testPDF\\testPDF.pdf";
            document.Save(pdfFilePath);
            // Fermeture du document
            document.Close();
            Console.WriteLine($"Le fichier PDF a été créé avec succès : {pdfFilePath}");

        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {
            FormOuvrage formOuvrage = new FormOuvrage();
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
            int idLivre = selectedLivre.ID_Livre;
            this.Visible = false;
            Form2DetailOuvragecs FormDetail = new Form2DetailOuvragecs(idLivre);
            DialogResult result = FormDetail.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
            this.Visible = true;
        }
    }
}
