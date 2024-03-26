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
    public partial class FormUtilitaire : Form
    {
        public FormUtilitaire()
        {
            InitializeComponent();
        }

        private void buttonDeviensCrypte_Click(object sender, EventArgs e)
        {
            TBMDPCypte.Text = Crypto.Encrypt(TBMDP.Text);
            
        }
    }
}
