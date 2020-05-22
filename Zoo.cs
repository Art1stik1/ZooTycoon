using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTycoon
{
    public partial class Zoo : Form
    {
        PictureBox hero;
        public Zoo()
        {


            InitializeComponent();

        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int[,] array2D = new int[,] {{133,133,133,133,246,246,246,246,246,246,246,246,246,23,397,398,399,23,246,246,246,246,246,246,246,246,246,246,246,246},
{163,163,163,163,246,246,246,246,246,246,246,246,246,53,427,428,429,53,246,246,246,246,246,246,246,246,246,246,246,246},
{193,193,193,193,246,246,246,246,246,246,246,246,246,83,427,428,429,83,246,246,246,246,246,246,246,246,246,246,246,246},
{223,224,225,226,397,398,398,398,398,398,398,398,398,398,428,428,428,398,398,398,398,398,398,398,398,398,398,398,398,398},
{223,224,255,226,427,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428},
{246,246,246,246,427,428,428,458,458,458,458,458,458,458,428,428,428,458,458,458,458,458,458,458,458,458,458,458,458,458},
{246,246,246,246,427,428,429,211,211,211,211,211,211,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,427,428,429,211,394,395,395,395,396,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,427,428,429,211,424,425,425,425,426,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,427,428,429,211,424,425,425,425,426,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,427,428,429,211,424,425,425,425,426,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,427,428,429,211,454,455,455,455,456,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,427,428,429,211,211,211,211,211,211,211,427,428,429,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,428,428,428,398,398,398,398,398,398,398,428,428,428,398,398,398,398,398,398,398,398,398,398,398,398,398},
{246,246,246,246,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428},
{246,246,246,246,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246},
{246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246,246}};



            for (int i = 0; i < 28; i++)
            {

                for (int j = 0; j < 30; j++)
                {
                    switch (array2D.GetValue(i, j))
                    {
                        case 133:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_HAUT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 163:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_MILIEU), (32 * (j)), 22 + (32 * i));
                            break;
                        case 193:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_BAS), (32 * (j)), 22 + (32 * i));
                            break;
                        case 223:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_GAUCHE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 224:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_MILIEU), (32 * (j)), 22 + (32 * i));
                            break;
                        case 225:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_PORTE_HAUT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 226:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_DROIT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 255:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_PORTE_BAS), (32 * (j)), 22 + (32 * i));
                            break;
                        case 246:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.GRASS), (32 * (j)), 22 + (32 * i));
                            break;
                        case 211:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.EAU), (32 * (j)), 22 + (32 * i));
                            break;
                        case 398:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 397:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR_GAUCHE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 399:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR_DROIT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 427:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_GAUCHE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 429:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_DROIT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 428:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 458:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_INFERRIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 394:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR_GAUCHE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 395:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 396:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR_DROIT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 424:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_GAUCHE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 426:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_DROIT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 454:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_INFERIEUR_GAUCHE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 455:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_INFERIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 456:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_INFERIEUR_DROIT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 425:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_CENTRE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 23:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.COLONNE_HAUT), (32 * (j)), 22 + (32 * i));
                            break;
                        case 53:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.COLONNE_CENTRE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 83:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.COLONNE_BAS), (32 * (j)), 22 + (32 * i));
                            break;
                        case 160:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_PIERRE), (32 * (j)), 22 + (32 * i));
                            break;
                        default:
                            break;
                    }

                }

            }


        }

        private void Zoo_Load(object sender, EventArgs e)
        {

            hero = new PictureBox
            {
                Image = ZooTycoon.Properties.Resources.Yoshi
            };

            hero.Location = new System.Drawing.Point((32 * (21)), 22 + (32 * 1));



            this.Controls.Add(hero);
            hero.BringToFront();
        }

        private void Zoo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    hero.Top -= 32;
                    break;
                case Keys.A:
                    hero.Left -= 32;
                    break;
                case Keys.S:
                    hero.Top += 32;
                    break;
                case Keys.D:
                    hero.Left += 32;
                    break;
            }
        }
    }
}
