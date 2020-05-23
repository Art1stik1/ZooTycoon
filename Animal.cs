using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTycoon
{
    public abstract class Animal
    {
        public PictureBox image;
        public string type; //Penser à faire un enum des types d'animaux
        public string genre;
        public Boolean estAdulte;
        public Boolean estNourri;
        public double tempsDernierRepas;
        public Boolean attendBebe;

        public abstract void FaitBruit();
        public abstract void Deplacement();
        public abstract void NourrirAnimal();
    }

    internal class Lion : Animal
    {
        public override void Deplacement()
        {
            throw new NotImplementedException();
        }

        public override void FaitBruit()
        {
            throw new NotImplementedException();
        }

        public override void NourrirAnimal()
        {
            throw new NotImplementedException();
        }
    }
}
