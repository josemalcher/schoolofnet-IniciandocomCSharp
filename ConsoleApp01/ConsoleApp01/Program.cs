using System;

namespace ConsoleApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula = 10;
            string nome = "Pedro";
            string sobrenome = "Silva";
            DateTime dataNascimento = DateTime.Now;
            decimal salario = 1000.50m;
            bool feriasVencidas = true;
            char sexo = 'M';

            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine(String.Format("{0} {1}", nome, sobrenome));

            Console.ReadLine();
        }
    }
}