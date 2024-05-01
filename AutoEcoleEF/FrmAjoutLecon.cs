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
    public partial class FrmAjoutLecon : Form

    {
        private autoecoleEntities mesDonneesEF;
        public FrmAjoutLecon(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgEleve.DataSource = this.mesDonneesEF.eleve;
            for (int i = 8; i < 20; i++)
                this.CmbHeure.Items.Add(i);  
        }
        private int newNumLecon()
        {
            int n;
            int dernier = (from ra in this.mesDonneesEF.lecons
                           select ra.id).Max();
            n = dernier + 1;
            return n;

        }
        private lecon nouvellelecon()
        {
            int n = newNumLecon();
            eleve el = (eleve)cmbEleve.SelectedValue;
            DateTime d = this.dtLecon.Value;
            int HeureLecon = Convert.ToInt32(this.CmbHeure.SelectedItem);
            int nbHeures = 1;
            if (this.radioButton1.Checked)
                nbHeures = 2;
            lecon l = new lecon();
            l.date = d;
            l.heure = HeureLecon;
            l.duree = nbHeures;
            l.id = n;
            l.eleve = el;
            return l;
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            this.mesDonneesEF.lecons.Add(nouvellelecon());
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrenent Validé");
        }

        private void FrmAjoutLecon_Load(object sender, EventArgs e)
        {

        }
    }
}