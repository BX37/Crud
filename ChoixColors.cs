using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class ChoixColors
    {
        // 1 bleu 2 rouge 3 vert
        public int Couleur { get; set; }
      public ChoixColors()
        {
            Couleur = 1;
        }
    }
    
}
