/* 
                                                           **** Leap Year Or Not? ****
 * Prompt the user for a 4-digit year and let him/her know if it’s a leap year. A leap year is a year divisible by 4, but not by 100. A leap year is a year that is divisible by 400.  
*/

// Prompt the user for input
Console.Write("Enter a 4-digit year: ");
int year = Convert.ToInt32(Console.ReadLine());

// Check if it's a leap year
bool isLeapYear = IsLeapYear(year);

// Display the result
if (isLeapYear)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}

// Wait for user input before closing the console window
Console.ReadLine();

    static bool IsLeapYear(int year)
{
    // Check the leap year conditions
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}