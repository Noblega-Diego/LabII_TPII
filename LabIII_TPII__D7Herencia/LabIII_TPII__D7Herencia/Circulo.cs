using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIII_TPII__D7Herencia
{
    class Circulo: Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujar Circulo");
            base.Dibujar();
        }
    }
}
