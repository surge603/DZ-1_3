// Задача 24: Найти кубы чисел от 1 до N

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

for (int i=1;i<=n;i++){
    Console.WriteLine($"N = {i}, N^3 = {Math.Pow(i,3)}");

}