// Задача 20: Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.Write("Задайте номер четверти системы координат (1-4): ");
int n = int.Parse(Console.ReadLine());
if (n < 0 || n > 4)
{
    Console.WriteLine("Номер вне заданных параметров!");
    return;
}
    Console.WriteLine("Диапазоны координат:");
if (n==1)
{
    Console.WriteLine("x>0, y>0");
}
else if (n==2)
{
    Console.WriteLine("x<0, y>0");
}
else if (n==3)
{
    Console.WriteLine("x<0, y<0");
}
else 
{
    Console.WriteLine("x>0, y>0");
}