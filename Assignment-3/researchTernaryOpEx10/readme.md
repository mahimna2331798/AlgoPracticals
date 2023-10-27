The ternary operator, also known as the conditional operator, is a concise way to write a simple `if-else` statement in a single line. Its syntax is:

```csharp
condition ? expression_if_true : expression_if_false;
```

Here's how it works: If the condition is true, the operator evaluates to `expression_if_true`; otherwise, it evaluates to `expression_if_false`.

Now, let's go through different examples:

### Example 1: Basic Usage

```csharp
int number = 10;
string result = (number % 2 == 0) ? "Even" : "Odd";
Console.WriteLine(result);
```

This example checks if `number` is even or odd and assigns the result to the `result` variable using the ternary operator.

### Example 2: Assigning Maximum of Two Numbers

```csharp
int a = 7, b = 12;
int max = (a > b) ? a : b;
Console.WriteLine($"The maximum is: {max}");
```

This example uses the ternary operator to find and print the maximum of two numbers, `a` and `b`.

### Example 3: Checking if a Number is Positive, Negative, or Zero

```csharp
int x = -5;
string sign = (x > 0) ? "Positive" : (x < 0) ? "Negative" : "Zero";
Console.WriteLine($"The number is {sign}");
```

This example checks whether a number `x` is positive, negative, or zero using nested ternary operators.

### Example 4: Determining Leap Year

```csharp
int year = 2024;
string leapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ? "Leap" : "Not Leap";
Console.WriteLine($"{year} is a {leapYear} year");
```

This example uses the ternary operator to determine whether a given year is a leap year.

### Example 5: Displaying a Message Based on a Boolean

```csharp
bool isStudent = true;
string message = isStudent ? "You are a student" : "You are not a student";
Console.WriteLine(message);
```

This example checks the value of a boolean variable and prints a message accordingly using the ternary operator.

Feel free to run these examples in a C# environment to see the results!