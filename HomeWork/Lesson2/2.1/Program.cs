string SecondNumber(int num)

{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
         return $"{((num / 10) % 10)}";
    return "number not exist";
}

int first = int.Parse(Console.ReadLine());
Console.WriteLine(SecondNumber(first));
