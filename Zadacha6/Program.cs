Console.Write("Введите целое число, проверим являтся ли оно чётным:");
int a = int.Parse(Console.ReadLine());
if (a%2 == 1 | a%2 == -1)
                    {
                        Console.WriteLine("Нет");
                    }
else
    {
        Console.WriteLine("Да");
    }