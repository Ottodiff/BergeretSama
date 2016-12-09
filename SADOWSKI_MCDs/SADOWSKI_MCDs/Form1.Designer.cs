namespace SADOWSKI_MCDs
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFaireQuetionnaire = new System.Windows.Forms.Button();
            this.lbxQuestionnaire = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblq1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.nouvelUtilisateurToolStripMenuItem,
            this.nouvellePartieToolStripMenuItem,
            this.ScoreToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deconnexionToolStripMenuItem.Text = "Connexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // nouvelUtilisateurToolStripMenuItem
            // 
            this.nouvelUtilisateurToolStripMenuItem.Name = "nouvelUtilisateurToolStripMenuItem";
            this.nouvelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nouvelUtilisateurToolStripMenuItem.Text = "Nouvel Utilisateur";
            this.nouvelUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.nouvelUtilisateurToolStripMenuItem_Click);
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            this.nouvellePartieToolStripMenuItem.Visible = false;
            // 
            // ScoreToolStripMenuItem
            // 
            this.ScoreToolStripMenuItem.Name = "ScoreToolStripMenuItem";
            this.ScoreToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ScoreToolStripMenuItem.Text = "Mes scores";
            this.ScoreToolStripMenuItem.Visible = false;
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aProposToolStripMenuItem.Text = "?";
            // 
            // aProposToolStripMenuItem1
            // 
            this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem1.Text = "A propos";
            this.aProposToolStripMenuItem1.Click += new System.EventHandler(this.aProposToolStripMenuItem1_Click);
            // 
            // btnFaireQuetionnaire
            // 
            this.btnFaireQuetionnaire.Location = new System.Drawing.Point(12, 43);
            this.btnFaireQuetionnaire.Name = "btnFaireQuetionnaire";
            this.btnFaireQuetionnaire.Size = new System.Drawing.Size(131, 23);
            this.btnFaireQuetionnaire.TabIndex = 2;
            this.btnFaireQuetionnaire.Text = "Faire le questionnaire";
            this.btnFaireQuetionnaire.UseVisualStyleBackColor = true;
            this.btnFaireQuetionnaire.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            // 
            // lbxQuestionnaire
            // 
            this.lbxQuestionnaire.FormattingEnabled = true;
            this.lbxQuestionnaire.Location = new System.Drawing.Point(149, 45);
            this.lbxQuestionnaire.Name = "lbxQuestionnaire";
            this.lbxQuestionnaire.Size = new System.Drawing.Size(192, 21);
            this.lbxQuestionnaire.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblq1);
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 371);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblq1
            // 
            this.lblq1.AutoSize = true;
            this.lblq1.Location = new System.Drawing.Point(48, 26);
            this.lblq1.Name = "lblq1";
            this.lblq1.Size = new System.Drawing.Size(35, 13);
            this.lblq1.TabIndex = 0;
            this.lblq1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxQuestionnaire);
            this.Controls.Add(this.btnFaireQuetionnaire);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouvelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScoreToolStripMenuItem;
        private System.Windows.Forms.Button btnFaireQuetionnaire;
        private System.Windows.Forms.ComboBox lbxQuestionnaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblq1;
    }
}

