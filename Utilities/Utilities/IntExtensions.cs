namespace Utilities;

public static class IntExtensions
{
    public static string ToOrdinal(this int number)
    {
        var n = number % 100;
        if (n >= 11 && n <= 13) return number + "th";
        return number + (number % 10 == 1 ? "st" : number % 10 == 2 ? "nd" : number % 10 == 3 ? "rd" : "th");
    }

    public static bool IsPrime(this int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}