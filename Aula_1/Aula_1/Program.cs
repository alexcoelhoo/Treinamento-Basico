using Aula_1.Dominio;
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
            Aluno aluno = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Idade do aluno: ");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matricula: ");
            aluno.Matricula = Console.ReadLine();

            Turma turma = new Turma();
            Console.WriteLine("Codigo da turma: ");
            turma.codigo = Console.ReadLine();
            Console.WriteLine("Nome da disciplina: ");
            turma.nome = Console.ReadLine();

            aluno.turma = turma;

            Professor professor = new Professor();
            Console.WriteLine("Codigo do professor: ");
            professor.codigo = Console.ReadLine();
            Console.WriteLine("Nome do professor: ");
            professor.nome = Console.ReadLine();

            turma.professor = professor;

            Console.WriteLine("Cadastro aceito");
            Console.WriteLine("Aluno: " + aluno.Nome + ". Matricula: " + aluno.Matricula + 
                                ". Idade: " + aluno.Idade + ". Turma do aluno: " + aluno.turma.nome);
            Console.WriteLine("Turma: " + turma.nome + ". Codigo: " + turma.codigo +
                                ". Professor da turma: " + turma.professor.nome);
            Console.WriteLine("Professor: " + professor.nome + ". Codigo: " + professor.codigo);
            

            Console.ReadKey();
        }

    }
}
