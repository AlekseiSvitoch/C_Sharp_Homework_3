Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write($"таблица кубов числа {num}: ");
while (i <= num)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;
}