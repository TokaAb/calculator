Console.WriteLine("Calculator");

Console.WriteLine("write first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("write second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("write operation: ");
string op = Console.ReadLine();

double result = 0;

switch(op)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: Division by zero");
            return;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation");
        return; 
}

Console.WriteLine($"Result: {result}");