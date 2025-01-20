using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    public class Application11 : ApplicationBase
    {
        public Application11()
        {
            Cerinta = "A11: Realizati un generator de numere naturale aleatoare." +
                "Veti indica numarul de elemente si intervalul in care acestea pot avea valori. " +
                "Valorile vor fi stocate intrun array iar la final vor fi afisate in consola." +
                "Hint: Documentati - va cum putem genera numere aleatoare in C#. dam numarul de elemente pentru sir ";
        }
        public override void Launch()
        {

            int a = Utils.GetPositiveIntFromKeyboard("numarul de elemente din sir. Numarul trebuie sa fie pozitiv!");

            //if (avalid && a <= 0)
            //{
            //    avalid = false;
            //}



            //indicati intervalul in care putem avea valori
            const int limitaInferioara = -10;
            const int limitaSuperioara = 10;

            int[] arrayDeNumere = new int[a];

            Random generatorDeNumereAleatoare = new Random();

            //generam valori aleatoare pentru fiecare pozitie din array

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                //atribuiti un numar aleator pentru pozitia curenta din array
                arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                Console.Write(arrayDeNumere[i] + ", ");
            }

          
        }
    }
}
