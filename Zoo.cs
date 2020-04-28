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

                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_MILIEU), (32 * i), 54);
                
                g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_TOIT_BAS), (32 * i), 86);
            }

        //    g.DrawImage(TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.BATIMENT_MUR_GAUCHE), (32 * i), 22);



        }

        private void ActualisationArgent()
        {


        }

    }


}
