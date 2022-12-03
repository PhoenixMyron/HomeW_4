// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ MATH.POW
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n2 = Convert.ToInt32(Console.ReadLine()), result = n1, z = 0;
for ( int count = 2; count <= n2; count++ )
{
result *= n1;
z = result;
}
Console.Write($"{z} ");

