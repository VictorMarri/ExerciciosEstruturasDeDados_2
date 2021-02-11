using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1.Exercicios
{
    class Q6
    {
        public static void Questao06()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            Console.WriteLine("Digite a quantidade de numeros aleatorios: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                list.Add(rnd.Next());
            }

            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }

            

            

        }
    }
}
