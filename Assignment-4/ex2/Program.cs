// [do-while & if-else] //

// Prompt the user for temperature within the specified range
float temperature;
do
{
    Console.Write("Enter temperature between -50 and +5 °C: ");
} while (!float.TryParse(Console.ReadLine(), out temperature) || temperature < -50 || temperature > 5);

// Prompt the user for wind speed within the specified range
int windSpeed;
do
{
    Console.Write("Enter wind speed between 5 and 80 km/h: ");
} while (!int.TryParse(Console.ReadLine(), out windSpeed) || windSpeed < 5 || windSpeed > 80);

// Determine the weather conditions based on the provided chart
string weatherCondition = DetermineWeatherCondition(temperature, windSpeed);

// Display the result
Console.WriteLine($"Weather condition: {weatherCondition}");

// Wait for user input before closing the console window
Console.ReadLine();
    

    static string DetermineWeatherCondition(float temperature, int windSpeed)
{
    // Weather conditions chart (example)
    // You can customize this based on a real weather chart
    if (temperature < -30 || windSpeed > 60)
    {
        return "Dangerous for children to play outside";
    }
    else if ((temperature >= -30 && temperature < -10) || (windSpeed >= 40 && windSpeed <= 60))
    {
        return "Risky for children to play outside";
    }
    else
    {
        return "Comfortable for children to play outside";
    }
}