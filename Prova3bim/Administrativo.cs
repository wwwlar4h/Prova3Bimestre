using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bim
{
    public class Administrativo : Funcionario
    {
        public Administrativo(string nome, string cpf, string sexo, string matricula, double salario, DateTime dataNas) : base(nome, cpf, sexo, matricula, salario, dataNas)
        {
            
        }

        public double Salario (double salario)
        {
            double s = salario + 250 + (17 / 100 * salario);
            return s;
        }
    }
}
