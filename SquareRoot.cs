public static class SquareRoot
{
    public static double Root(double number, int degree = 2)
    {
        ValidateInput(number, degree);

        if (number == 0)
        {
            return 0;
        }

        double result = Math.Pow(Math.Abs(number), 1.0 / degree);

        return number < 0 ? -result : result;
    }

    private static void ValidateInput(double number, int degree)
    {
        if (degree <= 0)
        {
            throw new ArgumentException(
                "Степінь кореня повинна бути більшою за 0.");
        }

        if (number < 0 && degree % 2 == 0)
        {
            throw new ArgumentException(
                "Не можна добувати парний корінь з від'ємного числа.");
        }
    }
}