// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Random random = new Random();
int size = 5;
int[] numbers = new int[size];
// Console.WriteLine(size);
for (int i = 0; i < size; i++)
{
    numbers[i] = random.Next(10, 100);
}

for (int i = 0; i < size; i++)
{
    Console.Write(numbers[i] + " ");
}
int sum = 0;
for (int i = 0; i < size; i++)
{

    if (i % 2 ==1) sum += numbers [i];
  
}
Console.WriteLine("сумма элементов, стоящих на нечётных позициях " + sum);
