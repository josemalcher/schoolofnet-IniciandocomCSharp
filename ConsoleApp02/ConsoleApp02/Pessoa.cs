using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{

    public struct MinhaData
    {
        public DataTime dataAtual;
            
    }

    public enum Sexo
    {
        Masculino = 1;
        Feminino = 2;
    }


    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private int idade;
        
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public int Idade
        {
            set{if (value >= 0) idade = value;}
            get{ return idade; }
        }

        public Sexo sexo;
        public Sexo Sexo { set { sexo = value; } get { return sexo; } }

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
