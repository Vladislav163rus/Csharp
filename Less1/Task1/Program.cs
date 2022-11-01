int numA;
int numB;
Console.WriteLine("Введите два числа для сравнения ");
numA = Convert.ToInt32(Console.ReadLine());
numB = Convert.ToInt32(Console.ReadLine());
while (numA > numB)
    Console.WriteLine("Первое число больше");
if (numA < numB)
    Console.WriteLine("Второе число больше");
else Console.WriteLine("Числа равны");

