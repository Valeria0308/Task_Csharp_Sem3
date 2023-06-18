// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] aCoordinate = new int[3];
System.Console.WriteLine("Введите X первой точки: ");
aCoordinate[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Y первой точки: ");
aCoordinate[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Z первой точки: ");
aCoordinate[2] = Convert.ToInt32(Console.ReadLine());
int[] bCoordinate = new int[3];
System.Console.WriteLine("Введите X второй точки: ");
bCoordinate[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Y второй точки: ");
bCoordinate[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Z второй точки: ");
bCoordinate[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bCoordinate[0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]), 2) + Math.Pow((bCoordinate[2] - aCoordinate[2]), 2)), 2));
