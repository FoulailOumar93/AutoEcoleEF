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
    public partial class FrmGererEleve : Form
    {
        private autoecoleEntities mesDonneesEF;

        public FrmGererEleve(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                this.cmbCredit.Items.Add(i);
            }
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceEleve.DataSource = mesDonneesEF.eleves.ToList();

        }


        private int getNumEleve()
        {
            var regDernier = from el in this.mesDonneesEF.eleves
                             orderby el.id descending
                             select el;
            eleve dernierEleve = regDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }


        
        private eleve NewEleve()
        {
            eleve newEleve = new eleve();
            newEleve.id = Convert.ToInt16(txtNum.Text);
            newEleve.nom = txtNom.Text;
            newEleve.prenom = txtPrenom.Text;
            newEleve.adresse = txtAdresse.Text;
            newEleve.dateInscription = dtInscription.Value;
            return newEleve;
        }

        private void bindingNavigatorMoveFirstItem_Click_1(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs du nouvelle élève");
                bdgSourceEleve.CancelEdit();
            }
        }

        private void bindingNavigatorMovePreviousItem_Click_1(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs du nouvel élève");
                bdgSourceEleve.CancelEdit();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new autoecoleEntities())
            {
                var idASupprimer = Convert.ToInt16(txtNum.Text);
                var entiteASupprimer = context.eleves.FirstOrDefault(el => el.id == idASupprimer);
                if (entiteASupprimer != null)
                {
                    context.eleves.Remove(entiteASupprimer);
                    context.SaveChanges();
                    bdgSourceEleve.RemoveCurrent();
                    MessageBox.Show("Enregistrement supprimé");
                }
            }
        }

        private void Sauvegarder_Click_1(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            try
            {
                this.mesDonneesEF.eleves.Add(NewEleve());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement :   {ex.Message}");

            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            this.txtNum.Text = this.getNumEleve().ToString();
        }

        private void FrmGererEleve_Load(object sender, EventArgs e)
        {

        }
    }
}