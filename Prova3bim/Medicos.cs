using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bim
{
    public class Medicos : Funcionario
    {
        public string Especialidade { get; set; }
        public string CRM { get; set; } 
        public DateTime HoraExtra { get; set; }    

      
        public Medicos(string nome, string cpf, string sexo, string matricula, double salario, DateTime dataNas, string Especialidade, string CRM, DateTime HoraExtra) : base (nome, cpf, sexo, matricula,salario, dataNas)
        {
            this.HoraExtra = HoraExtra; 
            this.CRM = CRM;
            this.Especialidade = Especialidade; 
        }

        public double Salario(double salario)
        {
            double auxilioPeri = salario + (22 / 100 * salario);
            return auxilioPeri;
        }


    }
}
