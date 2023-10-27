// miche_kh@lasallecollege

Console.WriteLine("Ex. 1");

float currentTemperature1 = 11.5f;
float currentTemperature2 = (float)11.5; // casting
float currentTemperature3 = Convert.ToSingle(11.5); // Convert.To syntax
Console.WriteLine("currentTemperature = " + currentTemperature1);

char aletterGrade1 = 'A';   // single quotes go with characters
string aletterGrade2 = "A+"; // double quotes enclose strings
Console.WriteLine("aletterGrade1 =" + aletterGrade1);
Console.WriteLine("aletterGrade2 =" + aletterGrade2);

float finalAPAverageF = 85.9f;
int finalAPAverage1 = Convert.ToInt32(Math.Round(85.9));
int finalAPAverage2 = (int)finalAPAverageF;

byte numOfStudents = 23;
Console.WriteLine("numOfStudents = " + numOfStudents);

string favColour = "blue";
Console.WriteLine("favColour = " + favColour);
Console.WriteLine($"My favorite colour is {favColour}");

Console.WriteLine("The student's favorite colour is " + favColour +
    "and his final AP average is " + finalAPAverage1 +
    "and the temperature on the day of the final was " + currentTemperature1);

Console.WriteLine($"....{favColour} ....{finalAPAverage1}...{currentTemperature1}.... ");

bool ans = false;

Console.WriteLine("\n\nEx. 2");

// https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint32?view=net-7.0//

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

// going from int to float is implicit 

int anInt = 5;

float aFloat1 = (float)anInt; // this is explicit casting
float aFloat2 = Convert.ToInt32(anInt); // and this is conversion
Console.WriteLine("aFloat1 = " + aFloat1);
Console.WriteLine("aFloat2 = " + aFloat2);

float aFloat3 = anInt; // but they're both redundant, going from int to float is implicit
Console.WriteLine("aFloat3 = " + aFloat3);


// going from float to int requires explicit casting or conversion
float aFloat = 5.505f;

int anInt1 = (int)aFloat; // casting strips off the point & the digits that follow it
Console.WriteLine("anInt1 = " + anInt1);

int anInt2 = Convert.ToInt32(aFloat); // conversion rounds to the nearest whole number then strips
Console.WriteLine("aInt2 = " + anInt2);

// going from float to double is implicit

// going from char to int is implicit, all characters have a decimal representation

char aChar = '@';
char aChar1 = '\u0040';
char aChar2 = '\x40';

Console.WriteLine("aChar = +" + aChar);
Console.WriteLine("\\x40 = \x40 = " + aChar1);
Console.WriteLine("\\u0040 = \u0040 = " + aChar2);

int anInt3 = aChar; // implicit conversion



Console.WriteLine("\n\nEx. 5");

// AddNumbers();
// RaiseToPower();
// GetDayOfTheWeek();
// PrintNewLine();
// IsPrime();
// ConvertToLetterGrade();
// CalculateBMI(); 

