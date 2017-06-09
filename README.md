# Iniciando com C#

Resumo do curso:

https://www.schoolofnet.com/curso-iniciando-com-c/

[Material para Referência - Caelum C# e OO](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/)

---

## <a name="indice">Índice</a>

- [Instalação do Visual Studio](#parte1)
- [CSharp DotNet](#parte2)
- [Hello World](#parte3)
- [Tipos de Variáveis](#parte4)
- [Operadores aritiméticos](#parte5)
- [Atribuição, incremento e decremento](#parte6)
- [Estrutura condicional](#parte7)
- [Estrutura repetição](#parte8)
- [Operadores comparativos](#parte9)
- [Escrevendo métodos](#parte10)
- [Parâmetros](#parte11)
- [Classes](#parte12)
- [Encapsulamento](#parte13)
- [Struct/Enum](#parte14)
- [Fila, Pilha e Listas](#parte15)

---

## <a name="parte1">Instalação do Visual Studio</a>

Sejam bem vindos a mais um conteúdo da School of Net.

Temos como objetivo dar uma base sólida de conhecimentos para trabalhar com a linguagem C#.

Alguns tópicos que serão abordados:

- TIPOS DE DADOS
- VARIÁVEIS
- OBJETOS
- CLASSES
- ENCAPSULAMENTO
- MÉTODOS
- ESTRUTURAS CONDICIONAIS
- Visual Studio

Para seguir com os próximos conteúdos, instalaremos o Visual Studio. Para instalar o programa, basta pesquisar no google por donwload visual studio. O primeiro resultado da busca, provavelmente, será o link correto do site oficial.

Caso não consigam encontrar, segue o link: https://www.visualstudio.com/pt-br/downloads/.

Haverá as seguintes versões:

![Visual Studio Versões](https://raw.githubusercontent.com/josemalcher/schoolofnet-IniciandocomCSharp/master/img/c_visual_studio.png)


Existem diferenças entre as versões paga e gratuita. Utilizaremos a versão community que é gratuita. Se decidirem investir em outra versão, terão alguns recursos e vantagens adicionais. A versão community atenderá, perfeitamente, para a conclusão do nosso objetivo.

Mesmo que tenham uma máquina muito boa, a instalação pode demorar um pouco, tenham paciência, para que consigam concluir a instalação. A instalação demora porque precisará instalar recursos como ASP.NET, versões do framework e muitas outras funcionalidades.

A instalação perguntará se deseja fazer uma instalação default ou personalizada. O ideal é que faça a instalação default, porque ela já vem com todas as features, templates e configurações necessárias, que precisarão. Utilizem a instalação personalizada, somente se souberem muito bem o que estão fazendo, senão podem perder funcionalidades.

Geralmente, a instalação vai até o final sem problema algum. Se houver algum problema, pode ser que a máquina não possua as configurações, mínimas, exigidas pelo programa ou que falte algum recurso. Neste caso, terão que decobrir o problema e resolvê-lo, para que consigam finalizar a instalação.

O Visual Studio é uma ferramenta fantástica e com certeza irão gostar muito.

[Voltar ao Índice](#indice)

---

## <a name="parte2">CSharp DotNet</a>

Falaremos sobre o CSharp. Para entenderem esta linguagem vocês devem ter conhecimento de que ela foi desenvolvida como parte da plataforma DotNet framework. Este framework está embutido, como parte da instalação do Visual Studio, e nos permite a criação de itens como: serviços, interfaces, banco de dados, arquivos xml e escrever ou ler arquivos.

O DotNet framework, utilizado com a linguagem C#, permite desenvolver aplicações de negócios, web applications, portais, sites, jogos e também aplicações mobile.

Para consolidar este aprendizado, vamos explicar que o DotNet está sob duas bases:

- CLR (COMMON LANGUAGE RUNTIME) - AMBIENTE DE EXECUÇÃO DO DOTNET FRAMEWORK O DOTNET PERMITE UTILIZAR OUTRAS LINGUAGENS, ALÉM DA CSHARP, PARA DESENVOLVER, E O CLR FAZ UMA COMPILAÇÃO PARA UMA LINGUAGEM *INTERMEDIÁRIA PARA QUE O SISTEMA OPERACIONAL SEJA CAPAZ DE INTERPRETAR. NÃO IMPORTA A LINGUAGEM UTILIZADA PARA PROGRAMAR COM DOTNET, O CLR SEMPRE CRIARÁ UMA INTERFACE INTERMEDIÁRIA PARA LEITURA.

- FCL (FRAMEWORK CLASS LIBRARY)
    - ESTE É RESPONSÁVEL POR PERMITIR CONSTRUIR AS APLICAÇÕES. PERMITE EXPRESSÕES REGULARES, PERSISTÊNCIA EM BANCO DE DADOS, CRIAÇÃO DE APLICAÇÕES DESKTOP, WEB OU SERVIÇOS. O ASP.NET É PARTE DO DOTNET FRAMEWORK.

O CSharp é uma, entre muitas linguagens, que podem ser usadas no DotNet. Além de ser parecido com as linguagens: java, javascript ou C++. Se tiverem conhecimento de uma das linguagens, citadas anteriormente, não terão problemas para adaptarem-se ao CSharp.

No próximo módulo veremos os recursos que esta ferramenta oferece.

[Voltar ao Índice](#indice)

---

## <a name="parte3">Hello World</a>

Iniciaremos com a codificação da linguagem C# e, para isso, começaremos um projeto utilizando o Visual Studio.

Há duas formas de iniciar um projeto: utilizando a start page ou utilizando o menu superior no item File/New/Project.

![Novo projeto](https://raw.githubusercontent.com/josemalcher/schoolofnet-IniciandocomCSharp/master/img/csharp_new_project.png)

Qualquer caminho escolhido, apresentará uma tela para a escolha de templates. Dentro da linguagem C# há inúmeras opções de templates.

- WINDOWS
- WEB
- WORKFLOW

Apesar de existirem muitos templates, escolheremos o Console Application, que está dentro do item C#, geral do menu. Vejam na imagem abaixo:

![Templates](https://raw.githubusercontent.com/josemalcher/schoolofnet-IniciandocomCSharp/master/img/csharp_templates.png)

Utilizaremos o console para focarmos apenas nas lógicas e recursos da linguagem, sem precisarmos nos preocupar com a parte de layout e estilização de nossos exemplos.

Ao selecionar o tipo de template, precisamos informar um nome para a aplicação e para a soluction. Em seguida, clicamos em ok e aguardarmos nosso projeto ser iniciado.

Se quiserem abrir a estrutura de arquivos do projeto, basta observarem o lado esquerdo da janela do Visual Studio e acessarem Solution Explorer.

Vale ressaltar que, primeiro criamos a soluction e é dentro desta soluction que criaremos toda aplicação. A partir desta soluction criaremos um arquivo chamado Program.cs, onde desenvolveremos nossos exemplos.

Quando abrirem o arquivo Program.cs terá o seguinte código:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código
        }
    }
}
```

Não utilizaremos esta estrutura, que já vem pronta, para a criação do nosso projeto. Criaremos tudo do zero, para que vocês possam entender como desenvolver uma aplicação do zero.

Toda classe no C# trabalhará com algumas palavras reservadas que deverão ter uma atenção especial, pois são muito utilizadas.

Para que a linguagem compile nosso código e consigamos fazer qualquer coisa, teremos que, em primeiro lugar, criar uma classe para envolver todo nosso código. Isso é obrigatório para obtermos resultado com a linguagem.

```csharp
class ConsoleCsharp
{

}
```

Depois de criada a classe, deveremos criar uma método, utilizando algumas palavras reservadas, que explicaremos no decorrer do conteúdo.

Criaremos um método chamado Main e, obrigatoriamente, deverá ter este nome, porque o C# entenderá que este método existe.

```csharp
class ConsoleCsharp
{
    static void Main()
    {

    }
}
```

Para conferir se nosso código está com as instruções corretas e se o C# está reconhecendo meu código, sem nenhum erro, clicaremos no menu Build/Build Soluction ou apertarmos F6 no teclado. Este comando compilará o código em busca de erros. Se estiver tudo correto, ele retornará a mensagem Build succeeded, em uma barra no rodapé do programa. Se houver algum erro, terá a mensagem Build Failed.

É importante esclarecer que, executar o comando build não quer dizer que executamos o projeto, nós apenas o construímos. Para executar, deveremos clicar no botão Start, que fica na parte superior do Visual Studio.

Executando a aplicação com o start ou clicando em F5, que tem o mesmo resultado, aparecerá uma tela abrindo e fechando, rapidamente. Este tela é como se fosse uma tela de terminal.

O programa executa e fecha, porque não inserimos nada que faça ele ficar aberto. Por enquanto temos apenas uma classe e um método, que não executam nada. Para que o console fique aberto, no momento da execução, o C# disponibiliza um recurso. Vejam o código:

Utilizando dll inline

```csharp
class ConsoleCsharp
{
    static void Main()
    {
        System.Console.ReadLine();
    }
}
```

Usando dll com namespace

```csharp
using System;

class ConsoleCsharp
{
    static void Main()
    {
        Console.ReadLine();
    }
}
```

A maneira mais elegante de utilizar a dll, é chamando, via namespace com o using. O código fica mais limpo e organizado.

Uma dll é um código, previamente compilado, para que possamos utilizar. O C# já traz algumas dlls prontas, mas podemos criar nossas próprias dlls e também utilizar de terceiros. Estas dlls, que são disponibilizadas, são muito utilizadas durante o desenvolvimento de qualquer projeto.

A dll System já faz parte do .NET Framework e está referenciada em nossa aplicação. Vocês podem ter acesso a ela através do Soluction Explorer na parte de References. Concluímos que as dlls do framework já estão instaladas e disponíveis para nossa utilização.

Por enquanto temos uma tela aguardando alguma entrada de dados, mas como é de costume em todas as linguagens, criaremos um Hello World. Assim enxergarão uma frase, no console.

```csharp
using System;

class ConsoleCsharp
{
    static void Main()
    {
        Console.WriteLine("Hello, World !!!");
        Console.ReadLine();
    }
}
```

Pronto! Agora temos uma mensagem do console utilizando o C#.

Avançaremos com os conceitos.

[2.6 - O primeiro programa em C#](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/o-que-e-c-e-net/#2-6-o-primeiro-programa-em-c)




[Voltar ao Índice](#indice)

---

## <a name="parte4">Tipos de Variáveis</a>

Apresentaremos os tipos de dados e variáveis que a linguagem oferece. Para passarmos este conteúdo, trabalharemos dentro de um contexto. O contexto escolhido, para explicação deste módulo, foi o ambiente de uma empresa, onde há funcionários. 

O conceito funcionários engloba vários dados e características que exemplificaremos. Começaremos pelo número da matrícula do funcionário, desta forma estaremos trabalhando com números 

```csharp 
using System; 
class ConsoleCsharp
{ 
    static void Main() { 
        int matricula; 
        string nome; 
        string sobrenome; 
        DateTime dataNascimento; 
        decimal salario; 
        bool feriasVencidas; 
        char sexo; 
        
        Console.WriteLine("Hello, World !!!"); 
        
        Console.ReadLine(); 
        } 
} 
``` 

Tipo | Descrição 
------ | ------------- 
int | Números inteiros 
decimal | Números quebrados, com casas decimais 
string | Grupo de caracteres 
DateTime | Reservado para datas 
bool | Verdadeiro ou falso 
char | Armazena apenas um caracter 

Depois de declararmos todos os dados do funcionário, começaremos a alimentar estas variáveis, com dados mais sólidos. 

Para atribuir dados a estas variáveis, utilizamos o operador **(=)**, assim como na maioria das linguagens. 

```csharp 
using System; 
class ConsoleCsharp 
{ 
    static void Main() { 
        int matricula = 10; 
        string nome = "Pedro"; 
        string sobrenome = "Silva"; 
        DateTime dataNascimento = DateTime.Now; 
        decimal salario = 1000.50m; 
        bool feriasVencidas = true; 
        char sexo = 'M'; 
        
        Console.WriteLine(matricula); 
        Console.ReadLine(); 
        } 
} 

``` 

Neste ponto já temos todas as variáveis com valores atribuídos. 

Seguem algumas observações da linguagem: 

1. Strings, sempre, deverão ser passadas com aspas duplas. Em outras linguagens, uma string pode ser atribuída utilizando qualquer tipo de aspas, tanto a simples quanto a dupla. 

2. O contrário se aplica ao tipo **char**, que deverão ser passados utilizando aspas simples, para diferenciar de uma string, pois o char é capaz de armazenar apenas um caracter.

3. Quando atribuimos um número decimal, devemos passar ao final do número, a letra **m**, para que a linguagem entenda que estamos falando de uma número decimal. A letra m pode ser maiúscula ou minúscula e deverá ser utilizada, sempre. 

4. O **DateTime** nos fornece muitos tipos de dados, em nosso exemplo utilizamos o **now**, mas pode pegar mês, ano ou outros valores, de uma forma muito fácil. Após estas considerações, alteraremos a string **Hello World** por nossas variáveis, para testar. Colocamos a matrícula para ser impressa, mas vocês podem duplicar, para exibir todas ou alterando, uma por vez. Basta executar o código, para testarem. 

## Trabalhando com strings 

```csharp 
using System; 
class ConsoleCsharp { 
    static void Main() { 
        string nome = "Pedro"; 
        string sobrenome = "Silva"; 
        Console.WriteLine(nome + " " + sobrenome); 
        Console.WriteLine(String.Format("{0} {1}", nome, sobrenome)); 
        Console.ReadLine(); 
        } 
    } 
``` 

Notem que, no primeiro **WriteLine** utilizamos o método de concatenação para unir dois valores em uma string e no segundo, utilizamos o **String.Format**, que é o melhor método para configurar uma string. Observem que os valores entre chaves serão substituídos, ordenadamente, pelos valores passados, posteriormente. 

Utilizando este método, podemos unir quantas variáveis quisermos em uma string e podemos inserir textos entre as variáveis. Ambas as formas estão corretas, mas aconselhamos trabalhar com string format, por ser mais organizada.

[Variáveis e tipos primitivos](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/variaveis-e-tipos-primitivos/)



[Voltar ao Índice](#indice)

---

## <a name="parte5">Operadores aritiméticos</a>

```csharp
        int a = 15;
        int b = 2;
        // + - * % 
       //decimal resultado = a / b;
       decimal]resultado = Convert.ToDecimal(a) / Convert.ToDecimal(b);
``` 

[Voltar ao Índice](#indice)

---

## <a name="parte6">Atribuição, incremento e decremento</a>

```csharp
            a = a + 1;
            a++;
            a--;
            a += 5;
            a -= 3;
            Console.WriteLine(a)
```

[Voltar ao Índice](#indice)

---

## <a name="parte7">Estrutura condicional</a>

```csharp
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
                default: Console.WriteLine("Indefinido");
                    break;
            }
```

[Voltar ao Índice](#indice)

---

## <a name="parte8">Estrutura repetição</a>

```csharp
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

```

[Voltar ao Índice](#indice)

---

## <a name="parte9">Operadores comparativos</a>

```csharp
            int x = 5;
            int y = 10;
            if( x > y) // == , !=, >=, <=
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
``` 

[Voltar ao Índice](#indice)

---

## <a name="parte10">Escrevendo métodos</a>

 Para avançarmos com este assunto, apaguem todos os exemplos anteriores, ou salvem em algum lugar, caso queiram manter um histórico. O importante é que tenhamos uma estrutura limpa, para exemplificarmos bem, este assunto. 
 
 Sem dúvida, um dos assuntos mais importantes para quem quer trabalhar com a linguagem. Métodos são muito úteis e muito utilizados, em qualquer projeto. Com métodos, conseguimos otimizar tarefas e ganhar muito tempo com operações repetitivas. 
 
 Desta forma, tudo que for repetitivo, pode virar um método, para que ganhemos tempo e organização. É muito importante que o método tenha apenas uma responsabilidade. Assim, podemos ter um método para somar, outro para subtrair, outro para dividir e etc. O importante é não termos um método com muitas responsabilidades. ## Estrutura de um método 
 
 ```csharp 
 public static 
 void ExibirMensagem() 
 { 
     Console.WriteLine("Mensagem exibida"); 
     } 
     static string RetornarString() 
     { 
         string texto = "Mensagem retornada"; 
         return texto; 
         } 
 ``` 
 
 Acima temos dois tipos de métodos: 
 
 1. Método público, sem retornar valores 
 
 2. Método privado, retornando um valor Temos que informar os parâmetros que formam a declaração de um método. 
 
 Primeiro, temos o modificador de acesso que pode ser **public** ou **private**. Se não informarmos nenhum dos dois, a linguagem entenderá que se trata de um método private, por padrão. 
 
 Um método público, pode ser acessado de qualquer local da aplicação, já o método private, só pode ser acessado de um elemento que esteja no mesmo escopo, ou na mesma classe. 
 
 Em seguida, informamos se é **static** ou não. Em nosso caso, como nosso método **Main** é static, podemos definir os métodos como static, para que o visual studio consiga reconhecer estas funções e nos ajudar com o autocomplete. 
 
 No próximo parâmetro, devemos informar se o método retornará alguma informação ou não. Se não retornar, devemos informar **void**, caso contrário, devemos informar o tipo de dado que ele retornará. 
 
 Em nosso exemplo, temos uma do tipo void e outro que retorna uma string. Por último, temos que nomear o método, seguido de parênteses, onde serão acrescentados parâmetros, caso existam. Falaremos sobre parâmetros no próximo módulo. Dentro das chaves, desenvolveremos todas as ações que compõem aquele método. # Chamando um método 
 
 ```csharp 
 using System; 
 class ConsoleCsharp { 
     public static void ExibirMensagem() { 
         Console.WriteLine("Mensagem exibida"); 
         } 
         static string RetornarString() { 
             string texto = "Mensagem retornada"; 
             return texto; } 
             static void Main() { 
                 ExibirMensagem(); 
                 string retornada = RetornarString(); 
                 Console.WriteLine(retornada); 
                 Console.ReadLine(); 
                 } 
} 
 ``` 
 
 Notem que, para executar um método, basta chamar o mesmo nome que o registramos. No exemplo acima, executamos o método que imprime uma mensagem **ExibirMensagem()** e atribuímos o valor do método **RetornaString()** para uma variável, para depois imprimí-la. Isso porque o método retorna uma string, então podemos atribuir o valor retornado a uma variável.

Pessoa.cs
```csharp
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

```

```csharp
Pessoa pessoa1 = new Pessoa();
            pessoa1.falar("OLAAA!!");
```

[Voltar ao Índice](#indice)

---

## <a name="parte11">Parâmetros</a>

 Todo método pode, ou não, receber parâmetros para sua execução. Vejam alguns exemplos de métodos com parâmetros. 
 
 ```csharp
 using System; 
 class ConsoleCsharp { 
     public static void ImprimirValor(decimal valor, string mensagem) { 
         // Utilizando String Format 
         // Console.WriteLine(String.Format("{0} {1}", mensagem, valor) ); 
         Console.WriteLine(mensagem + valor);
         } 
         static void Main() 
         { 
             int numero = 100.33m; 
             ImprimirValor(numero, "Eu informei o valor : "); 
             Console.ReadLine(); 
        } 
} 
 ``` 
 
 Para a declaração do método, não modificamos nada nos padrões já passados, apenas adicionamos os parâmetros, informando o tipo de cada um, dentro dos parênteses. 
 
 Não existe um número máximo de parâmetros, podemos adicionar quantos o método precisar, de acordo com o projeto. A chamada do método não muda. Agora, temos a necessidade de passar os parâmetros, que são exigidos. 
 
 Fiquem atentos na ordem que os parâmetros são passados, eles deverão estar na mesma ordem que são passados no método. 
 
 ### Exemplo de parâmetro sem referência 
 
 ```csharp
 using System; 
 class ConsoleCsharp { 
     static void Soma10(int valor) { 
         valor += 10; 
         Console.WriteLine(valor); 
         } 
         static void Main() { 
             int valorInicial = 20; 
             Soma10(valorInicial); 
             Console.WriteLine(valorInicial); 
             Console.ReadLine(); 
        } 
} 
 ``` 
 
 Estamos imprimindo duas vezes o resultado: uma vez dentro da função e outra, logo depois da chamada da função. Fizemos isso para vocês observarem que, mesmo a função somando 10 na variável, quando a imprimimos, depois da função, o valor dela continua sendo o mesmo. 
 
 Neste caso, ela começa com o valor 20 e dentro do método passa a ser 30, mas, logo depois ela volta a ser 20. Isso acontece porque dentro do método o escopo é outro, não tem o poder de alterar a variável que se encontra fora dele. 
 
 Ocorre que a linguagem cria uma cópia do valor da variável e altera esta cópia, mantendo a variável original, com o mesmo valor. Para conseguirmos alterar o valor final da variável precisamos passar o nosso parâmetro como referência, desta maneira não estamos passando uma cópia, mas sim um apontamento para o espaço de memória que esta variável ocupa em nosso computador. Desta maneira estamos trabalhando com ponteiros. 
 
 Quando passamos o parâmetro como referência, o método tem o poder de alterar o valor desta variável porque se trata da variável e não uma cópia dela. 
 
 ### Exemplo de parâmetro com referência 
 
 ```csharp 
 using System; 
 class ConsoleCsharp { 
     static void Soma10(ref int valor) { 
         valor += 10; 
         Console.WriteLine(valor); 
         } static void Main() { 
             int valorInicial = 20; 
             Soma10(ref valorInicial); 
             Console.WriteLine(valorInicial); 
             Console.ReadLine(); 
        } 
} 
 ``` 
 
 A palavra reservada **ref** deve ser passada tanto na chamada do método quanto no método. Analisem o exemplo acima e verifiquem que agora teremos duas vezes o valor 30, sendo impressos.

[Voltar ao Índice](#indice)

---

## <a name="parte12">Classes</a>

Para falarmos de classes e objetos vamos apagar, novamente, todo conteúdo e exemplos que fizemos até agora, deixando somente a estrutura inicial. A maneira mais próxima de atingir um exemplo real, dentro de um sistema, é utilizando uma classe ou um objeto. Quando utilizamos o termo, exemplos reais, estamos querendo falar sobre pessoas, carros, empregado, documento e etc. Tudo que for um contexto, da vida real, e que conseguimos transformar em código, através das classes e objetos. O primeiro passo será criarmos a nossa classe de exemplo. 

Ela se chamará **Pessoa**. Para criarmos uma classe, basta acessarmos a pasta raiz do projeto e adicionarmos um novo arquivo com o nome **Pessoa.cs**. O Visual Studio já permite criar um arquivo do tipo **class**. Isso pode ser feito manualmente. O importante é observarem que, quando criamos um arquivo do tipo classe, ele já vem com um **namespace** configurado. Mais importante, ainda, é saberem que, para conseguirem utilizar esta classe, em outros contextos, eles devem estar no mesmo namespace, caso contrário, o Visual Studio não a encontrará. 

## Estrutura da classe 

```csharp 

using System; 
namespace ConsoleCsharp 
{ 
    public class Pessoa 
    { 
        public string nome; 
        public string sobrenome; 
        public idade; 
        public char sexo; 
        // Construtor public Pessoa() { } 
        public void Falar(string mensagem) 
        {  
            Console.WriteLine(mensagem); 
        } 
    } 
} 

``` 

Observem que temos o **namespace** englobando toda nossa classe e depois configuramos uma classe com modificador de acesso **public**. 
Significa que, outros contextos que estiverem dentro do mesmo namespace, conseguirão enxergar esta classe, caso fosse private, nem estando no mesmo namespace seria possível visualizá-la. 

Uma classe é sempre composta por propriedades e métodos. Também são conhecidas como características e comportamentos. 

Em nosso exemplo temos algumas propriedades como: nome, sobrenome, idade e sexo. Existe também um método chamado **Falar**, que imprime uma frase no console. Trata-se de uma classe muito simples. 

## Instanciando uma classe 

```csharp
using System; 
namespace ConsoleCsharp 
{ 
    class ConsoleCsharp 
    { 
        static void Main() 
        { 
            Pessoa p = new Pessoa(); 
            string mensagem = "Olá, falei"; 
            p.Falar(mensagem); 
            Console.ReadLine(); 
            } 
    } 
}
```

O primeiro detalhe que devem perceber é que estamos utilizando o mesmo namespace, para que seja possível a comunicação com a classe. Depois, estamos utilizando uma classe pública que seria o segundo fator de comunicação. 

Quando criamos um objeto de uma classe, estamos criando a representação da classe. A representação de uma classe é criada a partir de um método conhecido como **construtor**. Para criar um construtor, basta criar um método com o mesmo nome da classe. 

Desta forma podemos instanciar um objeto sem que o Visual Studio apresente algum erro. Depois que instanciamos um objeto, basta que declaremos o objeto seguido de ponto, para ter acesso a todos os métodos e propriedades que sejam públicas. Vejam um exemplo de acesso a um método e a uma propriedade: `p.name = "João"` `p.Falar('Minha mensagem')` Agora que sabemos como acessar propriedades de um objeto, iremos popular a nossa pesso **p**. 

```csharp 
using System; 
namespace ConsoleCsharp 
{ 
    class ConsoleCsharp 
    { 
        static void Main() 
        { 
            Pessoa p = new Pessoa(); 
            // Propriedades 
            p.nome = "João"; 
            p.sobrenome = "Gomes"; 
            p.idade = 20; 
            p.sexo = 'M'; 
            // Método 
            p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.nome, p.sobrenome, p.idade)); 
            Console.ReadLine(); 
            } 
    } 
} 
```

 Desta forma, criamos um objeto, adicionamos valores a todas as propriedades e acionamos o método **Falar**, passando a mensagem, utilizando propriedades do próprio objeto. Vale lembrar que, quando trabalhamos com objetos, se intanciamos outro objeto com o mesmo nome, perderemos todas as informações anteriores, porque ele separa outro espaço na memória para o armazenamento de dados e apaga o espaço reservado, anteriormente. 

 ```csharp
 static void Main() 
 { 
     Pessoa p = new Pessoa(); 
     // Propriedades 
     p.nome = "João"; 
     p.sobrenome = "Gomes"; 
     p.idade = 20; 
     p.sexo = 'M'; 
     Pessoa p = new Pessoa(); 
     // Método 
     p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.nome, p.sobrenome, p.idade)); 
     Console.ReadLine(); } 
 ``` 

 Observem que, antes de acionar o método **Falar**, criamos outro objeto da classe Pessoa, em uma variável com o mesmo nome da anterior. Isso fará com que nosso método imprima a frase, mas com valores nulos, porque os nossos dados setados, anteriormente, foram perdidos. 
 
 Façam este teste para checarem. Caso coloquem outro nome para o objeto, o código continua o mesmo, imprimindo da mesma forma, o grande problema é criar um objeto com o mesmo nome do anterior. Fiquem atentos. O mesmo acontece quando colocamos outro valor para alguma propriedade, antes de exibir um método, isso significa que o valor impresso sempre será o último atribuído. # Utilizando construtor para iniciar dados Podemos utilizar o construtor de uma classe para iniciar os objetos instanciados com valores preestabelecidos. Isso não significa que o usuário não possa modificar depois, significa, apenas, que as propriedades terão valores iniciais. Vejam o exemplo: 
 
 ```csharp 
 using System; 
 namespace ConsoleCsharp 
 { 
     public class Pessoa 
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
 ``` 
 
 Agora, toda vez que instanciarmos um objeto, as propriedades nome, sobrenome e idade, terão um valor padrão, conforme exemplo acima. 
 
 No exemplo abaixo, manteremos o exemplo anterior, onde adicionamos os dados, manualmente, e em seguida, instanciaremos o mesmo objeto, mas não adicionaremos valor. Desta forma, vocês conseguirão notar que o valores foram apagados, mas outros valores foram adicionados, automaticamente, pelo construtor. 
 
 ```csharp 
 using System; 
 namespace ConsoleCsharp 
 { 
     class ConsoleCsharp 
     { 
         static void Main() 
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
 ```
 
 Fiquem atentos ao trabalharem com objetos. Sempre que precisarem de novos objetos, vocês deverão criar com outros nomes para não perderem os dados. Vocês podem instanciar quantos objetos forem necessários.

Para Saber Mais:  
[Classes e objetos](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/classes-e-objetos/)

[Voltar ao Índice](#indice)

---

## <a name="parte13">Encapsulamento</a>

 O encapsulamento é uma forma de segurança, muito utilizada nas classes. Para encapsular um propriedade, basta alterarmos os modificadores de acesso, para private. Desta forma, estamos bloqueando o acesso externo e permitindo, somente, o acesso interno para aquela propriedade. Vejam no exemplo abaixo: 
 
 ```csharp
 using System; 
 namespace ConsoleCsharp 
 { 
     public class Pessoa 
     { 
        private string nome;
        private string sobrenome;
        private int idade;
        private char sexo;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public int Idade { get => idade; set => idade = value; }
        public char Sexo { get => sexo; set => sexo = value; }
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
 ``` 
 
 Além de alterarmos o modificador de acesso para private, estamos criando um método público, com o mesmo nome da propriedade, porém com a primeira letra maiúscula. Esta é uma convenção adotada, mas vocês podem utilizar outro nome, se desejarem. Depois de criarmos este método público, declararemos mais dois métodos internos: **get** e **set**. O get tem a função de retornar o valor da propriedade em questão e o set, a função de atribuir valores, uma vez que não temos mais acesso externo, esta passa a ser a única forma de acesso. Depois de encapsular as propriedades na classe, devemos modificar o modo de chamá-las e também o modo de atribuição de valores. Devemos chamar com a primeira letra maiúscula, conforme convenção criada. 
 
 ```csharp 
 using System; 
 namespace ConsoleCsharp 
 { 
     class ConsoleCsharp 
     { 
         static void Main() 
         { 
             Pessoa p = new Pessoa(); 
             // Propriedades 
             p.Nome = "João"; 
             p.Sobrenome = "Gomes"; 
             p.Idade = 20; 
             p.Sexo = 'M'; 
             // Método 
             p.Falar(String.Format("Olá, sou o {0} {1} e tenho {2} anos", p.Nome, p.Sobrenome, p.Idade)); 
             Console.ReadLine(); 
         } 
    } 
} 
 ``` 
 
 Assim, estamos chamando os atributos encapsulados e tendo o mesmo resultado. O Visual Studio nos ajuda a criar este encapulamento, basta configurarmos a propriedade como private, depois clicar em cima do nome da propriedade com o botão direito do mouse e ir até **Refactor/Encapsulate Field**. Desta forma, ele procurará todas as ocorrências que existam no código e perguntará se queremos implementar a maneira correta de acesso. Basta aceitar e ele configurará tudo. Além de proteger os dados de uma acesso externo, podemos aproveitar os métodos **set** de atribuição e fazer algumas validações. Um exemplo que podemos dar é referente a idade. Esta propriedade não pode ser negativa, uma vez que não existe idade negativa. Vejam o que podemos fazer para resolver este problema. Vejam o exemplo: 
 
 ```csharp 
     private int idade;
     public int Idade
        {
            set{if (value >= 0) idade = value;}
            get{ return idade; }
        }
 ``` 
 Apesar de podermos alterar o método **get**, não é muito usual e aconselhável, uma vez que o get tem função, apenas, de retornar algum dado. Existe a possibilidade de aplicar alguns filtros, antes de retornar, mas não é muito usual.

 Para saber + [Encapsulamento e Modificadores de Acesso](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/encapsulamento-e-modificadores-de-acesso/)

[Voltar ao Índice](#indice)

---

## <a name="parte14">Struct/Enum</a>

[Voltar ao Índice](#indice)

---

## <a name="parte15">Fila, Pilha e Listas</a>

[Voltar ao Índice](#indice)

---

