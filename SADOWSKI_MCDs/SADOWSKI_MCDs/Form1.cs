using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SADOWSKI_MCDs
{
    public partial class Form1 : Form
    {
        Connexion co = new Connexion();
        NouvelUtilisateur nu = new NouvelUtilisateur();

        private string _idQuestionnaire;

        public string IdQuestionnaire
        {
            get { return _idQuestionnaire; }
            set { _idQuestionnaire = value; }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string idQuestionnaire)
        {
            this.IdQuestionnaire = idQuestionnaire;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            co.EstCo = false;
            deconnexionToolStripMenuItem.Text = "Connexion";

            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= MCDs.db");
            sqlconnection.Open();

            string CommandText = "SELECT * FROM questionnaires";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                lbxQuestionnaire.Items.Add(sqldr["idQuestionnaire"]);
            }
        }

        private bool ConfirmQuitAppli()
        {
            // message confirmation quitter l'application
            if (MessageBox.Show("Quitter l'application?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            };

            // oui, quitter
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //demande confirmation pour fermer l'application
            if (ConfirmQuitAppli() == false)
            {
                e.Cancel = true;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //quitte l'application
            Application.Exit();
        }        

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //affiche la form a propos
            FormAPropos aPropos = new FormAPropos();
            aPropos.ShowDialog();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (co.EstCo == true)
            {
                co.EstCo = false;
                deconnexionToolStripMenuItem.Text = "Connexion";

                nouvelUtilisateurToolStripMenuItem.Visible = true;
                nouvellePartieToolStripMenuItem.Visible = false;
                ScoreToolStripMenuItem.Visible = false;
            }
            else
            {
                //affiche la fenetre de connexion
                co.EstCo = true;
                co.ShowDialog();
                deconnexionToolStripMenuItem.Text = "Deconnexion";

                nouvelUtilisateurToolStripMenuItem.Visible = false;
                nouvellePartieToolStripMenuItem.Visible = true;
                ScoreToolStripMenuItem.Visible = true;
            }
        }

        private void nouvelUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nu.ShowDialog();
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            //quest.Q1 = lbxQuestionnaire.SelectedText.ToString();
            //lblq1.Text = quest.R1;
            this.IdQuestionnaire = lbxQuestionnaire.Text;

            Questionnaire quest = new Questionnaire(this);

            quest.recupererQuestionnaire();
        }
    }
}
