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
    public partial class FrmMenu : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEF = new autoecoleEntities();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEF); 
            f.MdiParent = this;
            f.Show();
        }

       

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValiderLecon f = new FrmValiderLecon(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void gérerEtVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FrmGererVehicule f1 = new FrmGererVehicule(this.mesDonneesEF);
                f1.MdiParent = this;
                f1.Show();
        }

      
        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListeVehicule l = new FrmListeVehicule(this.mesDonneesEF);
            l.MdiParent = this;
            l.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutLecon l = new FrmAjoutLecon(this.mesDonneesEF);
            l.MdiParent = this;
            l.Show();
        }

        private void validerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           FrmValiderLecon v = new FrmValiderLecon(this.mesDonneesEF);
            v.MdiParent = this;
            v.Show();
        }
    }
}
