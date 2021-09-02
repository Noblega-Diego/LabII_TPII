using System;

namespace LabIII_TP2_IngresoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Ingrese los numeros separados por ,:");
            string[] numeros = Console.ReadLine().Split(',');
            try
            {
                foreach (String numero in numeros)
                {
                    total += Convert.ToInt32(numero.Replace(" ", ""));
                }
            }
            catch (Convert )
            {

            }
        }



    }
}
