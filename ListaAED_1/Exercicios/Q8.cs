using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1.Exercicios
{
    class Q8
    {
        public static void Questao08()
        {
            List<int> list = new List<int>();
            int a = 10;

            for(int i = 0; i <= a; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Elementos na lista: ");

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(RetornaSoma(list));
        }

        public static int RetornaSoma(List<int> lista)
        {
            int a = 0;
            foreach(int item in lista)
            {
                a += item;
            }

            Console.Write("Soma: ");
            return a;
        }
    }
}
