using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class Inventaire
    {
        public int id_inventaire {  get; set; }
        public int id_Livre_inventaire { get; set; }
        public string etat_inventaire { get; set; }
        public DateTime date_inventaire { get; set; }
        public string commentaire_inventaire { get; set; }
    }
}
