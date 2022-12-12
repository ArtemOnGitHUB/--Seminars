Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int startNumber = 1;


while(startNumber <= number)
    {
        if(startNumber % 2 ==0)
        Console.WriteLine(startNumber + ", ");
        startNumber ++;
    }