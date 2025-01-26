using App01;
using App02;
using App03;
using App04;
using App05;
using App06;
using App07;
using App08;
using App09;
using App10;
using App11;
using App12;
using App13;
using App14;
using App15;
using App16;
using App18;
using ItSchool.AppUtilities;

namespace ApplicationController
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ApplicationBase.Applications.AddRange(
                [
                new Application01(),
                new Application02(),
                new Application03(),
                new Application04(),
                new Application05(),
                new Application06(),
                new Application07(),
                new Application08(),
                new Application09(),
                new Application10(),
                new Application11(),
                new Application12(),
                new Application13(),
                new Application14(),
                new Application15(),
                new Application16(),
                new Application18(),
                ]);

            //ApplicationBase.Applications.Add(new Application01());
            //ApplicationBase.Applications.Add(new Application02());
            //ApplicationBase.Applications.Add(new Application03());
            //ApplicationBase.Applications.Add(new Application04());
            //ApplicationBase.Applications.Add(new Application05());
            //ApplicationBase.Applications.Add(new Application06());
            //ApplicationBase.Applications.Add(new Application07());
            //ApplicationBase.Applications.Add(new Application08());
            //ApplicationBase.Applications.Add(new Application09());
            //ApplicationBase.Applications.Add(new Application10());
            //ApplicationBase.Applications.Add(new Application11());
            //ApplicationBase.Applications.Add(new Application12());
            //ApplicationBase.Applications.Add(new Application13());
            //ApplicationBase.Applications.Add(new Application14());

            //ApplicationBase[] applications = new ApplicationBase[]
            //{
            //    new Application01(),
            //    new Application02(),
            //    new Application03(),
            //    new Application04(),
            //    new Application05(),
            //    new Application06(),
            //    new Application07(),
            //    new Application08(),
            //    new Application09(),
            //    new Application10(),
            //    new Application11(),
            //    new Application12(),
            //    new Application13(),
            //    new Application14(),
            //};

            Console.WriteLine();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lista aplicatiilor: ");

                for (int i = 0; i < ApplicationBase.Applications.Count; i++)
                {
                    Console.Write($"{(i + 1)}: ");
                    Console.WriteLine(ApplicationBase.Applications[i].Cerinta);

                }
                Console.WriteLine("0: EXIT");

                int input = CitesteNumarDeLaTastatura(0, ApplicationBase.Applications.Count);

                if (input == 0)
                {
                    return;
                }

                ApplicationBase.Applications[input - 1].Launch();


                Console.WriteLine();
                Console.WriteLine("Apasati tasta ENTER pentru a reveni la meniul anterior. ");
                Console.ReadLine();

            }



            static int CitesteNumarDeLaTastatura(int minim, int maxim)
            {
                Console.Write("Introduceti un numar intreg de la tastatura: ");

                string aInput = Console.ReadLine();
                bool aValid = int.TryParse(aInput, out int a);

                while (!aValid || (a < minim || a > maxim))
                {
                    Console.WriteLine("Datele introduse nu sunt valide!");
                    Console.Write("Introduceti un numar intreg de la tastatura: ");

                    aInput = Console.ReadLine();
                    aValid = int.TryParse(aInput, out a);
                }
                return a;
            }

        }
    }
}

