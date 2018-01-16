using System;

namespace proberenVanTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // TryParse met als return-waarde false
            string naam = "Robbe";
            int x = 5;
            bool succes = Int32.TryParse(naam, out x);
            Console.WriteLine(succes);

            // TryParse met als return-waarde false
            string getal = "111111111111";
            int y = 4654;
            bool Yeey = Int32.TryParse(getal, out y);
            Console.WriteLine(Yeey);

            //Parse zonder error
            string number = "100";
            int getal2 = Int32.Parse(number);
            Console.WriteLine(getal2);

            // TryParse met als return-waarde true
            string number2 = "100";
            bool getal3 = Int32.TryParse(number2, out int b);
            Console.WriteLine(getal3);

            // TryParse met als return-waarde true
            string number3 = "100";
            int value;
            bool succeeded = Int32.TryParse(number3, out value);

        }
    }
}
