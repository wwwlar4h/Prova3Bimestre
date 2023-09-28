using Prova3bim;
using System.Security.Cryptography.X509Certificates;

class Prova
{
    static void Main(string[] args)
    {
        try
        {
            List<Funcionario> listFunc = new List<Funcionario>();
            List<Medicos> listMedico = new List<Medicos>();
            List<Administrativo> listAdm = new List<Administrativo>();  

            while (true)
            {
                Console.WriteLine("Olá, por favor, insira as seguintes informações: ");

                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();
                Console.Write("Matrícula: ");
                string matricula = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.Write("Data de nascimento: ");
                DateTime datanas = Convert.ToDateTime(Console.ReadLine());

                Funcionario f = new Funcionario(nome, cpf, sexo, matricula, salario, datanas);
                listFunc.Add(f);
             
                Console.WriteLine("\nEscolha o tipo de funcionário que deseja cadastrar:\n 1- Médico, 2- Administrativo, 3- Sair.");
                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Agora, adicione as seguintes informações: ");
                    Console.Write("\nEspecialidade: ");
                    string esp = Console.ReadLine();
                    Console.Write("CRM: ");
                    string crm = Console.ReadLine();
                    Console.Write("Hora extra: ");
                    DateTime hrsex = Convert.ToDateTime(Console.ReadLine());    

                    Medicos m = new Medicos(nome, cpf, sexo, matricula, salario, datanas, esp, crm, hrsex);
                    listMedico.Add(m);
                    Console.WriteLine("Cadastro feito.");
                }

                else if (op == 2)
                {                
                    Administrativo a = new Administrativo(nome, cpf, sexo, matricula, salario, datanas);
                    listAdm.Add(a);
                    Console.WriteLine("Cadastro feito.");
                }

                Console.WriteLine("Deseja continuar? Tecle 3 para sair.");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 3)
                {
                    break;
                }
               
            }

            //listFunc = listFunc.OrderBy(x >= 20000).ToList();   

            foreach (Funcionario mm in listFunc)
            {
                Console.WriteLine(listFunc);
            }
        }

        catch (Exception ex)
        { 
            Console.WriteLine(ex);
        }    
       
    }
}