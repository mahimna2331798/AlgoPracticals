// Prompt the user for input
Console.Write("Enter month (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter day (1-31): ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 4-digit year: ");
int year = Convert.ToInt32(Console.ReadLine());

// Calculate the day of the week
string dayOfWeek = CalculateDayOfWeek(month, day, year);

// Display the result
Console.WriteLine($"The date {month}/{day}/{year} falls on a {dayOfWeek}.");

// Wait for user input before closing the console window
Console.ReadLine();
    

    static string CalculateDayOfWeek(int month, int day, int year)
{
    // Zeller's Congruence formula - search the web for it.
    if (month < 3)
    {
        month += 12;
        year--;
    }

    int k = year % 100;
    int j = year / 100;

    int dayOfWeek = (day + (13 * (month + 1)) / 5 + k + (k / 4) + (j / 4) - 2 * j) % 7;

    // Map the result to a day of the week
    switch (dayOfWeek)
    {
        case 0: return "Saturday";
        case 1: return "Sunday";
        case 2: return "Monday";
        case 3: return "Tuesday";
        case 4: return "Wednesday";
        case 5: return "Thursday";
        case 6: return "Friday";
        default: return "Invalid day";
    }
}
