using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02
{
    public class Application02 : ApplicationBase
    {
        public Application02()
        {
            Cerinta = "Cititi dou numere de la tastatura,calculati produsul lor si afisati rezultatul ";
        }
        public override void Launch()
        {


            int a = Utils.GetIntFromKeyboard("a");
            int b = Utils.GetIntFromKeyboard("b"); 

            var produsul = a * b;
            Console.WriteLine($"Produsul numerelor {a} si {b} este {produsul}.");
        }
    }
}
