using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTycoon
{
   abstract class Personnage
    {
        //TODO : changer cela pour des sprites
        public PictureBox ImagePersonnage { get; set; }

        //Les tuiles que le personnage peut marcher dessus, soit les chemins
        public int[] TuilesPassables { get; set; } = new int[] { 397, 398, 399, 427, 428, 429, 457, 458, 459 }; //Les Ids des tuiles des chemins

        public int Col { get; set; }
        public int Row { get; set; }

        public Deplacement Deplacement { get; set; }

        public abstract Boolean PeutAvancer(int X, int Y, int[,] CoordMap);

    }
}
