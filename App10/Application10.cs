using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    public class Application10 : ApplicationBase
    {
        public Application10()
        {

            Cerinta = "A10: Cititi un numar n si inca un numar x si apoi n numere.Cautati numarul x in acest sir si afisati poziţia acestuia (sau un mesaj daca nu este citit.";
        }
        public override void Launch()
        {
            int n = Utils.GetIntFromKeyboard("n");
            int x = Utils.GetIntFromKeyboard("x");
            bool celPutinUnXGasit = false;



            for (int i = 0; i <= n; i++)
            {
                Console.Write($"(Pozitia {i})-Dati un numar: ");
                string nInput = Console.ReadLine();
                int numar = int.Parse(nInput);

                if (numar == x)
                {
                    celPutinUnXGasit = true;
                    Console.WriteLine($"Valoarea numarului x este pe pozitia numarului {i}.");

                }
                if (celPutinUnXGasit == false)
                {
                    Console.WriteLine("Valoarea numarul x nu a fost gasita.");

                }
            }

        }
    }
}
