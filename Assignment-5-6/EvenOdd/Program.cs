// 

Console.WriteLine("Even Odd");

int countEven = 0, countOdd = 0;
int sumOfEven = 0, sumOfOdd = 0;

do
{
    Console.Write("Please enter a number:");
    int num = Convert.ToInt32(Console.ReadLine());

    switch(num%2)
    {
        case 0: 
            countEven++; // countofeven = countofeven + 1
            sumOfEven += num;
            break;
        
        case 1:            
            countOdd++;
            sumOfOdd += num;
            break;
    }

    //Console.WriteLine(num%2==0? $"{countEven++}{sumOfEven += num}": $"{ countOdd++}{sumOfOdd += num}"); 

    Console.WriteLine("Do you want to enter another number?(y/n)");

} while (Convert.ToChar(Console.ReadLine())=='y');


while (true)
{
    // 
    Console.WriteLine("Do you want to enter another number?(y/n)");
    if (Convert.ToChar(Console.ReadLine()) == 'n')
        break;
}
