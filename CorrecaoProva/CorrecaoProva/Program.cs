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

        }
    }
}
