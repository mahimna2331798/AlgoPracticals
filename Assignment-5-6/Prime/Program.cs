// 
Console.WriteLine("Is the number prime?");

int num = 7;
bool isPrime = true;

for (int i =2; i < num/2; i++)
{
    if (num%i == 0)
    {
        isPrime = false;
        Console.WriteLine($"{num} % {i} == 0");
        break;
    }
}

Console.WriteLine(isPrime ? $"{num} is prime!" : $"{num} is not prime");