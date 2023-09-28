using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bim
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; } 
        public string Sexo { get; set; }    
        public string Matricula { get; set; }

        public double Salario { get; set; }
        public DateTime DataNas { get; set; }

        public Funcionario(string nome, string cpf, string sexo, string matricula, double salario, DateTime dataNas)
        {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Matricula = matricula;
            DataNas = dataNas;
        }

    }
}
