using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App06
{
    public class Application06 : ApplicationBase
    {
        public Application06()
        {
            Cerinta = "Cititi un numar si afisati toate numerele de la 1 la n.";
        }
        
        public override void Launch()
        {
            int n = Utils.GetIntFromKeyboard();


            Console.Write("Numerele de la 1 la n sunt: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
