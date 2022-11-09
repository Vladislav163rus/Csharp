// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void Zadacha50()
{

    Random random = new Random();
    int rows = random.Next(3, 4);
    int columns = random.Next(3, 4);
    Console.WriteLine($"Массив размера {rows} x {columns}");
    int[,] numbers = new int[rows, columns];
    int numA;
    bool flag = false;
    Console.WriteLine("Введите число для проверки");
    numA = Convert.ToInt32(Console.ReadLine());

    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] == numA)
            {
                flag = true;
                break;
            }
            
        }
    }
    if (flag)
    {
    Console.WriteLine($"Число {numA} есть в массиве");
    }
    else
    {
    Console.WriteLine($"Числа {numA} нет в массиве");
    }
    
    void FillArray(int[,] numbers)
    {
        {
            Random random = new Random();
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(0, 11);
                }
            }
        }
    }

    void PrintArray(int[,] numbers)
    {
        {
            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
Zadacha50();
