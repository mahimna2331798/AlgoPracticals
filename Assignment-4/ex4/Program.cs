// INPUT VALIDATION //

int month, day;

do
{
    // Prompt the user for a month and a day
    Console.Write("Enter a month (1-12) and a day (1-31) separated by space: ");
    string[] input = Console.ReadLine().Split();

    // Validate input format
    if (input.Length != 2 || !int.TryParse(input[0], out month) || !int.TryParse(input[1], out day))
    {
        Console.WriteLine("Invalid input format. Please enter both month and day separated by a space.");
        continue;
    }

    // Validate month and day ranges
    if (month < 1 || month > 12 || day < 1 || day > 31)
    {
        Console.WriteLine("Invalid month or day. Please enter valid values.");
        continue;
    }

    // Break the loop if the input is valid
    break;

} while (true);

// Display the validated input
Console.WriteLine($"Validated input: Month = {month}, Day = {day}");

// Wait for user input before closing the console window
Console.ReadLine();