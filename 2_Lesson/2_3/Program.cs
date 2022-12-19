string Crat(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "кратно";
    else
        return "некратно";
}

int first = int.Parse(Console.ReadLine());
Console.WriteLine(Crat(first));
