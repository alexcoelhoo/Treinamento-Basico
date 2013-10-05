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
            Console.WriteLine("Informe numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe outro numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            
            double resultado = numero / numero2;

            Console.WriteLine("Resultado: " + resultado);
           
            Console.ReadKey();
        }
    }
}
