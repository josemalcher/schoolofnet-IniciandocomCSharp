using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public char sexo;
        public Pessoa()
        {
            nome = "Paulo";
            sobrenome = "Silva";
            idade = 23;
        }
        public void Falar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
