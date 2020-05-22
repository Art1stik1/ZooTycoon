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
            int[,] array2D = new int[,] {{133,133,133,133,244,244,244,244,244,244,244,244,244,23,397,398,399,23,244,244,244,244,244,244,244,244,244,244,244,244},
{163,163,163,163,244,244,244,244,244,244,244,244,244,53,427,428,429,53,244,244,244,244,244,244,244,244,244,244,244,244},
{193,193,193,193,244,244,244,244,244,244,244,244,244,83,427,428,429,83,244,244,244,244,244,244,244,244,244,244,244,244},
{223,224,225,226,397,398,398,398,398,398,398,398,398,398,428,428,428,398,398,398,398,398,398,398,398,398,398,398,398,398},
{223,224,255,226,427,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428},
{211,211,211,211,427,428,428,458,458,458,458,458,458,458,428,428,428,458,458,458,458,458,458,458,458,458,458,458,458,458},
{211,211,211,211,427,428,429,160,161,162,160,160,161,162,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,427,428,429,160,394,395,395,395,396,162,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,427,428,429,190,424,425,425,425,426,192,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,427,428,429,220,424,425,425,425,426,222,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,427,428,429,160,424,425,425,425,426,162,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,427,428,429,190,454,455,455,455,456,192,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,427,428,429,220,221,222,222,220,221,222,427,428,429,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,428,428,428,398,398,398,398,398,398,398,428,428,428,398,398,398,398,398,398,398,398,398,398,398,398,398},
{211,211,211,211,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428,428},
{211,211,211,211,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458,458},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211},
{211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211,211 } };



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
                        case 244:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.GRASS), (32 * (j)), 22 + (32 * i));
                            break;
                        case 211:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.EAU), (32 * (j)), 22 + (32 * i));
                            break;
                        case 398:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 428:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (j)), 22 + (32 * i));
                            break;
                        case 458:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_INFERRIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 70:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR), (32 * (j)), 22 + (32 * i));
                            break;
                        case 71:
                            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_CENTRE), (32 * (j)), 22 + (32 * i));
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
