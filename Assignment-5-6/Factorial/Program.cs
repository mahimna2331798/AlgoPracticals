// Factorial 


int num; 

do
{
    Console.WriteLine("Please enter a positive number to calculate its factorial");
    num = Convert.ToInt32(Console.ReadLine());
} while (num <= 0);

int factorial = 1; // 

for (int i=1; i <= num; i++)     // exactly like the sum but with multiplication instead.
{
    factorial = factorial * i;
}
/* 
Iteration 1: i=1, factorial = 1, 1<=5? T, factorial = factorial * i = 1 * 1 = 1, i++ = 2
Iteration 2: i=2, factorial = 1, 2<=5? T, factorial = factorial * i = 1 * 2 = 2, i++ = 3
Iteration 3: i=3, factorial = 2, 3<=5? T, factorial = factorial * i = 2 * 3 = 6, i++ = 4
Iteration 4: i=4, factorial = 6, 4<=5? T, factorial = factorial * i = 6 * 4 = 24, i++ = 5
Iteration 5: i=5, factorial = 24, 5<=5? T, factorial = factorial * i = 24 * 5 = 120, i++ = 6
Iteration 6: i=6, factorial = 120, 6<=5? F xxx 

1x1
(1x1)x2
((1x1)x2)x3
(((1x1)x2)x3)x4
((((1x1)x2)x3)x4)x5
 */

while (num > 0) // num = 7
{
    factorial = factorial * num;
    num--;
}
