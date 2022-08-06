// Три числа в строке
Console.WriteLine("Определение максимального числа из введенных");
Console.WriteLine("Введите три числа через запятую:");
string[] num = Console.ReadLine().Split(',');
               int x = int.Parse(num[0]);
               int y = int.Parse(num[1]);
               int z = int.Parse(num[2]);
               int max = 0;
 if (x >= y && x >= z)
 {
    max = x;
 }
            else if (y >= x && y >=z )
            {
                max = y;
            }
            else if (z >= x && z >= y)
            {
                max = z;
            }
Console.WriteLine("Наиболешее число: {0}", max);