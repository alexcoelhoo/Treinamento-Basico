using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os lados de um triangulo: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());
            int lado2 = Convert.ToInt32(Console.ReadLine());
            int lado3 = Convert.ToInt32(Console.ReadLine());

            if ((lado1 == lado2) && (lado2 == lado3))
            {
                Console.WriteLine("Triangulo equilatero");
            }

            else if ((lado1 == lado2) || (lado2 == lado3) || (lado3 == lado1))
            {
                Console.WriteLine("Triangulo isosceles");
                                
            }
            else Console.WriteLine("Triangulo escaleno");
          
            Console.ReadKey();
        }
    }
}
