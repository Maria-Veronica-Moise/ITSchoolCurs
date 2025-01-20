using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App04
{
    public class Application04 : ApplicationBase
    {
        public Application04()
        {
            Cerinta = "Cititi doua numere si afisati daca primul este mai mare decat al doilea.";
        }
        
        public override void Launch()
        {


            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b");

            

            if (a < b)
            {

                Console.WriteLine($"{b} este mai mare decat {a}.");
            }
            else if (a > b)
            {
                Console.WriteLine($"{a} este mai mare decat {b}.");
            }
            else
            {
                Console.WriteLine("Numerele sunt egale");
            }
        }
    }
}
