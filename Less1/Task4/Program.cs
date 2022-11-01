Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + "четное число:");

    }
    i = i + 1;
}

if (i % 2 == 1)
{
    Console.WriteLine("-Результат");
}