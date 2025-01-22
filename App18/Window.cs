using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Window
    {


        public Window()
        {
            // Am putea pastra o lista cu toate butoanele aici

            Button button = new Button("Button 1");
            button.Clicked += CandUnButonEsteApasat;

            Button button1 = new Button("Button 2");
            button1.Clicked += CandUnButonEsteApasat;

            Button button2 = new Button("Button 3");
            button2.Clicked += CandUnButonEsteApasat;

            Button button3 = new Button("Button 4");
            button3.Clicked += CandUnButonEsteApasat;

            Button button4 = new Button("Button 5");
            button4.Clicked += CandUnButonEsteApasat;
        }

      

        public void CandUnButonEsteApasat(string name)
        {
            Console.WriteLine($"Butonul {name} a fost apasat");
        }
    }

}
