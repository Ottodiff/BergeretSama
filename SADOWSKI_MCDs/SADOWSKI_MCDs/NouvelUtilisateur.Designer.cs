namespace SADOWSKI_MCDs
{
    partial class NouvelUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.tbxMdp2 = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(32, 179);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(135, 179);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 7;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Entrez le mot de passe une 2 ème fois :";
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(32, 25);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(189, 20);
            this.tbxIdentifiant.TabIndex = 11;
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(32, 75);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(189, 20);
            this.tbxMdp.TabIndex = 12;
            // 
            // tbxMdp2
            // 
            this.tbxMdp2.Location = new System.Drawing.Point(32, 134);
            this.tbxMdp2.Name = "tbxMdp2";
            this.tbxMdp2.Size = new System.Drawing.Size(189, 20);
            this.tbxMdp2.TabIndex = 13;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.ForeColor = System.Drawing.Color.Red;
            this.lblMdp.Location = new System.Drawing.Point(15, 101);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(222, 13);
            this.lblMdp.TabIndex = 14;
            this.lblMdp.Text = "Les mots de passe entré ne corresponde pas.";
            this.lblMdp.Visible = false;
            // 
            // NouvelUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 219);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.tbxMdp2);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.tbxIdentifiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NouvelUtilisateur";
            this.Text = "Nouvel Utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxIdentifiant;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.TextBox tbxMdp2;
        private System.Windows.Forms.Label lblMdp;
    }
}