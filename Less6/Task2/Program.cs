// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Задайте значение переменных в порядке b1, k1, b2, k2 : ");
int b1 = Convert.ToInt32(Console.ReadLine ());
int k1 = Convert.ToInt32(Console.ReadLine ());
int b2 = Convert.ToInt32(Console.ReadLine ());
int k2 = Convert.ToInt32(Console.ReadLine ());

double x=(double)(b2-b1)/(k1-k2);
double y=(double)(k1*x+b1);
Console.Write("прямые пересекаются в точках"+x +"и"+y);