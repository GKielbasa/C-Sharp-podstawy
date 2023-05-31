public delegate double MathOperation(double arg1, double arg2);

class Program
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        return b != 0 ? a / b : double.MaxValue;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the expected result: ");
        double expectedResult = double.Parse(Console.ReadLine());

        MathOperation[] operations = { Add, Subtract, Multiply, Divide };
        string[] operationNames = { "Add", "Subtract", "Multiply", "Divide" };

        double closestResult = double.MaxValue;
        string closestOperation = "";

        for (int i = 0; i < operations.Length; i++)
        {
            double result = operations[i](number1, number2);
            if (Math.Abs(result - expectedResult) < Math.Abs(closestResult - expectedResult))
            {
                closestResult = result;
                closestOperation = operationNames[i];
            }
        }

        Console.WriteLine($"The closest operation to the expected result was {closestOperation}, with a result of {closestResult}");
    }
}