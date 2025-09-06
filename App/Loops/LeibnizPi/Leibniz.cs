using System.Security.Cryptography;

namespace App.Loops.LeibnizPi;

/// <summary>
/// Вычислить приближение числа PI по ряду Грегори-Лейбница.
/// </summary>
public static class Leibniz
{
    public static double Approximate(int terms)
    {
        if(terms <= 0) 
        {
        throw new ArgumentOutOfRangeException(nameof(terms));
        }

        double sum = 0.0;

        for (int K = 0; K < terms; K++)
        {
            double ke = 2 * K + 1;
            double term = 1.0 / ke;

            if (K % 2 == 1) 
            {
                term = -term;
            }
            sum += term;
        }

        return 4* sum;

    }
}
