string DeleteNumber(int num)

{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{((num / 100) * 10 + num % 10)}";
    return "not exist";

}

int first = int.Parse(Console.ReadLine()); 
Console.WriteLine(DeleteNumber(first));

//Console.WriteLine(DeleteNumber(new Random().Next(100, 999)));