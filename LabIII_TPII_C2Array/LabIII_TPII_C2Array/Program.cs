using System;

namespace LabIII_TPII_C2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[] numeros;
            Console.WriteLine("Ingrese los numeros separados por ,");
            String[] datos = Console.ReadLine().Split(',');
            try { 
                numeros = new int[datos.GetLength(0)];
                for(int i = 0; i < numeros.GetLength(0); i++)
                    numeros[i] = Convert.ToInt32(datos[i].Replace(" ", ""));
            }catch(System.FormatException ex) {
                Console.WriteLine("Error: Los valores ingresados no son validos");
                numeros = new int[0];
            }
            foreach (int num in numeros)
                suma += num;    
            Console.WriteLine(suma);
        }

        
    }
}
