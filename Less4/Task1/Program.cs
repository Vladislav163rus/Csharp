// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
//  и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без использования math.pow

Console.WriteLine("Введите 2 числа ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= numB; i++)
{
    result *= numA;
}
Console.WriteLine($"число {numA} в степени {numB} равно {result}");