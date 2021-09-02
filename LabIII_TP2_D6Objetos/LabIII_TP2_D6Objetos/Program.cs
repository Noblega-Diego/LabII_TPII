using System;
using System.Collections.Generic;

namespace LabIII_TP2_D6Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito central = new Deposito();
            Articulo leche = new Articulo("123", central) { StockMinimo= 5, StockTotal= 4};
            Articulo arroz = new Articulo("124", central) { StockMinimo = 2, StockTotal = 4 };
            Articulo fideos = new Articulo("125", central) { StockMinimo = 4, StockTotal = 2 };
            central.Articulos.Add(leche);
            central.Articulos.Add(arroz);
            central.Articulos.Add(fideos);

            foreach (Articulo articulo in central.ArticulosBajoStock())
                Console.WriteLine(articulo);
        }
    }
}
