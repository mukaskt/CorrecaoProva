using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoProva
{
    class Program
    { 
        static int Maior(int a, int b)
    {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }      
    }
        static bool Par(int numero)
        {
            int resto = numero % 2;
            if (resto == 0)
                return true;
            else
                return false;
        }
    
        static void Main(string[] args)
        {
                 //exercicio 4

            double x = 0;
            x = Math.Abs(7.5);
            Console.WriteLine("a: " + x);// ira retornar o valor 7,5

            x = Math.Floor(7.5);
            Console.WriteLine("b: " + x);//ira retornar o valor 7 e desconsiderara tudo apos a virgula

            x = Math.Abs(0.0);
            Console.WriteLine("c: " + x);//ira retornar valor 0

            x = Math.Ceiling(0.0);
            Console.WriteLine("d: " + x);// ira retornar valor 0

            x = Math.Abs(-6.4);
            Console.WriteLine("e: " + x);//ira retornar o valor de 6,4

            x = Math.Ceiling(-6.4);
            Console.WriteLine("f: " + x);//ira retornar o valor 6 e desconsiderara tudo apos a virgula

            x = Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5)));
            Console.WriteLine("g: " + x);//ira retornar o valor 14

            Console.ReadKey();

        }
    }
}
