// Вывод всех четных чисел
Console.WriteLine("Программа вывода четных чисел до указанного");
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int n = 0; 
    for (int i = 0; i < a/2; i++)
        {
            Console.Write($"{n = n+2} ");
        }
    Console.ReadKey();