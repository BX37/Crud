using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class Livre
    {
        public int ID_Livre { get; set; }
        public string Identifiant_Livre { get; set; }   
        public int NoticeBNF_Livre { get; set; }
        public string TypeNotice_Livre { get; set; }
        public string TypeDocument_Livre { get; set; }
        public string Localisation_Livre { get; set; }
        public string Exemplaire_Livre { get; set; }
        public string Titre_Livre { get; set; }
        public string Auteur_Livre { get; set; }
        public string Editeur_Livre { get; set; }
        public string Date_Livre { get; set; }
        public string Description_Livre { get; set; }
        public string Sujet_Livre { get; set; }
        public string Langue_Livre { get; set; }
        public string Format_Livre { get; set; }

    }
}
