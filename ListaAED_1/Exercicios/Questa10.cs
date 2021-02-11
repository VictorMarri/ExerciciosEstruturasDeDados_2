using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListaAED_1.Exercicios
{
    class Questa10
    {
        public static void Questao10()
        {
            Queue QE = new Queue();
            Random rnd = new Random();

            for(int i = 0; i <= rnd.Next(1, 500); i++)
            {
                QE.Enqueue(i);
            }

            Console.Write("Numero de ocorrencias: ");
            Console.WriteLine(ContaQueue(QE));
        }

        public static int ContaQueue(Queue queue)
        {
            int i = 0;
            foreach(int element in queue)
            {
                i++;
            }

            return i;
        }
    }
}
