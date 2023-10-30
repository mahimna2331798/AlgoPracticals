using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("********** Welcome to B.Hive! **********");

        // Get customer name
        Console.Write("Please enter your name: ");
        string customerName = Console.ReadLine();

        // Initialize variables for order summary
        int turkishCoffeeCount = 0;
        int spanishLatteCount = 0;
        int doubleEspressoCount = 0;
        double totalCost = 0;

        do
        {
            // Display menu
            Console.WriteLine($"What can I get you, {customerName}? ");
            Console.WriteLine("a. Turkish Coffee (3.35$)");
            Console.WriteLine("b. Double Espresso (3.25$)");
            Console.WriteLine("c. Spanish Latte (4.80$)");

            // Get user choice
            ConsoleKeyInfo choice = Console.ReadKey();
            Console.WriteLine();

            switch (choice.KeyChar)
            {
                case 'a':
                    // Turkish Coffee
                    Console.Write("How many Turkish Coffees would you like?(1-5) ");
                    int turkishCoffeeQuantity = GetQuantity();
                    turkishCoffeeCount += turkishCoffeeQuantity;
                    totalCost += turkishCoffeeQuantity * 3.35;
                    break;

                case 'b':
                    // Double Espresso
                    Console.Write("Adding a Double Espresso to your order. Would you like some Whipped Cream with it? (y/n) ");
                    bool addWhippedCream = GetYesNoAnswer();

                    if (addWhippedCream)
                    {
                        totalCost += 0.75;
                    }

                    Console.Write("Would you like to proceed with the extra charge? (y/n) ");
                    bool proceedWithCharge = GetYesNoAnswer();

                    if (proceedWithCharge)
                    {
                        totalCost += 3.25;
                    }

                    doubleEspressoCount++;
                    break;

                case 'c':
                    // Spanish Latte
                    Console.Write("Adding a Spanish Latte to your order. Would you like to add another Spanish Latte? (y/n) ");
                    bool addAnotherLatte = GetYesNoAnswer();

                    do
                    {
                        spanishLatteCount++;
                        totalCost += 4.80;

                        Console.Write("Would you like to add another Spanish Latte? (y/n) ");
                        addAnotherLatte = GetYesNoAnswer();
                    } while (addAnotherLatte);

                    break;

                default:
                    Console.WriteLine("Sorry, I don’t recognize this answer.");
                    break;
            }

            // Ask if the user wants to add another beverage
            Console.Write("Would you like to add another beverage to your order? (y/n) ");
        } while (GetYesNoAnswer());

        // Display order summary
        Console.WriteLine($"Your order summary: ");
        Console.WriteLine($"{turkishCoffeeCount} Turkish Coffees @ {turkishCoffeeCount * 3.35}$");
        Console.WriteLine($"{spanishLatteCount} Spanish Latte @ {spanishLatteCount * 4.80}$");
        Console.WriteLine($"{doubleEspressoCount} Double Espresso with Whipped Cream @ {doubleEspressoCount * 4.00}$");
        Console.WriteLine($"Total = {totalCost}$");

        // Get credit card information
        Console.Write("Please enter your 16-digits credit card number: ");
        string creditCardNumber = Console.ReadLine();

        Console.WriteLine("Please enter the month (MM) and year (YY) of expiration – on separate lines:");
        int expirationMonth = GetValidMonth();
        int expirationYear = GetValidYear();

        // Check if the expiration date is valid
        while (!IsValidExpirationDate(expirationMonth, expirationYear))
        {
            Console.WriteLine("Sorry, this is invalid. Valid expiration range between November 2023 and November 2028");
            Console.WriteLine("Please enter the month (MM) and year (YY) of expiration – on separate lines:");
            expirationMonth = GetValidMonth();
            expirationYear = GetValidYear();
        }

        Console.Write("Please enter your 3-digits CCV: ");
        string ccv = Console.ReadLine();

        // Display final message
        Console.WriteLine($"Thank you for visiting B.Hive, {customerName}! We will call your name when your order is ready. Have a great day!");
    }

    // Helper method to get a valid integer input for quantity
    static int GetQuantity()
    {
        int quantity;
        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1 || quantity > 5)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        }
        return quantity;
    }

    // Helper method to get a valid yes/no answer
    static bool GetYesNoAnswer()
    {
        char answer;
        while (!char.TryParse(Console.ReadLine().ToLower(), out answer) || (answer != 'y' && answer != 'n'))
        {
            Console.WriteLine("Invalid input. Please enter 'y' for Yes or 'n' for No.");
        }
        return answer == 'y';
    }

    // Helper method to get a valid month input
    static int GetValidMonth()
    {
        int month;
        while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month. Please enter a number between 1 and 12.");
        }
        return month;
    }

    // Helper method to get a valid year input
    static int GetValidYear()
    {
        int year;
        while (!int.TryParse(Console.ReadLine(), out year) || year < 23 || year > 28)
        {
            Console.WriteLine("Invalid year. Please enter a number between 23 and 28.");
        }
        return year;
    }

    // Helper method to check if the expiration date is valid
    static bool IsValidExpirationDate(int month, int year)
    {
        DateTime currentDate = DateTime.Now;
        DateTime expirationDate = new DateTime(year + 2000, month, 1).AddMonths(1).AddDays(-1);

        return expirationDate >= currentDate;
    }
}
