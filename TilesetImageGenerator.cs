using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTilesetZoo
{
    class TilesetImageGenerator
    {
        // Différentes tailles concernant les images dans le fichier de tuiles de jeu
        public const int IMAGE_WIDTH = 32, IMAGE_HEIGHT = 32;
        private const int TILE_LEFT = 0, TILE_TOP = 0;
        private const int SEPARATEUR_TILE = 0;

        // La valeur entière correspond "par hasard" à la position de l'image dans la List<TileCoord>
        public static int CHEMIN_SUPERIEUR_GAUCHE = 0;
        public static int CHEMIN_SUPERIEUR = 1;
        public static int CHEMIN_SUPERIEUR_DROIT = 2;
        public static int CHEMIN_GAUCHE = 3;
        public static int CHEMIN_CENTRE = 4;
        public static int CHEMIN_DROIT = 5;
        public static int CHEMIN_INFERIEUR_GAUCHE = 6;
        public static int CHEMIN_INFERRIEUR = 7;
        public static int CHEMIN_INFERIEUR_DROIT = 8;

        public static int BATIMENT_TOIT_HAUT = 9;
        public static int BATIMENT_TOIT_MILIEU = 10;
        public static int BATIMENT_TOIT_BAS =11;
        public static int BATIMENT_MUR_GAUCHE = 12;
        public static int BATIMENT_MUR_MILIEU = 13;
        public static int BATIMENT_PORTE_HAUT = 14;
        public static int BATIMENT_PORTE_BAS = 15;
        public static int BATIMENT_MUR_DROIT = 16;


        private static List<TileCoord> listeCoord = new List<TileCoord>();
        private static List<Bitmap> listeBitmap = new List<Bitmap>();

        /// <summary>
        /// Constructeur statique
        /// </summary>
        static TilesetImageGenerator()
        {
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 6 }); // CHEMIN_SUPERIEUR_GAUCHE
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 7 }); // CHEMIN_SUPERIEUR
            listeCoord.Add(new TileCoord() { Ligne = 13, Colonne = 8 }); // CHEMIN_SUPERIEUR_DROIT
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 6 }); // CHEMIN_GAUCHE
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 7 }); // CHEMIN_CENTRE
            listeCoord.Add(new TileCoord() { Ligne = 14, Colonne = 8 }); // CHEMIN_DROIT
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 6 }); // CHEMIN_INFERIEUR_GAUCHE
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 7 }); // CHEMIN_INFERRIEUR
            listeCoord.Add(new TileCoord() { Ligne = 15, Colonne = 8 }); // CHEMIN_INFERIEUR_DROIT

            listeCoord.Add(new TileCoord() { Ligne = 4, Colonne = 12 }); // BATIMENT_TOIT_HAUT
            listeCoord.Add(new TileCoord() { Ligne = 5, Colonne = 12 }); // BATIMENT_TOIT_MILIEU
            listeCoord.Add(new TileCoord() { Ligne = 6, Colonne = 12 }); // BATIMENT_TOIT_BAS
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 12 }); // BATIMENT_MUR_GAUCHE
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 13 }); // BATIMENT_MUR_MILIEU
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 14 }); // BATIMENT_PORTE_HAUT
            listeCoord.Add(new TileCoord() { Ligne = 8, Colonne = 14 }); // BATIMENT_PORTE_BAS
            listeCoord.Add(new TileCoord() { Ligne = 7, Colonne = 15 }); // BATIMENT_MUR_DROIT



            listeBitmap.Add(LoadTile(CHEMIN_SUPERIEUR_GAUCHE)); // CHEMIN_SUPERIEUR_GAUCHE
            listeBitmap.Add(LoadTile(CHEMIN_SUPERIEUR)); // CHEMIN_SUPERIEUR
            listeBitmap.Add(LoadTile(CHEMIN_SUPERIEUR_DROIT)); // CHEMIN_SUPERIEUR_DROIT
            listeBitmap.Add(LoadTile(CHEMIN_GAUCHE)); // CHEMIN_GAUCHE
            listeBitmap.Add(LoadTile(CHEMIN_CENTRE)); // CHEMIN_CENTRE
            listeBitmap.Add(LoadTile(CHEMIN_DROIT)); // CHEMIN_DROIT
            listeBitmap.Add(LoadTile(CHEMIN_INFERIEUR_GAUCHE)); // CHEMIN_INFERIEUR_GAUCHE
            listeBitmap.Add(LoadTile(CHEMIN_INFERRIEUR)); // CHEMIN_INFERRIEUR
            listeBitmap.Add(LoadTile(CHEMIN_INFERIEUR_DROIT)); // CHEMIN_INFERIEUR_DROIT

            listeBitmap.Add(LoadTile(BATIMENT_TOIT_HAUT)); // BATIMENT_TOIT_HAUT
            listeBitmap.Add(LoadTile(BATIMENT_TOIT_MILIEU)); // BATIMENT_TOIT_MILIEU
            listeBitmap.Add(LoadTile(BATIMENT_TOIT_BAS)); // BATIMENT_TOIT_BAS
            listeBitmap.Add(LoadTile(BATIMENT_MUR_GAUCHE)); // BATIMENT_MUR_GAUCHE
            listeBitmap.Add(LoadTile(BATIMENT_MUR_MILIEU)); // BATIMENT_MUR_MILIEU
            listeBitmap.Add(LoadTile(BATIMENT_PORTE_HAUT)); // BATIMENT_PORTE_HAUT
            listeBitmap.Add(LoadTile(BATIMENT_PORTE_BAS)); // BATIMENT_PORTE_BAS
            listeBitmap.Add(LoadTile(BATIMENT_MUR_DROIT)); // BATIMENT_MUR_DROIT

        }
        
        private static Bitmap LoadTile(int posListe)
        {
            Image source = ZooTycoon.Properties.Resources.zoo_tileset;
            TileCoord coord = listeCoord[posListe];
            Rectangle crop = new Rectangle(TILE_LEFT + (coord.Colonne * (IMAGE_WIDTH + SEPARATEUR_TILE)), TILE_TOP + coord.Ligne * (IMAGE_HEIGHT + SEPARATEUR_TILE), IMAGE_WIDTH, IMAGE_HEIGHT);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(source, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetTile(int posListe)
        {
            return listeBitmap[posListe];
        }

    }

    public class TileCoord
    {
        public int Ligne { get; set; }
        public int Colonne { get; set; }
    };
}

