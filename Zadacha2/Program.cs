Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чисдо");
int b = int.Parse(Console.ReadLine());
if (a > b)
            {
                Console.WriteLine($"max = {a}");
            }
else
            {
                Console.WriteLine($"max = {b}");
            }