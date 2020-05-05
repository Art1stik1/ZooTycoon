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
        public Zoo()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Bitmap im = new Bitmap(Properties.Resources.zoo_tileset);
          //  g.DrawImage(im, 100, 100);
           // g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR_GAUCHE), 0, 22);
           // g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR), 32, 22);
          //  for (int i = 0; i < 10; i++) {
         //       g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR_GAUCHE), 0, 32 * i);
        //    }


        /*CRÉATION DU PREMIER BÂTIMENT À 0,0*/
            for (int i = 0; i < 4; i++)
            {      
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_HAUT), (32 * i), 22);

                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_MILIEU), (32 * i), 22 + (32 * 1));
                
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_BAS), (32 * i), 22 + (32 * 2));
            }

            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_GAUCHE), (32 * 0), 22 + (32 * 3));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_MILIEU), (32 * 1), 22 + (32 * 3));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_PORTE_HAUT), (32 * 2), 22 + (32 * 3));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_DROIT), (32 * 3), 22 + (32 * 3));

            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_GAUCHE), (32 * 0), 22 + (32 * 4));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_MILIEU), (32 * 1), 22 + (32 * 4));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_PORTE_BAS), (32 * 2), 22 + (32 * 4));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_DROIT), (32 * 3), 22 + (32 * 4));
            /*FIN CRÉATION DU PREMIER BÂTIMENT À 0,0*/



            /*CRÉATION DU CHEMIN SUPERIEUR HORIZONTAL*/

            for (int i = 0; i < 40; i++)
            {
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.GRASS), (32 * (i + 4)), 22 + (32 * 0));

                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR), (32 * (i+5)), 22 + (32 * 1));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (i + 5)), 22 + (32 * 2));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_INFERRIEUR), (32 * (i + 5)), 22 + (32 * 3));
            }
            /*FIN CRÉATION DU CHEMIN SUPERIEUR HORIZONTAL*/

            /*CHEMIN AUTOUR DE LA MAISON*/
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_SUPERIEUR_GAUCHE), (32 * (0 + 4)), 22 + (32 * 1));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_GAUCHE), (32 * (0 + 4)), 22 + (32 * 2));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_GAUCHE), (32 * (0 + 4)), 22 + (32 * 3));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_GAUCHE), (32 * (0 + 4)), 22 + (32 * 4));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (0 + 4)), 22 + (32 * 5));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (0 + 5)), 22 + (32 * 3));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (0 + 6)), 22 + (32 * 3));
            for (int i = 1; i <= 20; i++)
            {
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_GAUCHE), (32 * (0 + 4)), 22 + (32 * (3 + i)));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (0 + 5)), 22 + (32 * (3 + i)));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_DROIT), (32 * (0 + 6)), 22 + (32 * (3 + i)));
            }
            /*FIN CHEMIN AUTOUR DE LA MAISON*/

            /*CRÉATION DE L'ENCLOS SUPERIEUR GAUCHE*/

            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR_GAUCHE), (32 * (0 + 7)), 22 + (32 * 4));
            for (int i = 0; i < 5; i++)
            {
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR), (32 * (i + 8)), 22 + (32 * 4));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_CENTRE), (32 * (i + 8)), 22 + (32 * 5));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_CENTRE), (32 * (i + 8)), 22 + (32 * 6));
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENNCLOS_INFERIEUR), (32 * (i + 8)), 22 + (32 * 7));

            }
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_SUPERIEUR_DROIT), (32 * (0 + 13)), 22 + (32 * 4));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_DROIT), (32 * (0 + 13)), 22 + (32 * (5)));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_DROIT), (32 * (0 + 13)), 22 + (32 * (6)));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_GAUCHE), (32 * (0 + 7)), 22 + (32 * (5)));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_GAUCHE), (32 * (0 + 7)), 22 + (32 * (6)));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_INFERIEUR_DROIT), (32 * (0 + 13)), 22 + (32 * (7)));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.ENCLOS_INFERIEUR_GAUCHE), (32 * (0 + 7)), 22 + (32 * (7)));
            /*FIN CRÉATION DE L'ENCLOS SUPERIEUR GAUCHE*/

            /*CRÉATION DE L'ENTREE*/

            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.COLONNE_HAUT), (32 * (19)), 22 + (32 * 0));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.COLONNE_HAUT), (32 * (23)), 22 + (32 * 0));

            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_GAUCHE), (32 * (20)), 22 + (32 * 0));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (21)), 22 + (32 * 0));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_DROIT), (32 * (22)), 22 + (32 * 0));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (20)), 22 + (32 * 1));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (21)), 22 + (32 * 1));
            g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.CHEMIN_CENTRE), (32 * (22)), 22 + (32 * 1));
           
            /*FIN CRÉATION DE L'ENTREE*/
        }
    }
}
