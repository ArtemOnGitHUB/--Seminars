void Number(int num)

{
    if(num < 99)
    {
        Console.WriteLine("not exist");
        return;
    }
    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

int first = int.Parse(Console.ReadLine()); 
Number(first);
