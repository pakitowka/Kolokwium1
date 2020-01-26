using System;

namespace ConsoleApplication1
{
    public class Zadanie2
    {
        public static int[] woda = new int[12];

        public void wypelnienie()
        {
            Random random = new Random();
            
            for (int i = 0; i < woda.Length; i++)
            {
                woda[i] = random.Next(5,15);
            }
        }

        public static int Prognozowane()
        {
            return woda[0] * 12;
        }

        public static double PrognozowaneOplaty()
        {
            return Prognozowane() * 1.40;
        }

        public static int faktzuzycie()
        {
            int wodarok=0;
            for (int i = 0; i < woda.Length; i++)
            {
                wodarok += woda[i];
            }

            return wodarok;
        }

        public static double faktcena()
        {
            return faktzuzycie()*1.40;
        }

        public static double roznica()
        {
            return faktcena() - PrognozowaneOplaty();
        }


        public static void displaying()
        {
            for (int i = 0; i < woda.Length; i++)
            {
                Console.WriteLine(woda[i]);
            }

            Console.WriteLine(Prognozowane());
            Console.WriteLine(PrognozowaneOplaty());
            Console.WriteLine(faktzuzycie());
            Console.WriteLine(faktcena());
            Console.WriteLine(roznica());
            
        }
    }
}