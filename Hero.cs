using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    class Hero : Personnage
    {
        public int Argent { get; set; } = 100;

        public override void Deplacement()
        {
            throw new NotImplementedException();
        }
    }
}
