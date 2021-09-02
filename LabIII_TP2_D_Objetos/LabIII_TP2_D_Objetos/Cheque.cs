using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIII_TP2_D_Objetos
{
    class Cheque
    {
        private int _NroInterno;
        private string _banco;
        private string _propietario;
        private decimal _importe;
        public string Banco { get => _banco; set { _banco = value; } }
        public string Propietario { get => _propietario; set { _propietario = value; } }
        public decimal importe { get => _importe; set { _importe = value; } }


        public void Guardar() { }
        public void Imprimir() { }
        private bool ValidarNumero() { return true; }


    }
}
