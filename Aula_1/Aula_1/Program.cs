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
            List<string> animais = new List<string>();
            animais.Add("cachorro");
            animais.Add("gato");
            animais.Add("galinha");

            foreach (string animal in animais)
            {
                Console.WriteLine(animal);
            }
          
            Console.ReadKey();
        }
    }
}
