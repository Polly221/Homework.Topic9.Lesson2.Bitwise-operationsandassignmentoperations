//1.программа для инверсии
Console.Write("Введите число для инверсии: ");
long n = long.Parse(Console.ReadLine());
Console.WriteLine("Результат: "+~n);
//2.программа для сдвига числа влево
Console.Write("Введите число для сдвига влево : ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Результат: "+(a<<1));
//2.программа для сдвига числа вправо
Console.Write("Введите число для сдвига вправо : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Результат: " + (b >> 1));
//3.программа для присваивания
Console.Write("Введите число для присваивания : ");
int c = int.Parse(Console.ReadLine());
int result = c= 2487;
Console.WriteLine("Результат: "+result);
