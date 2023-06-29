using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wierszy tablicy:");
        int liczbaWierszy = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbę kolumn tablicy:");
        int liczbaKolumn = Convert.ToInt32(Console.ReadLine());

        int[,] tablica = new int[liczbaWierszy, liczbaKolumn];

        Console.WriteLine("Podaj elementy tablicy:");

        for (int i = 0; i < liczbaWierszy; i++)
        {
            string[] elementy = Console.ReadLine().Split(' ');

            for (int j = 0; j < liczbaKolumn; j++)
            {
                tablica[i, j] = Convert.ToInt32(elementy[j]);
            }
        }

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);

        Console.WriteLine("Najbardziej zbliżone wiersze: {0} i {1}", najblizszeWiersze[0], najblizszeWiersze[1]);
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int liczbaWierszy = tablica.GetLength(0);
        int liczbaKolumn = tablica.GetLength(1);

        int[] najblizszeWiersze = { 0, 0 };
        int najmniejszaRoznica = Int32.MaxValue;

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                int roznica = 0;

                for (int k = 0; k < liczbaKolumn; k++)
                {
                    int elementIK = tablica[i, k];
                    int elementJK = tablica[j, k];

                    roznica += (elementIK - elementJK) * (elementIK - elementJK);
                }

                if (roznica < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznica;
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }
}
