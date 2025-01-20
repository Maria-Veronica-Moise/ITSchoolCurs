using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.AppUtilities;

namespace App13
{
    public class Application13 : ApplicationBase
    {
        public Application13()
        {
            Cerinta = "A13: Calculati suma numerelor pozitive dintr-un sir de numere intregi (generat in A11).Folositi cheia “continue” pentru a sari peste numerele negative.";
        }
        public override void Launch()
        {

            int[] arrayDeIntrare = GetRandomGeneretedArray(-10, 10);

            int suma = 0;

            for (int i = 0; i < arrayDeIntrare.Length; i++)
            {
                if (arrayDeIntrare[i] <= 0)
                {
                    continue;
                }
                suma += arrayDeIntrare[i];
            }
            Console.WriteLine($"Suma numerelor pozitive din array-ul primit este: {suma}");


            int[] GetRandomGeneretedArray(int limitaInferioara, int limitaSuperioara)
            {
                //dam numarul de elemente pentru sir
                int a;
                Console.WriteLine();
                Console.Write("Introduceti numarul de elemente pentru sir: ");
                string ainput = Console.ReadLine();
                bool avalid = int.TryParse(ainput, out a);

                if (avalid && a <= 0)
                {
                    avalid = false;
                }


                while (!avalid)
                {
                    Console.WriteLine("Datele introduse nu sunt un numar intreg sau numarul este mai mic sau egal cu 0!");
                    Console.Write(" Introduceti un numar: ");
                    ainput = Console.ReadLine();
                    avalid = int.TryParse(ainput, out a);

                    if (avalid && a <= 0)
                    {
                        avalid = false;
                    }
                }


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
