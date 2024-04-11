using System;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mkmin = 0;
            int mkmax = 101;
            int mkilosc1 = 0;
            int mkilosc2 = 0;
            Random mkrnd = new Random();

            int[] mktab = new int[20];

            /* Sortowanie porzez wstawianie */

            Console.WriteLine("SORTOWANIE POPRZEZ WSTAWIANIE\n\n" +
                "Losowe liczby przed sortowaniem:");
            for (int mkp1 = 0; mkp1 < mktab.Length; mkp1++)
            {
                mktab[mkp1] = mkrnd.Next(mkmin, mkmax);
                Console.Write(mktab[mkp1] + " ");
            }

            for (int mkp1 = 0; mkp1 < mktab.Length - 1; mkp1++)
            {
                for (int mkp2 = mkp1 + 1; mkp2 > 0; mkp2--)
                {
                    if (mktab[mkp2 - 1] > mktab[mkp2])
                    {
                        int mkp3 = mktab[mkp2 - 1];
                        mktab[mkp2 - 1] = mktab[mkp2];
                        mktab[mkp2] = mkp3;
                        mkilosc1++;
                    }
                }
            }

            Console.WriteLine("\n\nLosowe liczby zostały posortowane:");
            for (int mkp1 = 0; mkp1 < mktab.Length; mkp1++)
            {
                Console.Write(mktab[mkp1] + " ");
            }
            Console.WriteLine("\nTyle kroków trzeba było wykonać, aby tablica została posortowana: {0}", mkilosc1 + "\n\nSORTOWANIE BĄBELKOWE\n");

            /* Sortowanie bąbelkowe */

            Console.WriteLine("Losowe liczby przed sortowaniem:");
            for (int mkp1 = 0; mkp1 < mktab.Length; mkp1++)
            {
                mktab[mkp1] = mkrnd.Next(mkmin, mkmax);
                Console.Write(mktab[mkp1] + " ");
            }

            for (int mkp1 = 0; mkp1 < mktab.Length - 1; mkp1++)
            {
                for (int mkp2 = 0; mkp2 < mktab.Length - mkp1 - 1; mkp2++)
                {
                    if (mktab[mkp2] > mktab[mkp2 + 1])
                    {
                        int mkp3 = mktab[mkp2];
                        mktab[mkp2] = mktab[mkp2 + 1];
                        mktab[mkp2 + 1] = mkp3;
                        mkilosc2++;
                    }
                }
            }

            Console.WriteLine("\n\nLosowe liczby zostały posortowane:");
            for (int mkp1 = 0; mkp1 < mktab.Length; mkp1++)
            {
                Console.Write(mktab[mkp1] + " ");
            }
            Console.WriteLine("\nTyle kroków trzeba było wykonać, aby tablica została posortowana: {0}", mkilosc2);
        }
    }
}