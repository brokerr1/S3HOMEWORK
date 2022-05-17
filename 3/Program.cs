/*Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int step = 1;
Console.WriteLine("Таблица квадратов чисел: ");
Console.WriteLine("Число|Число в кубе");
while (step < (number+1))
{
    Console.WriteLine($"    {step}|{step*step*step}");
    step++;
}