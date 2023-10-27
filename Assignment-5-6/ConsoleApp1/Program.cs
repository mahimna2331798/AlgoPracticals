// Power

int baseNum, expNum;

do
{
    Console.WriteLine("Please enter a base and an exponent (>0)");
    baseNum = Convert.ToInt32(Console.ReadLine());
    expNum = Convert.ToInt32(Console.ReadLine());

} while (baseNum <= 0 || expNum <= 0);

int power = 1; // this is the equivalent of sum = 0 for multiplications

for (int i = 1; i <= expNum; i++) // repeat a multiplication exponent number of times
{
    power = power * baseNum;
}

//Iteration 1: power = power * base = 1 * 5, i++
//Iteration 2: power = power * base = 1*5 * 5, i++ 
//Iteration 3: power = power * base = 1*5*5 * 5 => 1*5*5*5 

// alternatively, without an extra variable
power = 1;
while (expNum > 0)
{
    power = power * baseNum; // 1*5, 1*5 *5, 1*5*5*5 ...
    expNum--;
}
