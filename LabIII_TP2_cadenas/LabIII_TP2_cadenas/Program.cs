using System;

namespace LabIII_TP2_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadOne, cadTwo; 
            Console.WriteLine("Ingrese 1ra cadena:");
            cadOne = Console.ReadLine();
            Console.WriteLine("Ingrese 2da cadena:");
            cadTwo = Console.ReadLine();
            if (cadTwo.Length <= cadOne.Length)
            {
                Console.WriteLine("Resultado: {0}", (cadOne.IndexOf(cadTwo) == -1)? "NO ENCONTRADO": "ENCONTRADO");
                cadOne.IndexOf(cadTwo);
            }
            else
            {
                Console.WriteLine("La cadena ingrsada es demasiado grande");
            }

        }
    }
}
