using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcoleEF
{
    public partial class FrmListeVehicule : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmListeVehicule(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgVehicules.DataSource = mesDonneesEF.vehicules.ToList();
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.bdgVehicules.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }
    }
}
