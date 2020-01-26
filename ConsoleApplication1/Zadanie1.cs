using System;

namespace ConsoleApplication1
{
    public class Zadanie1
    {
        public static int zadanie(double x, double maxX)
        {
            int wynik;
            if (x <= 0.5 * maxX)
            {
                wynik = 0;
            }
            else
            {
                wynik = (int) (x / maxX * 100);
            }

            return wynik;
        }

       /* public static void displaying()
        {
            Console.WriteLine(zadanie(2.1,4.3));
        }*/
    }
}