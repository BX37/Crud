using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class Utilisateur
    {
        public int UtilisateurID { get; set; }
        public string UtilisateurNom { get; set; }
        public string UtilisateurPrenom { get; set; } 
        public string UtilisateurLogin { get; set; }  
        public string UtilisateurMDP { get; set; }
        public string UtilisateurNiveau { get; set; }
        public Boolean UtilisateurArchive { get; set; }
        public DateTime UtilisateurDerniereConnexion { get; set; }
        public DateTime UtilisateurDerniereDeconnexion { get; set; }
        public int UtilisateurNbMauvaisMDP { get; set; }
    }
}
