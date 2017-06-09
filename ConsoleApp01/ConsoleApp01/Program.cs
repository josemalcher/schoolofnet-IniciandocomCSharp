using System;

namespace ConsoleApp01
{
    class Program
    {
        public static void ImprimirValor(decimal valor, string mensagem)
        {
            // Utilizando String Format 
            // Console.WriteLine(String.Format("{0} {1}", mensagem, valor) ); 
            Console.WriteLine(mensagem + valor);
        }

        static void Soma10(ref int valor)
        {
            valor += 10;
            Console.WriteLine(valor);

        }

        static void Main(string[] args)
        {
            //int matricula = 10;
            //string nome = "Pedro";
            //string sobrenome = "Silva";
            //DateTime dataNascimento = DateTime.Now;
            //decimal salario = 1000.50m;
            //bool feriasVencidas = true;
            //char sexo = 'M';

            //Console.WriteLine(nome + " " + sobrenome);
            //Console.WriteLine(String.Format("{0} {1}", nome, sobrenome));

            int a = 15;
            int b = 2;

            // + - * % 
            //decimal resultado = a / b;
            decimal resultado = Convert.ToDecimal(a) / Convert.ToDecimal(b);

            a = a + 1;
            a++;
            a--;
            a += 5;
            a -= 3;
            Console.WriteLine(a);

            int idade = 15;
            if (idade > 18)
            {
                Console.WriteLine("Autorizado");
            }
            else
            {
                Console.WriteLine("Não autorizado!!");
            }

            //ternario
            string resultado1 = idade > 60 ? "Aposentado" : "Trabalhando";

            switch (idade)
            {
                case 70:
                case 80:
                case 60: Console.WriteLine("Aposentado");
                    break;
                case 10: Console.WriteLine("Criança");
                    break;
                default: 
                    Console.WriteLine("Indefinido");
                    break;
            }

            int[] colecao = new int[] {1,2,3,4,5};
            foreach(var item in colecao)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int indice = 5;
            while (indice > 0)
            {
                Console.WriteLine(indice);
                indice--;
            }

            int f = 12;
            do
            {
                Console.WriteLine(f);
                f--;
            } while (f > 10);

            int x = 5;
            int y = 10;
            if( x > y)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }

            Pessoa pessoa1 = new Pessoa();
            pessoa1.falar("OLAAA!!");

            // Parâmetros
            int valorInicial = 20;
            Soma10(ref valorInicial);
            Console.WriteLine(valorInicial);
            


            Console.ReadLine();
        }
    }
}