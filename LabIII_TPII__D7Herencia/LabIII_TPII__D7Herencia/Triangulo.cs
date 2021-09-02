using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIII_TPII__D7Herencia
{
    class Triangulo: Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujar Triangulo");
            base.Dibujar();
        }
    }
}
