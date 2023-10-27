////  
//Console.WriteLine("Exercise 7");


//int m, d, y;

//Console.WriteLine("Please enter a month (1-12): ");
//m = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter a day (1-31): ");
//d = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter a 4-digit year: ");
//y = Convert.ToInt32(Console.ReadLine());

//int y0 = y - (14 - m) / 12;
//int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
//int m0 = m + 12 * ((14 - m) / 12) - 2;
//int d0 = (d + x + (31 * m0) / 12) % 7;

//Console.WriteLine($"The day of the week is {d0}");

////if (d0 == 0)
////    Console.WriteLine("Sunday!");
////else if (d0 == 1)
////    Console.WriteLine("Monday!");
////else if (d0 == 2)
////    Console.WriteLine("Tuesday!");
////else if (d0 == 3)
////    Console.WriteLine("Wednesday!");
////else if (d0 == 4)
////    Console.WriteLine("Thursday!");
////else if (d0 == 5)
////    Console.WriteLine("Friday!");
////else if (d0 == 6)
////    Console.WriteLine("Saturday!");

//switch (d0)
//{
//    case 0: // is d0 == 0 ? 
//        Console.WriteLine("Sunday!");
//        break;
//    case 1:
//        Console.WriteLine("Mon");
//        break;
//    case 2:
//        Console.WriteLine("Tue.");
//        break;
//    case 3:
//        Console.WriteLine("Wed.");
//        break;
//    case 4:
//        Console.WriteLine("Thu.");
//        break;
//    case 5:
//        Console.WriteLine("Fri.");
//        break;
//    case 6:
//        Console.WriteLine("Sat.");
//        break;
//    default:
//        Console.WriteLine("Error");
//        break;
//}

//if (d0 == 0)
//{
//    Console.WriteLine("Sunday!");
//}
//else if (d0 == 1)
//{
//    Console.WriteLine("Mon");
//}
//else if (d0 == 2)
//{
//    Console.WriteLine("Tue");
//}
//else if (d0 == 3)
//{
//    Console.WriteLine("Wed");
//}
//else if (d0 == 4)
//{
//    Console.WriteLine("Thu");
//}
//else if (d0==5)
//{
//    Console.WriteLine("Fri");
//} 
//else if (d0 == 6)
//{
//    Console.WriteLine("Sat");
//}
//else
//{
//    Console.WriteLine("Error");
//}


//switch (d0)
//{   // if (d0==1 || d0==2 || d0==3 ||d0==4 ||d0==5) // this is a no-no : aChar == 'a' || 'e' || 'i' ... xx
//    // if (d0>=1 && d0<=5)
//    case 1 or 2 or 3 or 4 or 5: 
//    //case 1: // is d0 == 1? or 
//    //case 2: // is d0 == 2? or 
//    //case 3: // is d0 == 3? or 
//    //case 4: // is d0 == 4? or 
//    //case 5: // is d0 == 5? 
//        Console.WriteLine("Weekday");
//        break;

//    case 0: // is d0 == 0 ? or 
//    case 6: // is d0 == 6? 
//        Console.WriteLine("Weekend");
//        break;
//}

//if (d0 == 1 || d0 == 2 || d0 == 3 || d0 == 4 || d0 == 5)
//{
//    Console.WriteLine("weekday!");
//} 
//else if(d0==5)
//{
//    Console.WriteLine("Can I duplicate in an if-stmt?");
//} 
//else
//{
//    Console.WriteLine("Weekend");
//}

//int finalAPAverage = 60;
//switch (finalAPAverage)
//{
//    case < 60:
//        Console.WriteLine("Fail!");
//        break;
//    case >= 60 and <70:
//        Console.WriteLine("D");
//        break;
//    case >= 70 and < 80:
//        Console.WriteLine("C");
//        break;
//}

//if (finalAPAverage >=90 && finalAPAverage <=100)
//{
//    Console.WriteLine("A+");
//}
//else if (finalAPAverage>=80 && finalAPAverage <=89)
//{
//    Console.WriteLine("B+");
//}

//int num = 5; 
//switch (num%2) // evaluates to a number 
//{
//    case 0: 
//        Console.WriteLine("isEven");
//        break;
//    case 1:
//        Console.WriteLine("isOdd");
//        break;
//    //default: // unreachable
//    //    Console.WriteLine("In default");
//    //    break;
//}

//switch (num%2 == 0) // evaluate to true or false
//{
//    case true:
//        Console.WriteLine("even!");
//        break;
//}

//char aChar = 'a'; 
//switch (aChar)
//{
//    case 'a' or 'e' or 'i' or 'o' or 'u':
//        Console.WriteLine("it's a vowel");
//        break;
//    default:
//        Console.WriteLine("It's not a vowel!");
//        break;
//}

//if (aChar>=48 && aChar <= 57)
//{
//    Console.WriteLine("isDigit");
//}

//switch (aChar)
//{
//    //case >= 48 and <= 57:
//    case >= '0' and <= '9': 
//        Console.WriteLine("isDigit");
//        break;
//    //case >= 65 and <= 90 or >= 97 and <= 122:
//    case >= 'a' and <= 'z' or 'A' and <= 'Z':
//        Console.WriteLine("isAlphabet");
//        break;
//    default:
//        Console.WriteLine("isSymbol");
//        break;
//}



//bool isInRange = month >= 1 && month <= 12;
//! (month >=1 && month <= 12) => month < 1 || month > 12; 

//byte month, day;
//do
//{
//    Console.Write("Please enter a month (1-12): ");
//    month = Convert.ToByte(Console.ReadLine());
//} while (month < 1 || month > 12);
////} while (/*input is out of range?*/); 
////} while (!isInRange);

//do
//{
//    Console.Write("Please enter a day (1-31): ");
//    day = Convert.ToByte(Console.ReadLine());
//} while (day < 1 || day > 31);


//if (month == 3 && day >= 20 || month == 4 || month == 5 || month == 6 && day <= 20)
//    Console.WriteLine("Spring");

//char ans;
//do // repeat the play
//{
//    Console.WriteLine("*************Welcome to Myflix! *************");
//    Console.WriteLine("1 – Non-stop Awesome Action");
//    Console.WriteLine("2 – Superhero & Sci-Fi");
//    Console.WriteLine("3 – Romantic ");

//    byte userChoice;

//    do // input validation
//    {
//        Console.WriteLine("What are you in the mood for? (1-3)");
//        userChoice = Convert.ToByte(Console.ReadLine());
//        //} while (userChoice != 1 && userChoice != 2 && userChoice != 3); 
//    } while (userChoice < 1 || userChoice > 3);

//    switch (userChoice)
//    {
//        case 1:
//            Console.WriteLine("Here are the non-stop awesome action movies...");
//            break;
//        case 2:
//            Console.WriteLine("Here are the superhero and sci-fi movies...");
//            break;
//        case 3:
//            Console.WriteLine("Here are the romantic moveis ...");
//            break;
//        default:
//            Console.WriteLine("User choice not recognized.");
//            break;
//    }

//    do // input validation: making sure that the answer entered is either y or n
//    {   // and if it's not, prompt him again
//        Console.WriteLine("Would you like to watch another movie?(y/n)");
//        ans = Convert.ToChar(Console.ReadLine());
//    } while (ans !='y' && ans !='n'); 

//    //} while (ans.Equals('y'));
//} while (ans == 'y');


byte num;
bool validInput;

do
{
    Console.WriteLine("Enter a number between 1 and 7: "); // prompt with a constraint
    num = Convert.ToByte(Console.ReadLine()); // read it in, assuming it's the right type 

    validInput = num >= 1 && num <= 7; // check if it's valid

} while (validInput == false);  // set the cdt accordingly
//} while (!(num >= 1 && num <= 7)) ; // !validInput --> invalidInput
//} while (num < 1 || num > 7) ; // when you're comfortable, skip the boolean and capture the cdt


char ans;

do
{
    // Let's play a game! 
    // Game code goes here... 
    // Gameplay done with "Congratulations, you won!" or "Sorry, you lost!"

    // prompt to see if user would like to go again

    Console.WriteLine("Would you like to play again? (y/n)");
    ans = Convert.ToChar(Console.ReadLine());

} while (ans == 'y');
//} while (ans.Equals('y'));


do
{
    Console.WriteLine(@"This is the body of the do-while loop.
            Control of the program arrives to the do-while loop and walks into the body.
            It begins executing the instructions in the body. 
            When it's done, it moves to the while and evaluates the condition.
            If true, control of the program goes back to the beginning of the do; 
            If false, control of the program continues on past the do-while.
            Each full pass through the loop (top to bottom) is called an iteration.");

} while (true); // if the cdt is always true, the loop becomes infinite
// } while (false) ; // if the cdt is always false, the loop will always execute only once
