using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1.Exercicios
{
    class Q2
    {
        public static void Questao2()
        {
            //Faça um programa que leia n números inteiros e os armazene em um Queue.
            //Calcule a soma e a média aritmética(use o comando FOREACH para iterar sobre os elementos).

            int n, size;
            int soma = 0;

            Queue QE = new Queue();

            Console.Write("Digite o numero de elementos que voce quer armazenar: ");
            size = int.Parse(Console.ReadLine());

            for(int i = 1; i <= size; i++)
            {
                Console.Write("Digite um numero para inserir no Queue");
                n = int.Parse(Console.ReadLine());
                QE.Enqueue(n);
            }

            foreach(int x in QE)  
            {
                soma += x;
            }

            Console.WriteLine("Soma Queue: " + soma);
            Console.WriteLine($"Media Queue: {(float)soma / QE.Count}");

            Console.ReadLine();

        }
    }
}
