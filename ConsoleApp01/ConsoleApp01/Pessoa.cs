using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp01
{
    public class Pessoa
    {
        string nome;
        string sobrenome;
        DateTime dataNascimento;
        char sexo;

        public Pessoa()
        {

        }
        public void falar(String mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
