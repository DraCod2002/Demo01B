using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    
}
