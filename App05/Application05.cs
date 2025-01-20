using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class Application05 : ApplicationBase
    {
        public Application05()
        {
            Cerinta = "Cititi un numar si verificati daca este par sau impar.";
        }
        public override void Launch()
        {

            int a = Utils.GetIntFromKeyboard();


            if (a % 2 == 0)
            {
                Console.WriteLine("Numarul este par.");

            }
            else if (a % 2 == 1)
            {
                Console.WriteLine("Numarul este impar.");
            }
        }
    }
}
