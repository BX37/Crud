using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Livre
    {
        public int Id_Livre {  get; set; }
        public string Identifiant_Livre { get; set; }   
        public int Numero_notice_BNF_Livre { get; set; }
        public string Type_notice_Livre { get; set; }
        public string Type_de_document_Livre { get; set; }
        public string Localisation_Livre { get; set; }
        public int Exemplaire_numero_Livre { get; set; }
        public string Titre_Livre { get; set; }
        public string Auteur_Livre { get; set; }
        public string Contributeur_Livre { get; set; }
        public string Editeur_Livre { get; set; }
        public int Date_Livre { get; set; }
        public string Description_Livre { get; set; }
        public string Sujet_Livre { get; set; }
        public string Couverture_Livre { get; set; }
        public string Langue_Livre { get; set; }
        public string Format_Livre { get; set; }

    }
}
