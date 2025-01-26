using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    public class Window
    {
       public List<Button> Buttons = new List<Button>();


        public Window()
        {
            // Am putea pastra o lista cu toate butoanele aici

            Button button = new Button("Button 1");
            button.Clicked += CandUnButonEsteApasat;
            button.Clicked += CandUnButonEsteApasat2;
            button.Clicked -= CandUnButonEsteApasat;
            Buttons.Add(button);

            Button button1 = new Button("Button 2");
            button1.Clicked += CandUnButonEsteApasat;
            Buttons.Add(button1);

            Button button2 = new Button("Button 3");
            button2.Clicked += CandUnButonEsteApasat;
            Buttons.Add(button2);

            Button button3 = new Button("Button 4");
            button3.Clicked += CandUnButonEsteApasat;
            Buttons.Add(button3);

            Button button4 = new Button("Button 5");
            button4.Clicked += CandUnButonEsteApasat;
            Buttons.Add(button4);

      
        }

      

        public void CandUnButonEsteApasat(string name)
        {
            Console.WriteLine($"Butonul {name} a fost apasat");
        }

        public void CandUnButonEsteApasat2(string name)
        {
            Console.WriteLine($"DEMO");
        }
    }

}
