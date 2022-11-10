// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Zadacha56()
{

    Random random = new Random();
    int rows = 3;
    int columns = 4;
    Console.WriteLine($"Массив размера {rows} x {columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    NumberRowMinSumElements(numbers);
    
    void NumberRowMinSumElements(int[,] numbers)
    {
        
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            minRow += numbers[0, i];
        }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
            for (int j = 0; j < numbers.GetLength(1); j++) sumRow += numbers[i, j];
            if (sumRow < minRow)
                {
                    minRow = sumRow;
                    minSumRow = i;
                }
            sumRow = 0;
            }
        Console.Write($"{minSumRow + 1} строка");
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
                    numbers[i, j] = random.Next(0, 10);
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
                    Console.Write(numbers[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
Zadacha56();
