using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1.Exercicios
{
    class Q3
    {
        public static void Questao3()
        {
            //Faça um programa que leia n números inteiros e os armazene em um Stack. 
            //Calcule a soma e a média aritmética(use o comando FOREACH para iterar sobre os elementos).

            int n, size;
            int soma = 0;

            Stack SK = new Stack();

            Console.Write("Digite o numero de elementos que voce quer armazenar: ");
            size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                Console.Write("Digite um numero para inserir no Stack");
                n = int.Parse(Console.ReadLine());
                SK.Push(n);
            }

            foreach (int x in SK)
            {
                soma += x;
            }

            Console.WriteLine("Soma Stack: " + soma);
            Console.WriteLine($"Media Stack: {(float)soma / SK.Count}");

            Console.ReadLine();

        }
    }
}
