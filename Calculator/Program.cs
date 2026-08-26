Console.WriteLine("Calculator");

Console.WriteLine("write first number: ");
double num1;
while (!double.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("write second number: ");
double num2;
while (!double.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("write operation: ");
string op;
while (string.IsNullOrEmpty(op = Console.ReadLine()))
{
    Console.WriteLine("Invalid input. Please enter a valid operation.");
}

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