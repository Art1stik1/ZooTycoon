using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTycoon
{
    class Hero : Personnage
    {
        public Hero()
        {
            ImagePersonnage = new PictureBox
            {
                Image = (Image)TestTilesetZoo.TilesetImageGenerator.GetTile(TestTilesetZoo.TilesetImageGenerator.LION)
            };

            Col = 15;
            Row = 0;

            Deplacement = new Deplacement();
        }

        /// <summary>
        /// Vérifie que la case où que le personnage veut se déplacer est un chemin
        /// </summary>
        /// <param name="Row">Rangée du joueur</param>
        /// <param name="Col">Colonne du joueur</param>
        /// <param name="CoordMap">Les id des tuiles de la map</param>
        /// <returns>True si la case que le personnage veut se déplacer est un chemin</returns>
        public override bool PeutAvancer(int Row, int Col, int[,] CoordMap)
        {
            return Deplacement.NouvelEmplacement(CoordMap, Row, Col, TuilesPassables);
        }

    }
}
