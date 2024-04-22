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
        public Form2DetailOuvragecs(int idDuLivre)
        {
            InitializeComponent();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
