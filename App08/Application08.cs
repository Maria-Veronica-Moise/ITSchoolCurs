using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App08
{
    public class Application08 : ApplicationBase
    {
        public Application08()
        {
            Cerinta = "*A8: Cititi un numar si calculati factorialul acestuia ( n! = 1*2*3*…*n).";
        }

        public override void Launch()
        {

            int n = Utils.GetIntFromKeyboard();
            int factorial = 1;
           

            Console.Write("Factorialul primelor numere naturale n este: ");

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

                Console.Write($"{factorial}, ");
            }

        }
    }
}
