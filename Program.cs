using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CaracteresETextos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - Caracteres e Textos: \r\n");

            // character
            char primeiraletra = 'A';
            Console.WriteLine("A primeira letra do alfabeto é o _" + primeiraletra + "_. \r\n");
            // Se declaramos caracteres, teremos que necessariamente adicionar pelo menos um caracter entre as aspas simples.


            // A variável char é representada como número, caberia usar um número de 16 bits. Por isso, podemos pegar a primeiraLetra e colocar dentro dela um número.
            primeiraletra = (char)65;
            Console.WriteLine("Quando declaramos (char)65, estamos convertendo o número em caracter, e a representação do decimal 65 em caracter especial é o _" + primeiraletra + "_. \r\n");
            // O char é internamente um número na memória do computador, mas se tentarmos atribuir o valor 65 para a variável primeiraLetra, o CSharp não vai aceitar, porque quando escrevemos o número, não temos um caractere e sim um inteiro de 32 bits, e como a variável char cabe apenas 16 bits, precisamos fazer o casting, assim converteremos de um tipo para outro, ou seja o valor 65 para caractere, adicionando (char).

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine("Quando declaramos (char)(primeiraletra + 1), estamos convertendo (char)(65 + 1) em caracter, e a representação do decimal 66 em caracter especial é igual a letra _" + primeiraletra + "_. \r\n");

            // Ascii table (Tabela de American Standard Code). Trata-se de uma tabela com vários caracteres, entre eles encontraremos letras, números, cedilha, ou seja utilizam números decimais para apresentar caracteres especiais.


            string titulo = "Testando uma string no dia " + 26 + ". \r\n";
            Console.WriteLine(titulo);
            //string é a variável usada para representar um texto.

            string vazia = "";
            //Podemos criar uma variável vazia do tipo string, basta não adicionarmos um valor entre as aspas, e o C# vai rodar sem problemas.

            string cursosProgramacao = @"Criando uma lista:  
                 - .Net
                 - Java
                 - JavaScript";
            Console.WriteLine(cursosProgramacao);
            // Aqui estamos listando um texto, por isso criamos a string cursosProgramacao, adicionamos cada item, damos enter para cada linha, tiramos os (+) que aparecem, e adicionamos o @ antes das aspas para que ele entenda que devem haver as quebras entre cada item quando apertamos o enter.


            Console.ReadLine();
        }
    }
}
