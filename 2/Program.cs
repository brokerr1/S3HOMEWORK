/*Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Write("Введите координату первой точки по оси X: ");
double point1X = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Y: ");
double point1Y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Z: ");
double point1Z = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси X: ");
double point2X = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Y: ");
double point2Y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Z: ");
double point2Z = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(point2X - point1X, 2) + Math.Pow(point2Y - point1Y, 2) + Math.Pow(point2Z - point1Z, 2));
Console.WriteLine("Расстояние между двумя точками в пространстве равно {0:0.##}", distance);