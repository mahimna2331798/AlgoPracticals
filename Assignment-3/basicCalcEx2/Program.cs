// This program takes in two numbers from user and prints all the arithmetic operations as the output //

// Prompt the user for the first number
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

// Prompt the user for the second number
Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

// Perform arithmetic operations
double sum = num1 + num2;
double difference = num1 - num2;
double product = num1 * num2;
double quotient = num1 / num2;
double remainder = num1 % num2;

// Print the results
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder (modulo): {remainder}");

// Wait for user input before closing the console window
Console.ReadLine();