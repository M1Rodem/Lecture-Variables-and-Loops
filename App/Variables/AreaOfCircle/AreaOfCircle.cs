namespace App.Variables.AreaOfCircle;

/// <summary>
/// Вычислить площадь круга по радиусу.
/// </summary>
public static class AreaOfCircle
{
    public static double Calculate(double radius)
    {
        // Подсказка: используйте Math.PI и возведение в квадрат radius * radius.
        // Об ошибочных значениях: отрицательный радиус считается некорректным входом.

        if (radius < 0)
        { 
            throw new ArgumentOutOfRangeException("отрицательный радиус", nameof(radius));
        }

        return Math.PI * radius * radius;

    }

}
