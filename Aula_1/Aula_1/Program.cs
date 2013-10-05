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
            Console.WriteLine("Qual seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Bom dia " + nome);

            Console.WriteLine("Informe um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero + numero2;
            Console.WriteLine("Numero: " + resultado);


            

            Console.ReadKey();
        }
    }
}
