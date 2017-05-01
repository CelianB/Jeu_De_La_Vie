namespace Jeu_de_la_vie
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
            this.picMort = new System.Windows.Forms.PictureBox();
            this.picNe = new System.Windows.Forms.PictureBox();
            this.picVrai = new System.Windows.Forms.PictureBox();
            this.picVide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Ligne = new System.Windows.Forms.Label();
            this.lbl_Col = new System.Windows.Forms.Label();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vitesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actToolStripMenuItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVide)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMort
            // 
            this.picMort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMort.Image = global::Jeu_de_la_vie.Properties.Resources.vie_Mort;
            this.picMort.Location = new System.Drawing.Point(132, 52);
            this.picMort.Name = "picMort";
            this.picMort.Size = new System.Drawing.Size(15, 15);
            this.picMort.TabIndex = 3;
            this.picMort.TabStop = false;
            // 
            // picNe
            // 
            this.picNe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNe.Image = global::Jeu_de_la_vie.Properties.Resources.vie_Naissance;
            this.picNe.Location = new System.Drawing.Point(99, 52);
            this.picNe.Name = "picNe";
            this.picNe.Size = new System.Drawing.Size(15, 15);
            this.picNe.TabIndex = 2;
            this.picNe.TabStop = false;
            // 
            // picVrai
            // 
            this.picVrai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVrai.Image = global::Jeu_de_la_vie.Properties.Resources.vie_Vrai;
            this.picVrai.Location = new System.Drawing.Point(99, 18);
            this.picVrai.Name = "picVrai";
            this.picVrai.Size = new System.Drawing.Size(15, 15);
            this.picVrai.TabIndex = 1;
            this.picVrai.TabStop = false;
            // 
            // picVide
            // 
            this.picVide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picVide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVide.Location = new System.Drawing.Point(15, 18);
            this.picVide.Name = "picVide";
            this.picVide.Size = new System.Drawing.Size(56, 49);
            this.picVide.TabIndex = 0;
            this.picVide.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ligne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Colonne :";
            // 
            // Lbl_Ligne
            // 
            this.Lbl_Ligne.AutoSize = true;
            this.Lbl_Ligne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ligne.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Ligne.Location = new System.Drawing.Point(461, 74);
            this.Lbl_Ligne.Name = "Lbl_Ligne";
            this.Lbl_Ligne.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Ligne.TabIndex = 6;
            this.Lbl_Ligne.Text = "0";
            // 
            // lbl_Col
            // 
            this.lbl_Col.AutoSize = true;
            this.lbl_Col.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Col.ForeColor = System.Drawing.Color.Red;
            this.lbl_Col.Location = new System.Drawing.Point(461, 108);
            this.lbl_Col.Name = "lbl_Col";
            this.lbl_Col.Size = new System.Drawing.Size(21, 24);
            this.lbl_Col.TabIndex = 7;
            this.lbl_Col.Text = "0";
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.marcheToolStripMenuItem,
            this.arretToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.etatToolStripMenuItem.Text = "Etat";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // marcheToolStripMenuItem
            // 
            this.marcheToolStripMenuItem.Name = "marcheToolStripMenuItem";
            this.marcheToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.marcheToolStripMenuItem.Text = "Marche";
            this.marcheToolStripMenuItem.CheckedChanged += new System.EventHandler(this.marcheToolStripMenuItem_CheckedChanged);
            this.marcheToolStripMenuItem.Click += new System.EventHandler(this.marcheToolStripMenuItem_Click);
            // 
            // arretToolStripMenuItem
            // 
            this.arretToolStripMenuItem.Checked = true;
            this.arretToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.arretToolStripMenuItem.Name = "arretToolStripMenuItem";
            this.arretToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arretToolStripMenuItem.Text = "Arret";
            this.arretToolStripMenuItem.Click += new System.EventHandler(this.arretToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etatToolStripMenuItem,
            this.vitesseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vitesseToolStripMenuItem
            // 
            this.vitesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lentToolStripMenuItem,
            this.moyenToolStripMenuItem,
            this.rapideToolStripMenuItem,
            this.detailléToolStripMenuItem});
            this.vitesseToolStripMenuItem.Name = "vitesseToolStripMenuItem";
            this.vitesseToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.vitesseToolStripMenuItem.Text = "Vitesse";
            // 
            // lentToolStripMenuItem
            // 
            this.lentToolStripMenuItem.Name = "lentToolStripMenuItem";
            this.lentToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.lentToolStripMenuItem.Text = "Lent";
            this.lentToolStripMenuItem.Click += new System.EventHandler(this.lentToolStripMenuItem_Click);
            // 
            // moyenToolStripMenuItem
            // 
            this.moyenToolStripMenuItem.Checked = true;
            this.moyenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moyenToolStripMenuItem.Name = "moyenToolStripMenuItem";
            this.moyenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.moyenToolStripMenuItem.Text = "Moyen";
            this.moyenToolStripMenuItem.Click += new System.EventHandler(this.moyenToolStripMenuItem_Click);
            // 
            // rapideToolStripMenuItem
            // 
            this.rapideToolStripMenuItem.Name = "rapideToolStripMenuItem";
            this.rapideToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.rapideToolStripMenuItem.Text = "Rapide";
            this.rapideToolStripMenuItem.Click += new System.EventHandler(this.rapideToolStripMenuItem_Click);
            // 
            // detailléToolStripMenuItem
            // 
            this.detailléToolStripMenuItem.Name = "detailléToolStripMenuItem";
            this.detailléToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.detailléToolStripMenuItem.Text = "Detaillé";
            this.detailléToolStripMenuItem.Click += new System.EventHandler(this.detailléToolStripMenuItem_Click);
            // 
            // actToolStripMenuItem
            // 
            this.actToolStripMenuItem.AutoSize = true;
            this.actToolStripMenuItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actToolStripMenuItem.Enabled = false;
            this.actToolStripMenuItem.Location = new System.Drawing.Point(0, 190);
            this.actToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.actToolStripMenuItem.Name = "actToolStripMenuItem";
            this.actToolStripMenuItem.Size = new System.Drawing.Size(110, 13);
            this.actToolStripMenuItem.TabIndex = 9;
            this.actToolStripMenuItem.Text = "Actualisation : 550 ms";
            this.actToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 203);
            this.Controls.Add(this.actToolStripMenuItem);
            this.Controls.Add(this.lbl_Col);
            this.Controls.Add(this.Lbl_Ligne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMort);
            this.Controls.Add(this.picNe);
            this.Controls.Add(this.picVrai);
            this.Controls.Add(this.picVide);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jeu de la vie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVide)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picVide;
        private System.Windows.Forms.PictureBox picVrai;
        private System.Windows.Forms.PictureBox picNe;
        private System.Windows.Forms.PictureBox picMort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Ligne;
        private System.Windows.Forms.Label lbl_Col;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vitesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapideToolStripMenuItem;
        private System.Windows.Forms.Label actToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailléToolStripMenuItem;
    }
}

