using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App03
{
    public class Application03 : ApplicationBase
    {
        public Application03()
        {
            Cerinta = "Cititi un numar si afisati patratul acestuia.";
        } 
        public override void Launch()
        {

            int a = Utils.GetIntFromKeyboard("a");
            Console.WriteLine($"Valoarea lui a este: {a}.");

            int patrat = (int)Math.Pow(a, 2);
            Console.WriteLine($"Patratul numarului {a} este {patrat}.");
        }

    }
}
