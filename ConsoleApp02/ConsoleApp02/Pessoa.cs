using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{
    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;
        private char sexo;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public int Idade
        {
            set{if (value >= 0) idade = value;}
            get{ return idade; }
        }
        public char Sexo { get => sexo; set => sexo = value; }

        public Pessoa()
        {
            Nome = "Paulo";
            Sobrenome = "Silva";
            Idade = 23;
        }
        public void Falar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
