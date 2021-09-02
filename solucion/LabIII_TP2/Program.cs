using System;

namespace LabIII_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion fra0 = new Fraccion(4, 3);
            Fraccion fra1 = new Fraccion(2, 2);
            Console.WriteLine("{0}+{1} = {2}",fra0, fra1, fra0.Sumar(fra1));
            Console.WriteLine("{0}-{1} = {2}", fra0, fra1, fra0.Restar(fra1));
            Console.WriteLine("{0}*{1} = {2}", fra0, fra1, fra0.Multiplicar(fra1));
            Console.WriteLine("{0}/{1} = {2}", fra0, fra1, fra0.Dividir(fra1));
            try { 
                Fraccion fra2 = new Fraccion(2, 0);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Fraccion 
    {
        
        private int numerador;    
        private int denominador;

        public Fraccion(int num, int den)
        {
            this.numerador = num;
            this.denominador = den;
        }

        public Fraccion Sumar(Fraccion fraccion)
        {
            Fraccion result; 
            int comun = Mdc(this.denominador, fraccion.Denominador, 1);
            int valueOne = (comun / this.denominador) * this.numerador;
            int valueTwo = (comun / fraccion.Denominador) * fraccion.Numerador;
            result = new Fraccion((valueOne + valueTwo), comun);
            return result;
        }

        public Fraccion Restar(Fraccion fraccion)
        {
            Fraccion result;
            int comun = Mdc(this.denominador, fraccion.Denominador, 1);
            int valueOne = (comun / this.denominador) * this.numerador;
            int valueTwo = (comun / fraccion.Denominador) * fraccion.Numerador;
            result = new Fraccion((valueOne - valueTwo), comun);
            return result;
        }

        public Fraccion Multiplicar(Fraccion fraccion)
        {
            Fraccion result;
            int numerador = this.numerador * fraccion.Numerador;
            int denominador = this.denominador * fraccion.Denominador;
            result = new Fraccion(numerador, denominador);
            return result;
        }

        public Fraccion Dividir(Fraccion fraccion)
        {
            Fraccion result;
            int numerador = this.numerador * fraccion.Denominador;
            int denominador = this.denominador * fraccion.Numerador;
            result = new Fraccion(numerador, denominador);
            return result;
        }


        private int Mdc(int num, int num1, int value)
        {
            
            try { 
                if (value % num == 0 &&  value % num1 == 0)
                    return value;
                else{
                    return Mdc(num, num1, ++value);
                }
            }catch(DivideByZeroException e)
            {
                throw new DivideByZeroException("no es posible realizar divisiones por 0", e);
            }

        }
        
        public int Numerador
        {
            get => numerador;
            set
            {
                if (value == 0)
                    throw new Exception("El numerador no puede ser cero");
                numerador = value;
            }
        }

        public int Denominador
        {
            get => denominador;
            set
            {
                if (value == 0)
                    throw new Exception("El denominador no puede ser cero");
                denominador = value;
            }
        }

        public override string ToString()
        {
            return "(" + numerador + "/" + denominador +")";
        }
    }
}
