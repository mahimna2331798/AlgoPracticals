// 
Console.WriteLine("Ex.4");


for (int i =1500, iteration = 1; i<=2700; i= i+5, iteration++)
{
    //if (i % 5 == 0 && i % 7 == 0)
    if (i%7==0)
    {
        Console.WriteLine($"{iteration}: {i} ");
    }
    Console.WriteLine(iteration);
}
