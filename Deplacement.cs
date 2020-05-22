using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    class Deplacement
    {

        public Deplacement()
        {
        }

        /// <summary>
        /// Cherche l'id de la tuile auquel le personnage veut se déplacer
        /// </summary>
        /// <param name="Row">La rangée de la tuile</param>
        /// <param name="Col">La colonne de la tuile</param>
        /// <param name="coordMap">Les ID des tuiles de la map</param>
        /// <returns>L'id de la tuile que le personnage veut se déplacer</returns>
        private int ChercherTuile(int Row, int Col, int[,] coordMap)
        {
            int idTuile = -1;

            if (Row < 26 && Row >= 0)
            {
                if (Col < 30 && Col >= 0)
                {
                    idTuile = coordMap[Row, Col];
                }
            }

            return idTuile;
        }

        /// <summary>
        /// Vérifie que la case où que le personnage veut se déplacer est un chemin
        /// </summary>
        /// <param name="coordMap">Les ids des tuiles de la map</param>
        /// <param name="Row">Rangée du personnage</param>
        /// <param name="Col">Colonne du personnage</param>
        /// <param name="tuilesPassables">Le tableau des tuile que le personnage peut aller dessus</param>
        /// <returns>True si le personnage peut marcher sur la tuile</returns>
        public Boolean NouvelEmplacement(int[,] coordMap, int Row, int Col, int[] tuilesPassables)
        {
            int idTuile = ChercherTuile(Row, Col, coordMap);

            if (tuilesPassables.Contains(idTuile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
