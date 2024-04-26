using System.Runtime.Intrinsics.X86;
using System;


namespace HelloWorld
{
    public class Tipos
    {
        public void Variable()
        {
            int a = 99;
            double b = 12.12d;
            float c = 0.0f;
            decimal d = .123m;
            byte f = 255;
            string e = "abc";
            char g = 'a';
            bool h = true;

            // Operadores

            // 6 + 2 = 8 Adição
            // 6 / 2 = 3 Divisão
            // 6 * 2 = 12 Multiplicação
            // 6 - 2 = 4 Subtração
            // 6 % 2 = 0.12 Restante
            // = Atribuição
            // += Incremento
            // -= Diminuir
            // *= Atribuição de multiplicação
            // /= Atribuição de divisão
            // ++
            // --
            // ! negação
            // 6 < 2 Menor que (verdadeiro se x for menor que y)
            // 6 <= 2 Menor ou igual a
            // 6 > 2 Maior que (verdadeiro se x for maior que y)
            // 6 >= 2 Maior que ou igual a
            // 6 == 2 Igualdade
            // 6 != 2 Não igual
            // x & y AND lógico ou bit a bi
            // x && y AND lógico
            // x | y OR lógico ou bit a bit.
            // x || y OR lógico
            // x ^ y XOR lógico ou bit a bit
            // => Declaração de lambda

            // is Retornará true se o operando esquerdo avaliado puder ser convertido no tipo especificado no operando à direita(um tipoestático)
            // as .Retorna o operando esquerdo convertido para o tipo especificado pelo operando à direita(um tipo estático), mas as retorna null em que(T)x lançaria uma exceção

            var idade = 34;
            const string pais = "Brasil";

            c = idade;
            // para ser um float o decimal precisa ser convertido
            c = (float)d;

            Console.WriteLine(pais);

            string frase = "O rato roeu a roupa do rei de roma!";

            Console.WriteLine(frase.Substring(0,5));
            Console.WriteLine(frase.Replace("rei", "casa"));

            // Remove espaços em branco
            frase.Trim();
            // Remove espaços em branco no final e no começo
            frase.TrimEnd();
            frase.TrimStart();

            // Remove caracteres especifico
            frase.Trim('!');

            // Adiciona caracteres até o tamanho especificado
            frase.PadLeft(10);
            frase.PadRight(10);

            // Concatenação
            string frase2 = frase + "Ensolarado";
            Console.WriteLine(frase2);

            // Interpolação
            string frase3 = $"{frase} Ensolarado";
            Console.WriteLine(frase3);


        }

    }
}
