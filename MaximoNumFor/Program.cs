using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximoNumFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int NumMax = 0;
            int BanderaMax = 0;
            for(int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese un Número por favor: ");
                Num = int.Parse(Console.ReadLine());
                if (BanderaMax == 0)
                {
                    BanderaMax = 1;
                    NumMax = Num;
                }
                else
                {
                    if(Num >= NumMax)
                    {
                        NumMax = Num;
                    }
                }
            }
            Console.WriteLine("El Número maximo es: {0} ", NumMax);
            Console.Read();
        }
    }
}
