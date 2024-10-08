// used for reference
// Console.WriteLine("");
// int name = int.parse("string input")
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("WELCOME TO WORST CALC EVER!!!!!!!");

        Console.WriteLine("Input first number: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Input second number: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Please select operator | +, -, *, /, %(mod/remainder div) |");
        string op = (Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine("Your answer is = " + (num1 + num2));
        }

        else if (op == "-")
        {
            Console.WriteLine("Your answer is = " + (num1 - num2));
        }

        else if (op == "*")
        {
            Console.WriteLine("Your answer is = " + (num1 * num2));
        }

        else if (op == "/")
        {
            Console.WriteLine("Your answer is = " + (num1 / num2));
        }

                else if (op == "%")
        {
            Console.WriteLine("Your answer is = " + (num1 % num2));
        }

        else{
            Console.WriteLine("Please select a valid operator");
        }
    }
}