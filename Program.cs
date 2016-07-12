using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public int fat(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public int fatRec(int n)
        {
            return (n == 0 || n == 1) ? 1 : n * this.fatRec(n - 1);

        }

        public int fiboRec(int n)
        {
            return (n < 2) ? n : fiboRec(n - 1) + fiboRec(n - 2);
        }

        public int fibo(int n)
        {
            int atual = 0;     
            int anterior = 0;   

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    atual = 1;
                    anterior = 0;
                }
                else
                {
                    atual += anterior;
                    anterior = atual - anterior;
                }
            }
            return atual;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.fatRec(5));
            Console.ReadKey();
        }
    }
}
