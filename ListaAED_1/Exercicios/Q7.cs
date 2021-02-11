using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListaAED_1.Exercicios
{
    class Q7
    {
        public static void Questao07()
        {
            Random rnd = new Random();
            Stack ST = new Stack();
            int n = 50;

            for(int i = 0; i<= 50; i++)
            {
                ST.Push(rnd.Next(0, 50));
            }

            Console.WriteLine("Pilha Comum: ");

            foreach(int a in ST)
            {
                Console.Write(a + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            InvertePilha(ST);

        }

        public static void InvertePilha(Stack stack)
        {
            Stack stacks = new Stack();

            foreach(int i in stack)
            {
                stacks.Push(i);
            }

            Console.WriteLine("Pilha Invetida");

            foreach(int i in stacks)
            {
                Console.Write(i + " ");
            }
        }
    }
}
