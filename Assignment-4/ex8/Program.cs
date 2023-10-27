char playAgain;

do
{
    // Prompt the user for input
    Console.Write("Enter month (1-12): ");
    int month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter day (1-31): ");
    int day = Convert.ToInt32(Console.ReadLine());

    // Determine the weather conditions based on the provided chart
    string weatherCondition = DetermineWeatherCondition(month, day);

    // Display the result
    Console.WriteLine($"Weather condition for {month}/{day}: {weatherCondition}");

    // Ask the user whether to play again
    Console.Write("Would you like to enter another date? (y/n): ");
    playAgain = Console.ReadLine().ToLower()[0]; // Convert to lowercase and take the first character

} while (playAgain == 'y');

// Wait for user input before closing the console window
Console.ReadLine();
    

    static string DetermineWeatherCondition(int month, int day)
{
    // Weather conditions chart (example)
    // You can customize this based on a real weather chart
    if ((month == 12 && day >= 21) || (month >= 1 && month <= 2) || (month == 3 && day <= 20))
    {
        return "Winter";
    }
    else if ((month == 3 && day >= 21) || (month >= 4 && month <= 6) || (month == 6 && day <= 20))
    {
        return "Spring";
    }
    else if ((month == 6 && day >= 21) || (month >= 7 && month <= 9) || (month == 9 && day <= 23))
    {
        return "Summer";
    }
    else
    {
        return "Fall";
    }
}