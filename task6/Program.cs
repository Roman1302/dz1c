// Проверка четного числа
Console.WriteLine("Программа проверки четного числа");
Console.WriteLine("Введите число: ");
string? nS1 = Console.ReadLine();
int a = int.Parse(nS1);
if (a % 2==1)
            {
                Console.WriteLine("НЕТ");
           
            }
            else
            {
                Console.WriteLine("ДА");
            }