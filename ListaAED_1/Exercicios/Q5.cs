using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1.Exercicios
{
    class Q5
    {
        public static void Questao5()
        {
            //– Faça um programa que preencha um ArrayList com os números entre 1 e 25.Pede - se:
            //• Imprima todos os elementos
            //• Imprima todos os elementos em ordem invertida
            //• Imprima todos os elementos em posições ímpares(o elemento da posição 1, 3, 5, ...)
            //• Imprima todos os elementos ímpares
            //• Imprima apenas os elementos da primeira metade do vetor(posição 0 a 12).

            ArrayList AL = new ArrayList(25);
            Random rnd = new Random();

            for(int i = 1; i <= AL.Capacity; i++) //Colocando elementos de 1 a 25 no array
            {
                AL.Add(rnd.Next(1, 25));
            }

            foreach(int x in AL) //Imprimindo todos os elementos do array
            {
                Console.WriteLine(x);
            }

            for(int i = 0; i < AL.Capacity; i+=2) //Imprimir elementos de posições impares do arraylist
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < AL.Capacity; i++) //Imprimir elemetos de fato impares dentro do arraylist
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            for(int i = 13; i > 25; i--) //Imprimir metade do ArrayList
            {
                Console.WriteLine(i);
            }

            AL.Reverse();

            foreach(int x in AL) //Imprimir Array Inverso.
            {
                Console.WriteLine(x);
            }






        }
    }
}
