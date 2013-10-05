using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.Dominio
{
    public class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Turma turma { get; set; }
    }
}
