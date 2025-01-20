using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App07
{
    public class Application07 : ApplicationBase
    {
        public Application07()
        {
            Cerinta = "A7: Cititi un numar n si calculati suma primelor n numere naturale.";
        }
       
        public override void Launch()
        {


            int n = Utils.GetIntFromKeyboard();
            int suma = 0;
           

            for (int i = 0; i <= n; i++)
            {
                suma += i;

            }
            Console.WriteLine($"Suma primelor n numere naturale este: {suma} ");
        }
    }
}
