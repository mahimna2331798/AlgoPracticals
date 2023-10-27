string userName;
int userChoice;
char watchAnother;

// Prompt the user for their name
Console.Write("Enter your name: ");
userName = Console.ReadLine();

do
{
    // Print the welcome message and menu
    Console.WriteLine("\n************* Welcome to Myflix! *************");
    Console.WriteLine($"What are you in the mood for, {userName}? ");
    Console.WriteLine("1 – Non-stop Awesome Action");
    Console.WriteLine("2 – Superhero & Sci-Fi");
    Console.WriteLine("3 – Romantic but Lit-wise Deep");
    Console.WriteLine("4 – Fun & Uplifting Adventures");
    Console.WriteLine("5 – Kids Time");
    Console.WriteLine("6 – Educational");
    Console.WriteLine("7 - Your Faves");

    // Prompt the user for their choice and validate it
    do
    {
        Console.Write("Enter your choice (1-7): ");
    } while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 7);

    // Use a switch statement to print options based on the user's choice
    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Non-stop Awesome Action: Watch 'Inception'!");
            break;
        case 2:
            Console.WriteLine("Superhero & Sci-Fi: Watch 'Avengers: Endgame'!");
            break;
        case 3:
            Console.WriteLine("Romantic but Lit-wise Deep: Watch 'Pride and Prejudice'!");
            break;
        case 4:
            Console.WriteLine("Fun & Uplifting Adventures: Watch 'The LEGO Movie'!");
            break;
        case 5:
            Console.WriteLine("Kids Time: Watch 'Finding Nemo'!");
            break;
        case 6:
            Console.WriteLine("Educational: Watch 'Planet Earth'!");
            break;
        case 7:
            Console.WriteLine("Your Faves: Watch 'The Shawshank Redemption'!");
            break;
        default:
            Console.WriteLine("Invalid choice. Please choose a number between 1 and 7.");
            break;
    }

    // Ask the user if they want to watch another movie
    do
    {
        Console.Write("Would you like to watch another movie? (y/n): ");
    } while (!char.TryParse(Console.ReadLine().ToLower(), out watchAnother) || (watchAnother != 'y' && watchAnother != 'n'));

} while (watchAnother == 'y');

// Thank the user for using Myflix
Console.WriteLine("\nThanks for using Myflix! Enjoy your movies.");

// Wait for user input before closing the console window
Console.ReadLine();
    