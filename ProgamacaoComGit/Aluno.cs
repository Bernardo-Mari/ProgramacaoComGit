using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgamacaoComGit
{
    internal class Aluno
    {
        // Atributos
        public string nome;
        public int anoNascimento;

        // metodos
        public int calcularIdade()
        { 
            return 2026 - this.anoNascimento;
        }


    }
}
