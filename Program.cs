using System;
namespace SegundoProjeto
{
    class Projeto
    {
        static void Main(String[] args)
        {
            /*1 – Uma empresa vende sorvetes no valor atacado, se o cliente
            comprar até 25 unidades, é cobrado R$ 1.50 por unidade, acima disso,
            é cobrado R$ 1.25. Faça um código que calcule quanto um
            determinado cliente irá pagar. Para isso, declare uma variável que
            armazenará a quantidade de sorvete (você pode escolher a
            quantidade)

            int quantidade = 15;

            if (quantidade <= 25 ) {
                float conta = quantidade*1.50f;
                Console.WriteLine("O valor é menor que 25, portanto o valor é " + conta);
            }else if(quantidade >= 25)
            {
                float resultado = quantidade * 1.25f;
                Console.WriteLine("O valor é maior que 25, portanto o valor é " + resultado);
            }
            */

            /*2 – Declare uma variável com um número, se ele for maior que 10, faça
            o cálculo do número + 10 * 2. Senão, faça número + 9 * 3 – 8. (Você pode
            escolher o número da variável)

            int variavel = 50;

            if(variavel > 10 ) {
                float conta = variavel + (10 * 2);
                Console.WriteLine("O valor é maior que 10, então ele se torna: " + conta);
            }else
            {
                float contaDois = (variavel + 9) * 3 - 8;
                Console.WriteLine("O valor é menor que 10, então ele se torna: " + contaDois);
            }
            */

            /*3 – Faça um código que verifique se um número é positivo ou
            negativo (você pode escolher o número da variável)

            int valor = 22;

            if (valor > 0) {
                Console.WriteLine("O valor é positivo");
            }else if (valor < 0)
            {
                Console.WriteLine("O valor é negativo");
            }else
            {
                Console.WriteLine("O valor é igual a 0");
            }
            */

            /*4 – Faça um código que tenha duas variáveis numéricas e mostre qual
            delas é a maior (você pode escolher os números das variáveis)

            int um = 29;
            int dois = 24;

            if ( um > dois ) {
                Console.WriteLine("A variável Um é maior que a variável Dois");
            }else if ( dois > um )
            {
                Console.WriteLine("A variável Dois é maior que a variável Um");
            }else
            {
                Console.WriteLine("As duas variáveis possuem valores iguais");
            }*/

            /*5 – Um professor deseja um sistema para o cálculo da média dos seus
            alunos, para isso, declare duas variáveis para as notas, realize o cálculo
            da média e mostre, se a média for maior ou igual a 7, mostre
            “Aprovado”, senão mostre “Reprovado” (você pode escolher os
            números das variáveis)*/

            float notaUm = 7.5f;
            float notaDois = 10f;
            double media = (notaUm + notaDois) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado! Sua nota é: " + media);
            }else 
            {
                Console.WriteLine("Reprovado! Sua nota é: " + media);
            }

        }

    }
}