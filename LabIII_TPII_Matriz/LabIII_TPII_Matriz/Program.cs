using System;

namespace LabIII_TPII_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila, columna;
            char[,] matriz;

            Console.WriteLine("ingrese los valores");
            Console.WriteLine("Fila: ");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Columna: ");
            columna = Convert.ToInt32(Console.ReadLine());

            matriz = new char[fila, columna];
            rellenarArray(fila, columna, matriz);

            mostrarMatriz(matriz);

        }

        static void rellenarArray(int valueOne, int valueTwo, char[,] matriz)
        {
            for (int r = 0; r < matriz.GetLength(0); r++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if ((r + 1) + (c + 1) == valueOne + valueTwo)
                        matriz[r, c] = 'X';
                    else
                        matriz[r, c] = '0';
                }
            }
        }

        static void mostrarMatriz(char[,] matriz)
        {
            for( int r = 0; r < matriz.GetLength(0); r++ )
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[r, c] + " ");
                }
                Console.Write("\n");
            }
        }

    }
}
