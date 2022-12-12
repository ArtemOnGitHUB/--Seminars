
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " );
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " );
        Console.WriteLine(thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " );
    Console.WriteLine(secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " );
    Console.WriteLine(thirdNumber);
}