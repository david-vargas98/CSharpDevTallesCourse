partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0)
            return "Positive";
        else if (number < 0)
            return "Negative";
        else
            return "Cero";
    }

    static void Functions()
    {
        WriteLine("\tFunctions");
        double area = CalculateArea(5.4, 3.4);
        WriteLine($"The area is: {area}");

        string evaluatedNumber = EvaluateNumber(-34);
        WriteLine($"The evaluated number is: {evaluatedNumber}");
    }
}