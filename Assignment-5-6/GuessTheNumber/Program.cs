byte secretNum = 7;
byte num;
byte maxGuess = 3;

do // repeat the play
{
    do // looping as long as the condition (num==secretnum) is not satisfied
    {
        do // validation
        {
            Console.WriteLine("Please enter the secret number (1-9)");
            num = Convert.ToByte(Console.ReadLine());

        } while (num < 1 || num > 9);

        maxGuess--; 

    } while (num!=secretNum && maxGuess>0);

    Console.WriteLine(num == secretNum? "Congratulations, you have guessed the secret number": "Sorry, you lost!");
    Console.WriteLine("Would you like to try again?(y/n)");
} while (Convert.ToChar(Console.ReadLine()) == 'y');
