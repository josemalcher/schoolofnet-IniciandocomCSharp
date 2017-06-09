using System;

namespace ConsoleApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            // Propriedades 
            p.nome = "João"; 
            p.sobrenome = "Gomes";
            p.idade = 20;
            p.sexo = 'M';
            // Método 
            p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.nome, p.sobrenome, p.idade)); 
            p = new Pessoa();
            // Método 
            p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.nome, p.sobrenome, p.idade)); 

            Console.ReadLine();
        }
    }
}