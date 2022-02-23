// Задача 22: Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
int n = 0;
while (n < 1 || n > 2)
{
    Console.Write("Выберите вариант системы кординат (1-2D, 2-3D): ");
    n = EnterNum();
    if (n < 1 || n > 2)
        Console.WriteLine("Введено неверное значение");
}
Console.Write("Введите x1: ");
int x1 = EnterNum();
Console.Write("Введите x2: ");
int x2 = EnterNum();
Console.Write("Введите y1: ");
int y1 = EnterNum();
Console.Write("Введите y2: ");
int y2 = EnterNum();
int z1 = 0, z2 = 0;
if (n == 2)
{
    Console.Write("Введите z1: ");
    z1 = EnterNum();
    Console.Write("Введите z2: ");
    z2 = EnterNum();
}
int EnterNum()
{
    return int.Parse(Console.ReadLine());
}
double l = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine($"Расстояние между точками = {l}");
