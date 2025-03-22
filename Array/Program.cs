/*
 Напишіть програму, яка перевіряє, чи є введене число степенем
заданого числа.
*/

Console.Write("First ");
Console.WriteLine("row");
Console.WriteLine("Second row");

Console.WriteLine("Please enter a base number");
int baseNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter a power number");
int powerNumber = int.Parse(Console.ReadLine());

bool result = IsPowerOf(baseNumber, powerNumber);

if (result)
{
    Console.WriteLine("Yes. It is.");
}
else
{
    Console.WriteLine("No. It isn't.");
}

Console.WriteLine(result);
Console.WriteLine(result);
Console.WriteLine("No. It isn't. " + result);

Console.WriteLine("Base number was: {0}, power of number was {1}, the result = {2}.",
    baseNumber, powerNumber, result);

Console.WriteLine($"Base number was: {baseNumber}, power of number was {powerNumber}, the result = {result}.");


bool IsPowerOf(int baseNumber, int powerNumber)
{
    if (baseNumber < 1 || powerNumber < 1)
        return false;

    while (baseNumber % powerNumber == 0)
    {
        baseNumber /= powerNumber;
    }

    return baseNumber == 1;
}