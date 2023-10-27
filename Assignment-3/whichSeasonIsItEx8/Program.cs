/*
 *** Prompt the user for a month m and a day d and let him/her know the season. ***
    WINTER December 21 – March 20 
    SPRING March 21 – June 20 
    SUMMER June 21 – October 20 
    AUTUMN October 21 – December 20 
 */


// Prompt the user for input
Console.Write("Enter month (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter day (1-31): ");
int day = Convert.ToInt32(Console.ReadLine());

// Determine the season
string season = DetermineSeason(month, day);

// Display the result
Console.WriteLine($"The date {month}/{day} is in the {season}.");

// Wait for user input before closing the console window
Console.ReadLine();
    }

    static string DetermineSeason(int month, int day)
{
    // Check the season based on the start dates
    if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day < 21))
    {
        return "Spring";
    }
    else if ((month == 6 && day >= 21) || (month > 6 && month < 9) || (month == 9 && day < 23))
    {
        return "Summer";
    }
    else if ((month == 9 && day >= 23) || (month > 9 && month < 12) || (month == 12 && day < 21))
    {
        return "Fall";
    }
    else
    {
        return "Winter";
    }
}