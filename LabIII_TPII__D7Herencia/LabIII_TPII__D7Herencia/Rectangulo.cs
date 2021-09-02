using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIII_TPII__D7Herencia
{
    class Rectangulo: Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujar Rectangulo");
            base.Dibujar();
        }
    }
}
