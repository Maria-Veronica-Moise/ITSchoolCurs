using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.AppUtilities;

namespace App01
{
    public class Application01 : ApplicationBase 
    {
        public Application01() : base()
        {
            Cerinta = "Declarati doua variabile, atribuiti valori numerice si afisati suma lor";
        }
        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");

            Console.WriteLine("Valoarea lui a este: " + a);


            int b = Utils.GetIntFromKeyboard("b");

            Console.WriteLine("Valoarea lui b este: " + b);

            Console.WriteLine($"Suma numerelor {a} si {b} este {a + b}.");

        }
    }
}
