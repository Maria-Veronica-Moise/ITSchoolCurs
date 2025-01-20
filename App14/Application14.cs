using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class Application14 : ApplicationBase
    {
        public Application14()
        {
            Cerinta = "A14: Afisati toate numerele care sunt prime dintr-un sir de numere intregi (generat la A11)." +
             "Un numar este prim daca acesta se imparte fara rest doar la 1 si la el insusi. " +
             "Ignorati orice numar din sir care este -1, 0 sau 1. " +
             "Considerati si   numerele nagative ca fiind prime.";
        }
        public override void Launch()
        {


            int[] arrayDeIntrare = GetRandomGeneretedArray(-100, 100);

            for (int i = 0; i < arrayDeIntrare.Length; i++)
            {
                if (arrayDeIntrare[i] == -1 || arrayDeIntrare[i] == 1 || arrayDeIntrare[i] == 0)
                {
                    continue;
                }
                if (VerificaNumarPrim(arrayDeIntrare[i]))
                {
                    Console.WriteLine(arrayDeIntrare[i] + " este prim.");
                }
            }



            bool VerificaNumarPrim(int numar)
            {
                int copie = numar;

                if (copie <= 0)
                {
                    copie *= -1;
                }

                for (int i = 2; i < copie; i++)
                {
                    if (copie % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            int[] GetRandomGeneretedArray(int limitaInferioara, int limitaSuperioara)
            {
                //dam numarul de elemente pentru sir
                int a = Utils.GetPositiveIntFromKeyboard("numarul de elemente din sir. Numarul trebuie sa fie pozitiv");


                int[] arrayDeNumere = new int[a];

                Random generatorDeNumereAleatoare = new Random();

                //generam valori aleatoare pentru fiecare pozitie din array

                for (int i = 0; i < arrayDeNumere.Length; i++)
                {
                    //atribuiti un numar aleator pentru pozitia curenta din array
                    arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                    Console.Write(arrayDeNumere[i] + ", ");
                }
                Console.WriteLine();

                return arrayDeNumere;
            }

        }
    }
}
