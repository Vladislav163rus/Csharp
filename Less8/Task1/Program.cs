// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Zadacha54()
{

    Random random = new Random();
    int rows = 3;
    int columns = 4;
    Console.WriteLine($"Массив размера {rows} x {columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    SortToLower(numbers);
    Console.WriteLine();
    PrintArray(numbers);

void SortToLower(int[,] numbers)
{ 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                int temp = numbers[i, k + 1];
                numbers[i, k + 1] = numbers[i, k];
                numbers[i, k] = temp;
                }
                
            }
        }
    }
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
                    numbers[i, j] = random.Next(0, 9);
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
Zadacha54();
