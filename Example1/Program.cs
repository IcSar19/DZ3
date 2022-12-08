Console.Clear();

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());

if ((num < 100000) && (num >= 10000))
{
    int a = num % 10;
    int b = num / 10000;
    int c = (num % 100) / 10;
    int d = (num / 1000) % 10;

    if (a == b && c == d)
    {
        Console.WriteLine($"Число палиндром {num}");
    }
    else
    {
        Console.WriteLine($"Число не палиндром {num}");
    }

    return;
}

Console.WriteLine("Введено не пятизначное число");