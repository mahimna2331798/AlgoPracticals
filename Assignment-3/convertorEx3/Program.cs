// This program prompts the user to input days and then converts it to weeks, months and years //

// Prompt the user for the number of days
Console.Write("Enter the number of days: ");
int totalDays = Convert.ToInt32(Console.ReadLine());

// Calculate years, weeks, and days
int years = totalDays / 365;
int remainingDays = totalDays % 365;
int weeks = remainingDays / 7;
int days = remainingDays % 7;

// Print the results
Console.WriteLine($"Years: {years}");
Console.WriteLine($"Weeks: {weeks}");
Console.WriteLine($"Days: {days}");

// Wait for user input before closing the console window
Console.ReadLine();