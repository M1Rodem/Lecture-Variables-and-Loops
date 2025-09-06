namespace App.Loops.NilakanthaPi;

/// <summary>
/// Вычислить приближение числа PI по ряду Нилаканты.
/// </summary>
public static class Nilakantha
{
    public static double Approximate(int terms)
    {
        if (terms <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(terms));
        }

        double pi = 3.0;

        if (terms == 1)
        {
            return pi + 4.0 / (2 * 1 * 3 * 4);
        }

        for (int K = 1; K < terms; K++)
        {
            double ke = (2 * K) * (2 * K + 1) * (2 * K + 2);

            double s = (K % 2 == 1) ? 1.0 : -1.0;
            double term = 4.0 * s / ke;

            pi += term;
        }

        return pi;
    }
}
