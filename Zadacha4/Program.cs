﻿Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
if (a > b)
            {
                if (a > c)
                            {
                                Console.WriteLine(a);
                            }
                else
                            {
                                Console.WriteLine(c);
                            }
            }
else
            {
                if (b > c)
                            {
                                Console.WriteLine(b);
                            }
                else
                            {
                                Console.WriteLine(c);
                            }
            }