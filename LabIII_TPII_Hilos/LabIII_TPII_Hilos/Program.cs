using System;
using System.Threading;

namespace LabIII_TPII_Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("precione Enter para finalizar");

            Thread threadFive = new Thread(ImprimirPor5Seg);
            Thread threadTeen = new Thread(ImprimirPor10Seg);
            threadFive.Start();
            threadTeen.Start();
        }


        public static void ImprimirPor5Seg()
        {
            DateTime start = DateTime.Now;
            TimeSpan transcurrido;
            while (true)
            {
                if ((DateTime.Now - start).TotalSeconds >= 5)
                {
                    start = DateTime.Now;
                    Console.WriteLine("Este mensaje se imprime cada " + 5);
                }
            }
        }
        public static void ImprimirPor10Seg()
        {
            DateTime start = DateTime.Now;
            TimeSpan transcurrido;
            while (true)
            {
                if ((DateTime.Now - start).TotalSeconds >= 10)
                {
                    start = DateTime.Now;
                    Console.WriteLine("Este mensaje se imprime cada " + 10);
                }
            }
        }
    }
}
