// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// N = 5, получаем массив [1, 2, 5, 7, 19]
// N = 3, получаем массив [6, 1, 33]
int Array = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[Array];
for (int i = 0; i < randomArray.Length; i++)
{
 randomArray[i] = new Random().Next(1,33);
 Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}