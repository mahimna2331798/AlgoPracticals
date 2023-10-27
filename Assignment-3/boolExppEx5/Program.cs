/*
 ** Boolean Expression 
    1. Write a program to determine if a character is a vowel: bool isVowel = ……………;
    2. Write a program to determine if a number is even or odd: bool isOdd = …………., isEven = …………….;
*/

//***********************************************program-1**********************************************************//

// Prompt the user for input
Console.Write("Enter a character: ");
char inputChar = Convert.ToChar(Console.ReadLine());

// Check if the character is a vowel
bool isVowel = IsVowel(inputChar);

// Display the result
if (isVowel)
{
    Console.WriteLine($"{inputChar} is a vowel.");
}
else
{
    Console.WriteLine($"{inputChar} is not a vowel.");
}

// Wait for user input before closing the console window
Console.ReadLine();

    static bool IsVowel(char ch)
{
    // Convert the character to lowercase for case-insensitive comparison
    char lowerChar = char.ToLower(ch);

    // Check if the character is a vowel
    return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
}

//***********************************************program-2**********************************************************//


// Prompt the user for input
Console.Write("Enter a number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

// Check if the number is even or odd
string result = IsEven(inputNumber) ? "even" : "odd";

// Display the result
Console.WriteLine($"{inputNumber} is {result}.");

// Wait for user input before closing the console window
Console.ReadLine();
    

    static bool IsEven(int number)
{
    // Check if the number is even
    return number % 2 == 0;
}