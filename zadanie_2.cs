using System;

class Program
{
    static void Main()
    {
        double x_poczatek = 2.0;
        double y_poczatek = 3.0;
        double x_koniec = 5.0;
        double y_koniec = 7.0;

        double dlugosc_odcinka = ObliczDlugoscOdcinka(x_poczatek, y_poczatek, x_koniec, y_koniec);
        Console.WriteLine("Długość odcinka: " + dlugosc_odcinka);
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dlugosc;
    }
}
