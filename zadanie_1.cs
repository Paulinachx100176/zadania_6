using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczby oddzielone spacją dla każdego wiersza tablicy:");
        int[,] tablica = WczytajTablice();

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);

        Console.WriteLine("Najbardziej zbliżone wiersze: {0} i {1}", najblizszeWiersze[0], najblizszeWiersze[1]);
    }

    static int[,] WczytajTablice()
    {
        string[] wiersze = Console.ReadLine().Split(' ');
        int liczbaWierszy = wiersze.Length;
        int liczbaKolumn = wiersze[0].Split(' ').Length;

        int[,] tablica = new int[liczbaWierszy, liczbaKolumn];

        for (int i = 0; i < liczbaWierszy; i++)
        {
            string[] elementy = wiersze[i].Split(' ');

            for (int j = 0; j < liczbaKolumn; j++)
            {
                tablica[i, j] = Convert.ToInt32(elementy[j]);
            }
        }

        return tablica;
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
                int roznica = ObliczRozniceWierszy(tablica, i, j, liczbaKolumn);

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

    static int ObliczRozniceWierszy(int[,] tablica, int i, int j, int liczbaKolumn)
    {
        int roznica = 0;

        for (int k = 0; k < liczbaKolumn; k++)
        {
            int elementIK = tablica[i, k];
            int elementJK = tablica[j, k];

            roznica += (elementIK - elementJK) * (elementIK - elementJK);
        }

        return roznica;
    }
}
