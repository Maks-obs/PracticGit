using System.Text;

class Program
{
    static void Main()
    {

        Console.Write("Введіть c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть d: ");
        double d = Convert.ToDouble(Console.ReadLine());
        double result = -2 * c - d + 53;
        Console.WriteLine($"Результат: {result}");

        Console.ResetColor();
    }
}
