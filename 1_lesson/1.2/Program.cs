Console.WriteLine("Введите число недели ");
int num1 = int.Parse(Console.ReadLine());

if (num1 == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num1 == 2)
{
    Console.WriteLine("Вторник");
}
else if (num1 == 3)
{
    Console.WriteLine("Среда");
}
else if (num1 == 4)
{
    Console.WriteLine("Четверг");
}
else if (num1 == 5)
{
    Console.WriteLine("Пятница");
}
else if (num1 == 6)
{
    Console.WriteLine("суббота");
}
else if (num1 == 2)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("error");
}