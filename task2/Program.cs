// Программа по определению большего числа из двух
Console.WriteLine("Определение большего числа из двух");
Console.WriteLine("Введите первое число: ");
string? nS1 = Console.ReadLine();
int a = int.Parse(nS1);

Console.WriteLine("Введите второе число: ");
string? nS2 = Console.ReadLine();
int b = int.Parse(nS2);

if (a > b)
{
    Console.WriteLine("Наиболешее число: {0}", a);
}
else
{
    Console.WriteLine("Наиболешее число: {0}", b);
}