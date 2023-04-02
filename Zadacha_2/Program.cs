Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0) {
    Console.WriteLine("Кратно");
} else
    Console.WriteLine($"Остаток от деления: {num1 % num2}");



