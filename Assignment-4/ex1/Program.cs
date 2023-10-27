/*  [nested switch]  */

// Prompt the user for input
Console.Write("Enter the first number: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
float num2 = float.Parse(Console.ReadLine());

Console.Write("Choose an operation:\n1. Arithmetic (enter '1' or 'a')\n2. Relational (enter '2' or 'r'): ");
char operationType = Console.ReadLine().ToLower()[0]; // Convert to lowercase and take the first character

// Outer switch based on the user's choice
switch (operationType)
{
    case '1':
    case 'a':
        // Arithmetic operations
        Console.Write("Enter an arithmetic operator (+, -, *, /, %): ");
        char arithmeticOperator = Console.ReadLine()[0];

        switch (arithmeticOperator)
        {
            case '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;
            case '%':
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;
            default:
                Console.WriteLine("Invalid arithmetic operator.");
                break;
        }
        break;

    case '2':
    case 'r':
        // Relational operations
        Console.Write("Enter a relational operator (<, <=, >=, >, ==, !=): ");
        string relationalOperator = Console.ReadLine();

        switch (relationalOperator)
        {
            case "<":
                Console.WriteLine($"{num1} < {num2} is {num1 < num2}");
                break;
            case "<=":
                Console.WriteLine($"{num1} <= {num2} is {num1 <= num2}");
                break;
            case ">=":
                Console.WriteLine($"{num1} >= {num2} is {num1 >= num2}");
                break;
            case ">":
                Console.WriteLine($"{num1} > {num2} is {num1 > num2}");
                break;
            case "==":
                Console.WriteLine($"{num1} == {num2} is {num1 == num2}");
                break;
            case "!=":
                Console.WriteLine($"{num1} != {num2} is {num1 != num2}");
                break;
            default:
                Console.WriteLine("Invalid relational operator.");
                break;
        }
        break;

    default:
        Console.WriteLine("Invalid choice. Please enter '1' or '2'.");
        break;
}

// Wait for user input before closing the console window
Console.ReadLine();