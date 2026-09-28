public class Factorial
{
    public static int Calculate(int number)
    {
        if (number < 0) throw new ArgumentException("Факторіал від'ємного числа не існує.");
        if (number == 0) return 1;
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

}