using System;

namespace ConsoleApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            // Propriedades 
            p.Nome = "João"; 
            p.Sobrenome = "Gomes";
            p.Idade = 20;
            p.Sexo = 'M';
            // Método 
            p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.Nome, p.Sobrenome, p.Idade)); 
            p = new Pessoa();
            // Método 
            p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.Nome, p.Sobrenome, p.Idade)); 

            Console.ReadLine();
        }
    }
}