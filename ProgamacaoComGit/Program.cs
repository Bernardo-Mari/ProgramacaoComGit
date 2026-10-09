using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgamacaoComGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.nome = "Maria";
            a1.anoNascimento = 1993;

            Console.WriteLine($"Maria sua idade é {a1.calcularIdade()}");
            Console.ReadKey();
            
        }
    }
}
