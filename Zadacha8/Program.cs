Console.WriteLine("Введите число N, а программа покажет все четные числа от 1 до N");
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
if (n == 1 )
    {
        Console.WriteLine("Чисел нет");
    }
else
    {
        int b = 1;
        
        while(b <= n)
            {
                if (b%2 == 0)
                    {
                        Console.Write($"{b}, ");
                        b++;
                        
                    }
                else
                    {
                        b++;
                    }
            }
            
            
    }
if (n < 1)
    {
        int c = 1;
        while (n <= c)
            {
                if (c % 2 == 0)
                    {
                        Console.Write($"{c}, ");
                        c--;
                    }
                else
                    {
                        c--;
                    }
            }
    }