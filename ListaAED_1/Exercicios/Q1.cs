using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1.Exercicios
{
    class Q1
    {
        public static void Questao1FOR()
        {
            //Faça um programa que leia n números inteiros e os armazene em um ArrayList. Calcule a soma e a
            //média aritmética(use o comando FOR e depois o FOREACH).
            ArrayList AL = new ArrayList();
            float somaFOREACH = 0;
            float mediaFor, mediaFOREACH;
            var somaFor = 0;

            Console.Write("Qual o tamanho da coleção: ");
            int size = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= size; i++)
            {
                Console.Write($"Digite o {i} para adicionar: ");
                int number = int.Parse(Console.ReadLine());
                AL.Add(number);

            }

            for(var i = 0; i < AL.Count; i++)
            {
                somaFor += (int)AL[i]; //Casting
            }

            Console.WriteLine($"Soma FOR: {somaFor}");
            mediaFor = (float)somaFor / AL.Count;
            Console.WriteLine($"Media FOR: {(float)mediaFor} ");
            
            foreach(var x in AL)
            {
                somaFOREACH += (int)x;
            }

            Console.WriteLine();

            Console.WriteLine("Soma FOREACH: " + somaFOREACH);
            mediaFOREACH = somaFOREACH / AL.Count;
            Console.WriteLine("MEDIA FOREACH: " + mediaFOREACH);
            Console.ReadLine();

        }

        
    }
}
