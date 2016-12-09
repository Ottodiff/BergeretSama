using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADOWSKI_MCDs
{
    public partial class NouvelUtilisateur : Form
    {

        public NouvelUtilisateur()
        {
            InitializeComponent();
            lblMdp.Visible = false;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Utilisateur ut = new Utilisateur();


            ut.Nom = tbxIdentifiant.Text;
            ut.Motdepasse = tbxMdp.Text;


            if (tbxMdp.Text == tbxMdp2.Text)
            {
                ut.nouvelUtilisateur();
                Form.ActiveForm.Close();
            }
            else
            {
                tbxMdp.Text = "";
                tbxMdp2.Text = "";

                lblMdp.Visible = true;
                tbxMdp.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();            
        }
    }
}
