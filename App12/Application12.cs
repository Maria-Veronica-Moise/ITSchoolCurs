using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    public class Application12 : ApplicationBase
    {
        public Application12()
        {
            Cerinta = "A12: Dati un numar natural de la tastatura." +
           " Numarul trebuie sa fie in intervalul definit in A11." +
           "Cautati numarul introdus in colectia generata in A11.Daca il gasiti, afisati" +
           " poziţia lui si intrerupeti funcţionarea metodei, altfel afisati un mesaj corespunzator lipsei lui." +
           "Hint: cheia “break” intrerupa rularea unei structuri repetitive.";
        }
        public  override void Launch()
        {

            int a = Utils.GetPositiveIntFromKeyboard("numarul de elemente din sir. Numarul trebuie sa fie pozitiv");
            int x = Utils.GetIntFromKeyboard("x");

            const int limitaInferioara = -10;
            const int limitaSuperioara = 10;

            int[] arrayDeNumere = new int[a];

            Random generatorDeNumereAleatoare = new Random();



            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                //atribuiti un numar aleator pentru pozitia curenta din array
                arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);

                Console.WriteLine(arrayDeNumere[i]);
            }

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                if (x == arrayDeNumere[i])
                {
                    Console.WriteLine($"Numarul {x} este pe pozitia {i + 1}.");
                    break;

                }
                else
                {
                    Console.WriteLine($"Numarul {x} nu a fost gasit.");

                }
            }
        }
    }
}
