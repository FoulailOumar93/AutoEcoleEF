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
    public partial class FrmGererVehicule : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmGererVehicule(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgVehicules.DataSource = mesDonneesEF.vehicules.ToList();
        }
       
        

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtModele.Text == "" || txtCouleur.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs");
                bdgVehicules.CancelEdit();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new autoecoleEntities())
            {
                var idASupprimer = Convert.ToString(txtNumero.Text);
                var entierASupprimer = context.vehicules.FirstOrDefault(vl => vl.numImma == idASupprimer);

                if (entierASupprimer != null)
                {
                    context.vehicules.Remove(entierASupprimer);
                    context.SaveChanges();
                    bdgVehicules.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }
        private vehicule NewVehicule()  
        {
            vehicule newVehicule = new vehicule();
            newVehicule.numImma = txtNumero.Text;
            newVehicule.modele = txtModele.Text;
            newVehicule.couleur = txtCouleur.Text;
            return newVehicule;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "" || txtModele.Text == "" || txtCouleur.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs");
                bdgVehicules.CancelEdit();
            }
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNumero.ReadOnly = false;
            this.txtModele.ReadOnly = false;
            this.txtCouleur.ReadOnly = false;
        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            this.bdgVehicules.EndEdit();
            try
            {
                this.mesDonneesEF.vehicules.Add(NewVehicule());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement :   {ex.Message}");

            }
        }

        private void FrmGererVehicule_Load(object sender, EventArgs e)
        {

        }
    }
}