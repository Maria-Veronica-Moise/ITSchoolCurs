﻿using ItSchool.AppUtilities;

namespace App15
{
    public class Application15 : ApplicationBase

    {
        public Application15()
        {
            Cerinta = "Avem un sir de 100 de numere aleatoare intre 0 si 9 (folositi A11)." +
                "Verificati numarul de aparitii pentru fiecare din aceste numere si afisati" +
                "rezultatele (Exemplu de afisaj in consola: “0 – 10 aparitii | 1 – 12 aparitii | 3 – 8 aparitii…”)";
        }
        public override void Launch()
        {
            int[] arrayDeNumere = Utils.GenereazaArrayDeNumereIntregi(100, 0, 9);

            int[] numarator = new int[10];

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                numarator[arrayDeNumere[i]]++;

                Console.Write(arrayDeNumere[i] + ", ");
            }

            Console.WriteLine();

            for (int i = 0;i < numarator.Length; i++)
            {
                Console.WriteLine(i + " - " + numarator[i]);
            }
        }
        
    }
}
