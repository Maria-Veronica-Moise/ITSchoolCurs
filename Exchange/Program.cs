
using System.Xml.Schema;

public class Program
{
    public class Currency
    {

        public string CurrencyName { get; set; }

        public string CurrencyAbbreviation { get; set; }

        public decimal CurrencyValue { get; set; }

        public int CurrencyCode { get; set; }

        public Currency( string name, string abbreviation, decimal value, int code)
        {
            CurrencyName = name;
            CurrencyAbbreviation = abbreviation;
            CurrencyValue = value;
            CurrencyCode = code;
        }
        private static void Main(string[] args)
        {

            


           

           

            

           



            

            Currency currencySelected;
            for (int i = 0; i < currency.Length; i++)
            {
                currencySelected = currency[i];
              

            }


            int alegere;
            Console.WriteLine();
            Console.WriteLine("Enter the currency code (0-10) or its abbreviation.");
            Console.WriteLine();
            string alegereInput = Console.ReadLine();
            bool alegerevalidata = int.TryParse(alegereInput, out alegere);
            

            while ((!alegerevalidata) || alegere < 0 || alegere > currency.Length)  
            {
                
                alegereInput = Console.ReadLine();
                alegerevalidata = int.TryParse(alegereInput, out alegere);
                
            }
            Console.WriteLine($"You have selected: {alegere}");




            //Input = SelectCurrency();


        }
    }
}


