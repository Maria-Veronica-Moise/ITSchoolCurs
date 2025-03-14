﻿using ItSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Application18 : ApplicationBase
    {

        public Application18()
        {
            Cerinta = "Realizati o aplicatie de tip consola in care sa indepliniti urmatoarele cerinte, in ordine:" +
                "Creati o clasa numita “Button” in care sa definiti un eveniment “Clicked”." +
                " Evenimentul va fi declansat printr-o metoda publica numita “SimulateClick”. " +
                "Elementele trebuie sa fie parte din obiecte." +
                "Creati o clasa numita “Window”. Aceasta se va abona la evenimentul “Clicked” al oricarui buton adaugat in Constructor," +
                " iar listenerul va afisa un mesaj in consola.Extindeti clasa Button, adaugand ca argument la eveniment numele butonului. " +
                "Modificati clasa Window astfel incat denumirea butonului apasat sa fie transmisia." +
                "Implementati un mecanism de citire de la tastatura in bucla. La introducerea corecta a denumirii unui buton existent, acestuia ii" +
                " va fi apelata metoda “SimulateClick”.Limitati elementele de cod astfel incat doar acele proprietati / metode dorite sa fie expuse.";
        }
        public override void Launch()
        {
            Window window = new Window();
            CitesteUnButton(window.Buttons);

        }

        public void CitesteUnButton(List<Button> buttons)
        {
            string a;
            Console.WriteLine("Introduce-ti numele unui buton.");
            a = Console.ReadLine();
            bool isButtonFound = false;

            while (!isButtonFound)
            {
                foreach (Button button in buttons)
                {
                    if (button.Name == a)
                    {
                        button.SimulateClick();
                        isButtonFound = true;
                        break;
                    }

                }

                if (!isButtonFound)
                {
                    Console.WriteLine("Numele introdus nu este valid. Introduce-ti un nume valid! ");
                    a = Console.ReadLine();
                }

            }
        }
    }
}
