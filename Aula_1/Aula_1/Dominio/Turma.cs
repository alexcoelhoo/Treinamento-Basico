using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.Dominio
{
    public class Turma
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public Professor professor { get; set; }
    }
}
