// PIN //

// Declare a constant PIN
const int my_pin = 1234; // Replace with your desired PIN

int userEnteredPin;
bool isValidPin;

do
{
    // Prompt the user for the PIN
    Console.Write("Enter your PIN: ");

    // Try to parse the entered value as an integer
    isValidPin = int.TryParse(Console.ReadLine(), out userEnteredPin);

    // Check if the entered PIN is incorrect
    if (!isValidPin || userEnteredPin != my_pin)
    {
        Console.WriteLine("Incorrect PIN. Please try again.");
    }

} while (!isValidPin || userEnteredPin != my_pin);

// Display a message if the correct PIN is entered
Console.WriteLine("PIN accepted. Access granted.");

// Wait for user input before closing the console window
Console.ReadLine();