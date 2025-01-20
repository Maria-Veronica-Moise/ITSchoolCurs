using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.AppUtilities;

namespace App09
{
    public class Application09 : ApplicationBase 
    {
        public Application09()
        {
            Cerinta = "A9: Afisati toate numerele pare de la 1 la 100 folosind o bucla pentru.";
        }
        public override void Launch()
        {
            int n = 100;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i},  ");
                }

            }
        }
    }
}
