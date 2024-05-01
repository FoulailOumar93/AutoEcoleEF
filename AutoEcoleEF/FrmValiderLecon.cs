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
    public partial class FrmValiderLecon : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmValiderLecon(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSlecon.DataSource = mesDonneesEF.lecons.ToList();
            this.bdgSvehicule.DataSource = mesDonneesEF.vehicules.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sauvegarder_Click(object sender, EventArgs e)
        {
            this.bdgSvehicule.EndEdit();
            this.bdgSlecon.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }
    }
}
