using System;
using System.Collections.Generic;

namespace LabIII_TPII__D7Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo());
            figuras.Add(new Triangulo());

            foreach (Figura figura in figuras)
                figura.Dibujar();
        }
    }
}
