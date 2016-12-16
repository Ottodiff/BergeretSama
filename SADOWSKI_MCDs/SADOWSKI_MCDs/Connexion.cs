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
    public partial class Connexion : Form
    {
        private bool _estCo;

        public bool EstCo
        {
            get { return _estCo; }
            set { _estCo = value; }
        }

        public Connexion(bool estCo)
        {
            EstCo = estCo;
        }

        public Connexion():this(false)
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Utilisateur uti = new Utilisateur();

            uti.Nom = tbxIdentifiant.Text;
            uti.Motdepasse = tbxMdp.Text;

            label3.Visible = false;

            if (uti.login() == true)
            {
                MessageBox.Show("Connecté");
                Form.ActiveForm.Close();
                label3.Visible = false;
            }
            else 
            {
                label3.Visible = true;
                tbxIdentifiant.Text = uti.Nom;
                tbxMdp.Text = "";
                tbxMdp.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
