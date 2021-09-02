using System.Collections.Generic;

namespace LabIII_TP2_D6Objetos
{
    internal class Deposito
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public List<Articulo> Articulos { get;}

        public Deposito()
        {
            Articulos = new List<Articulo>();
        }
        
        public List<Articulo> ArticulosBajoStock()
        {
            List<Articulo> articulosBajoStock = new List<Articulo>();
            foreach (Articulo art in this.Articulos)
            {
                if (art.StockTotal <= art.StockMinimo)
                    articulosBajoStock.Add(art);
            }
            return articulosBajoStock;
        }
    }
}