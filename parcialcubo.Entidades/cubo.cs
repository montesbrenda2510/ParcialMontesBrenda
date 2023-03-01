using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialcubo.Entidades
{

    public class cubo
    {

        public int Arista { get; set; }
        public Relleno relleno { get; set; }
        public Trazo trazo { get; set; }

        public cubo()
        {

        }

        //calculamos volumen y area

        public double GetVolumen()
        {
            return Arista ^ 3;
        }

        public double GetArea()
        {
            return 6 * Arista ^ 2;
        }

        public bool Validar()
        {
            return true;
        }
    }
    
}
