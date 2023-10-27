// GRADE //

// Prompt the user for a grade between 0 and 100
int numericGrade;
do
{
    Console.Write("Enter a numeric grade between 0 and 100: ");
} while (!int.TryParse(Console.ReadLine(), out numericGrade) || numericGrade < 0 || numericGrade > 100);

// Prompt the user for a letter grade between 'A' and 'F' (excluding 'E')
char letterGrade;
do
{
    Console.Write("Enter a letter grade between 'A' and 'F' (excluding 'E'): ");
    char.TryParse(Console.ReadLine().ToUpper(), out letterGrade); // Convert to uppercase for case-insensitivity
} while (!(letterGrade >= 'A' && letterGrade <= 'F' && letterGrade != 'E'));

// Display the results
Console.WriteLine($"Numeric Grade: {numericGrade}");
Console.WriteLine($"Letter Grade: {letterGrade}");

// Wait for user input before closing the console window
Console.ReadLine();