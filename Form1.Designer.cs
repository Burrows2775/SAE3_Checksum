namespace SAE3_Checksum
{
    partial class FORM_Calcul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_Calcul));
            this.BTN_Calcul = new System.Windows.Forms.Button();
            this.TB_Resultat = new System.Windows.Forms.TextBox();
            this.TBCTRL_Onglets = new System.Windows.Forms.TabControl();
            this.TBPG_Calculateur = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Entete = new System.Windows.Forms.TextBox();
            this.TBPG_Credits = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCTRL_Onglets.SuspendLayout();
            this.TBPG_Calculateur.SuspendLayout();
            this.TBPG_Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Calcul
            // 
            resources.ApplyResources(this.BTN_Calcul, "BTN_Calcul");
            this.BTN_Calcul.Name = "BTN_Calcul";
            this.BTN_Calcul.UseVisualStyleBackColor = true;
            this.BTN_Calcul.Click += new System.EventHandler(this.BTN_Calcul_Click);
            // 
            // TB_Resultat
            // 
            resources.ApplyResources(this.TB_Resultat, "TB_Resultat");
            this.TB_Resultat.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Resultat.Name = "TB_Resultat";
            this.TB_Resultat.ReadOnly = true;
            // 
            // TBCTRL_Onglets
            // 
            this.TBCTRL_Onglets.Controls.Add(this.TBPG_Calculateur);
            this.TBCTRL_Onglets.Controls.Add(this.TBPG_Credits);
            resources.ApplyResources(this.TBCTRL_Onglets, "TBCTRL_Onglets");
            this.TBCTRL_Onglets.Name = "TBCTRL_Onglets";
            this.TBCTRL_Onglets.SelectedIndex = 0;
            // 
            // TBPG_Calculateur
            // 
            this.TBPG_Calculateur.Controls.Add(this.label1);
            this.TBPG_Calculateur.Controls.Add(this.TB_Entete);
            this.TBPG_Calculateur.Controls.Add(this.BTN_Calcul);
            this.TBPG_Calculateur.Controls.Add(this.TB_Resultat);
            resources.ApplyResources(this.TBPG_Calculateur, "TBPG_Calculateur");
            this.TBPG_Calculateur.Name = "TBPG_Calculateur";
            this.TBPG_Calculateur.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TB_Entete
            // 
            resources.ApplyResources(this.TB_Entete, "TB_Entete");
            this.TB_Entete.CausesValidation = false;
            this.TB_Entete.Name = "TB_Entete";
            // 
            // TBPG_Credits
            // 
            this.TBPG_Credits.Controls.Add(this.label2);
            this.TBPG_Credits.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.TBPG_Credits, "TBPG_Credits");
            this.TBPG_Credits.Name = "TBPG_Credits";
            this.TBPG_Credits.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAE3_Checksum.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FORM_Calcul
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBCTRL_Onglets);
            this.Name = "FORM_Calcul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TBCTRL_Onglets.ResumeLayout(false);
            this.TBPG_Calculateur.ResumeLayout(false);
            this.TBPG_Calculateur.PerformLayout();
            this.TBPG_Credits.ResumeLayout(false);
            this.TBPG_Credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Calcul;
        private System.Windows.Forms.TextBox TB_Resultat;
        private System.Windows.Forms.TabControl TBCTRL_Onglets;
        private System.Windows.Forms.TabPage TBPG_Calculateur;
        private System.Windows.Forms.TabPage TBPG_Credits;
        private System.Windows.Forms.TextBox TB_Entete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

