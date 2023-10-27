/*
 * Write a C# program to determine whether a character is an alphabet, a digit, or a special character *
 */

// Prompt the user for input
Console.Write("Enter a character: ");
char inputChar = Convert.ToChar(Console.ReadLine());

// Determine the character type
string charType = DetermineCharacterType(inputChar);

// Display the result
Console.WriteLine($"The character '{inputChar}' is a {charType}.");

// Wait for user input before closing the console window
Console.ReadLine();
    

    static string DetermineCharacterType(char ch)
{
    // Check if the character is an alphabet, a digit, or a special character
    if (char.IsLetter(ch))
    {
        return "alphabet";
    }
    else if (char.IsDigit(ch))
    {
        return "digit";
    }
    else
    {
        return "special character";
    }
}