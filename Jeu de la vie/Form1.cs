using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeu_de_la_vie
{
    public partial class Form1 : Form
    {
        public Form1()        
        {            
            InitializeComponent();
        }
            const int TAILLE = 20;
            int VITESSE = 550;
            bool Detail = false;
        bool etape=true;
            PictureBox[] cases = new PictureBox[TAILLE * TAILLE];
            Timer timer = new Timer();//add
            int[,] vie = new int[TAILLE, TAILLE];
            int[,] Voisins = new int[TAILLE, TAILLE];//add


        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = VITESSE;
            int largeur = picVrai.Size.Width; //espace largeur
            int hauteur = picVrai.Size.Height;//espace hauteur
            this.Size = new Size((largeur + 2) * (TAILLE + 10), (largeur + 2) * (TAILLE + 4) + 30); // taille avec marges
            this.SuspendLayout();
            for (int j = 0; j < TAILLE; j++)
            {
                for (int i = 0; i < TAILLE; i++)
                {
                    //Construit les object colonnes puis lignes : 
                    //j,i
                    //0,0 0,1 0,2.....1,0 1,1....20,20
                    cases[j * TAILLE + i] = new PictureBox(); //nouvelle instance Picture
                    cases[j * TAILLE + i].Location = new Point((i + 1) * (largeur + 2), (j + 1) * (hauteur + 2) + 20);//positionne le 
                    cases[j * TAILLE + i].BackColor = picVide.BackColor; 
                    cases[j * TAILLE + i].BorderStyle = picVide.BorderStyle;
                    cases[j * TAILLE + i].Size = picVrai.Size;
                    cases[j * TAILLE + i].Click += new EventHandler(Commun_Click);  // création évènement
                    this.Controls.Add(this.cases[j * TAILLE + i]);                  // ajout de l'objet

                    vie[j, i] = 0; // Reset la matrice IMAGE
                }
            }
            picVide.Visible = picVrai.Visible = picMort.Visible = picNe.Visible = false;
            this.ResumeLayout(false);   // redessiner
        }

        void timer_Tick(object sender, EventArgs e)//add
        {
            if (Detail)
                etape = !etape;
            else
            {
                etape = true;
            }
            if ((!etape) || (!Detail))
            {
                for (int j = 0; j < TAILLE; j++)
                {
                    for (int i = 0; i < TAILLE; i++)
                    {
                        LocVoisins(j, i);
                    }
                }
                RefreshEtat();
            }
            if (etape)
            {
                RefreshEtat2();
            }


        }
        void RefreshEtat()//va la dedans 1/2 si pas à pas
        {
            for (int j = 0; j < TAILLE; j++)
            {
                for (int i = 0; i < TAILLE; i++)
                {
                    if (Voisins[j, i] == 2)
                    {
                        //rien
                    }
                    else if (Voisins[j, i] == 3)
                    {
                        //naissance
                        if (vie[j, i] != 1)
                        {
                            vie[j, i] = 3;
                        }
                        cases[j * TAILLE + i].Image = picVrai.Image;
                    }
                    else
                    {
                        if (vie[j, i] == 1)
                        {
                            vie[j, i] = 2;
                        }
                        cases[j * TAILLE + i].Image = null;
                    }
                }
            }
        }
        void RefreshEtat2()//va la dedans 1/2 si pas à pas
        {
            for (int j = 0; j < TAILLE; j++)
            {
                for (int i = 0; i < TAILLE; i++)
                {
                     if (vie[j, i] == 3)
                    {
                        //naissance
                        vie[j, i] = 1;//add
                        if (Detail)
                        {
                            cases[j * TAILLE + i].Image = picNe.Image;
                        }
                    }
                    else if (vie[j, i] == 2)
                    {
                            //Meur
                            vie[j, i] = 0;//add
                            if (Detail)
                            {
                                cases[j * TAILLE + i].Image = picMort.Image;
                            }
                    }
                }
            }
        }
        //            _________
        //___________/On clique\____________________
        // inversion de son état par l'image de fond
        void Commun_Click(object sender, EventArgs e)
        {
            bool trouvee = false;
            int lg, col = 0; // recherche de la case cliquée
            for (lg = 0; lg < TAILLE; lg++)
            {
                for (col = 0; col < TAILLE; col++)
                    if (sender == cases[lg * TAILLE + col])
                    {
                        trouvee = true;
                        break;
                    }
                if (trouvee) break;
            }

            if (vie[lg, col] == 0)
            {
                cases[lg * TAILLE + col].Image = picVrai.Image;
                lbl_Col.Text = col.ToString();
                Lbl_Ligne.Text = lg.ToString();
            }
            else {
                cases[lg * TAILLE + col].Image = null;
            }
            vie[lg, col] = 1 - vie[lg, col];//met à 1 si c'est a zero et 0 si 1
        }


        public void LocVoisins(int ligne, int colonne)
        {
            int voisin = 0;
            int ligneEnCour, colonneEnCour;
            int cellule = vie[ligne, colonne];

            for (int i = (ligne - 1); i <= (ligne + 1); i++)
            {
                for (int j = (colonne - 1); j <= (colonne + 1); j++)
                {
                    ligneEnCour = (i + TAILLE) % TAILLE;  //torique 
                    colonneEnCour = (j + TAILLE) % TAILLE;

                    if (vie[ligneEnCour,colonneEnCour] == 1)
                        voisin++;
                }
            }

            voisin = voisin-cellule;          // On ne compte pas la cellule elle même
            Voisins[ligne, colonne] = voisin;
        }

        private void lentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lentToolStripMenuItem.Checked = true;
            moyenToolStripMenuItem.Checked = false;
            rapideToolStripMenuItem.Checked = false;
            actToolStripMenuItem.Text = "Actualisation : 1000 ms";
            VITESSE = 1000;
        }

        private void moyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lentToolStripMenuItem.Checked = false;
            moyenToolStripMenuItem.Checked = true;
            rapideToolStripMenuItem.Checked = false;
            VITESSE = 550;
            actToolStripMenuItem.Text = "Actualisation : 550 ms";
        }

        private void rapideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lentToolStripMenuItem.Checked = false;
            moyenToolStripMenuItem.Checked = false;
            rapideToolStripMenuItem.Checked = true;
            VITESSE = 100;
            actToolStripMenuItem.Text = "Actualisation : 100 ms";
        }

        private void marcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
            marcheToolStripMenuItem.Checked = true;
            arretToolStripMenuItem.Checked = false;
            actToolStripMenuItem.Enabled = true;
        }

        private void arretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            marcheToolStripMenuItem.Checked = false;
            arretToolStripMenuItem.Checked = true;
            actToolStripMenuItem.Enabled = false;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= new EventHandler(timer_Tick);
            for (int j = 0; j < TAILLE; j++)
            {
                for (int i = 0; i < TAILLE; i++)
                {
                    vie[j, i] = 0;
                    Voisins[j, i] = 0;
                    cases[j * TAILLE + i].Image = null;
                }
            }
        }

        private void marcheToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (marcheToolStripMenuItem.Checked==true)
            {
                nouveauToolStripMenuItem.Enabled = false;
            }
            else
            {
                nouveauToolStripMenuItem.Enabled = true;
            }
        }

        private void detailléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detailléToolStripMenuItem.Checked==false)
            {
                detailléToolStripMenuItem.Checked = true;
                Detail = true;
            }
            else{
                detailléToolStripMenuItem.Checked = true;
                Detail = false;
            }
        }
    }
}
