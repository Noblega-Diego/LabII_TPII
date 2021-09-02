using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIII_TP2_D6Objetos
{
    class Articulo
    {
        
        public Articulo(String codigo, Deposito deposito)
        {
            _deposito = deposito;
            this.Codigo = codigo;
        }
        
        public String Codigo { get; set; }
        public double StockTotal { get; set; }
        public double StockMinimo { get; set; }
        private Deposito _deposito;

        public Deposito Deposito { get => _deposito; set { _deposito = value; } }

        public override string ToString()
        {
            return "Cod: " + Codigo + "    Min: " + StockMinimo + "    Total: " + StockTotal;
        }
    }
}
