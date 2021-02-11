using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAED_1
{
    class Q9
    {
        public static void Questao09()
        {
            List<int> lista = new List<int>();

            int n = 100;

            for(int i =0; i <= n; i++)
            {
                lista.Add(i);
            }

            ParLista(lista);
        }

        public static void ParLista(List<int> lista)
        {
            foreach(int element in lista)
            {
                if (element % 2 == 0 && element !=0)
                {
                    Console.WriteLine(element + " = PAR");
                }
            }
        }
    }
}
