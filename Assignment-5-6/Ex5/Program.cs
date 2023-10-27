// Ex. 5
Console.WriteLine("Ex.5");

byte m;
do
{
    Console.WriteLine("Please enter a positive number between 1 and 12: ");
    m = Convert.ToByte(Console.ReadLine());

    //} while (m<1 || m>12);

} while (m <= 0);

for (int i= 1; i<=10; i++)
{
    Console.WriteLine($"{i} x {m} = {i * m}");
}
