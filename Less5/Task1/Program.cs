// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Random random = new Random();
int size = 5;
int[] numbers = new int[size];
Console.WriteLine(size);

for (int i=0; i< size; i++)
{
    numbers[i] = random.Next(100, 1000);
}

for (int i = 0; i < size; i++)
{
    Console.Write(numbers[i] + " ");
}
int count = 0;
for (int i =0; i < size; i++)
{
    if (numbers[i] % 2 ==0) count++;
}

Console.WriteLine("колличество четных элементов " + count);