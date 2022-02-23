// Задача 18: Проверить истинность утверждения
// ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] x = { true, true, false, false };
bool[] y = { true, false, true, false };

Console.Clear();
Console.WriteLine("Проверяем истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y:");
bool result = true;
for (int i = 0; i < 4; i++)
{
    Console.Write($"X:{x[i]}; Y:{y[i]} - ");
    if (!(x[i] || y[i]) == (!x[i] && !y[i]))
        Console.WriteLine("верно.");
    else
    {
        Console.WriteLine("НЕВЕРНО!");
        result = false;
    }
}
if (result)
    Console.WriteLine("Утверждение верно.");
else
    Console.WriteLine("УТВЕРЖДЕНИЕ НЕВЕРНО!");
