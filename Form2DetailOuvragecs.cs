using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
    public partial class Form2DetailOuvragecs : Form
    {
        DBConnection laConnexion = new DBConnection();
        int IdLivreSelect = 0;
        Livre selectedLivre = new Livre();
        Inventaire nouvelInventaire = new Inventaire();
        Tools Utilitaire = new Tools();
        public Form2DetailOuvragecs(Livre leLivre, DBConnection laCo)
        {
            selectedLivre = leLivre;
            laConnexion = laCo;
            InitializeComponent();
            labelLivre.Text = selectedLivre.Titre_Livre;
            TBTitre.Text = selectedLivre.Titre_Livre;
            TBAuteur.Text = selectedLivre.Auteur_Livre;
            TBEditeur.Text = selectedLivre.Editeur_Livre;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonInventorier_Click(object sender, EventArgs e)
        {
            nouvelInventaire.id_Livre_inventaire = selectedLivre.ID_Livre;
            nouvelInventaire.etat_inventaire = CBEtatLivre.Text;
            nouvelInventaire.commentaire_inventaire = TBCommentaire.Text;
            nouvelInventaire.date_inventaire = DateTime.Now;

            Utilitaire.NouveauInventaire(nouvelInventaire);
            InventorierLivre();

        }
        private void InventorierLivre()
        {
            PdfDocument document = new PdfDocument();
            // Ajout d'une page au document
            PdfPage page = document.AddPage();
            // Obtention du dessinateur pour la page
            XGraphics gfx = XGraphics.FromPdfPage(page);
            // Création d'une police
            XFont font = new XFont("Arial", 12.0, XFontStyle.Regular);
            // Dessin du texte sur la page avec les informations de selectedLivre
            gfx.DrawString($"Titre: {selectedLivre.Titre_Livre}", font, XBrushes.Black,
                new XRect(30, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"Auteur: {selectedLivre.Auteur_Livre}", font, XBrushes.Black,
                new XRect(30, 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

            gfx.DrawString($"Éditeur: {selectedLivre.Editeur_Livre}", font, XBrushes.Black,
                new XRect(30, 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString($"Etat: {nouvelInventaire.etat_inventaire}", font, XBrushes.Black,
             new XRect(30, 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString($"Commentaire: {nouvelInventaire.commentaire_inventaire}", font, XBrushes.Black,
             new XRect(30, 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            gfx.DrawString($"Date de l'enregistrement: {nouvelInventaire.date_inventaire}", font, XBrushes.Black,
             new XRect(30, 180, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
            // Définir le chemin du fichier PDF
            string pdfFilePath = "C:\\testPDF\\testPDF.pdf";
            // Sauvegarde du document PDF
            document.Save(pdfFilePath);
            // Fermeture du document
            document.Close();
            Console.WriteLine($"Le fichier PDF a été créé avec succès : {pdfFilePath}");
            // Ouvrir le fichier PDF après la création
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = pdfFilePath,
                UseShellExecute = true
            });
        }
    }
}
