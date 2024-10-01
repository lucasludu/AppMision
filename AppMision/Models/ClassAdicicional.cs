using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMision.Models
{
    public class ClassAdicicional
    {
        public static List<int[]> EncontrarPares(int[] lista, int objetivo)
        {
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < lista.Length; i++)
            {
                for (int j = i + 1; j < lista.Length; j++)
                {
                    if (lista[i] + lista[j] == objetivo)
                    {
                        result.Add(new int[] { i, j });
                    }
                }
            }
            return result;
        }
    }
}
