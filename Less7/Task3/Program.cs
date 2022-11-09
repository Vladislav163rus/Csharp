// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Zadacha52()
{

    Random random = new Random();
    int rows = random.Next(3, 4);
    int columns = random.Next(3, 4);
    Console.WriteLine($"Массив размера {rows} x {columns}");
    int[,] numbers = new int[rows, columns];
    double sum = 0;

    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum+= numbers[i, j];
        }
    }    
    Console.WriteLine($"{sum/ 12}");
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
Zadacha52();