Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0) {
    Console.WriteLine("Кратно");
} else
    Console.WriteLine($"Остаток от деления: {num1 % num2}");


// int num1 = new Random().Next(1, 100);
// int num2 = new Random().Next(1, 100);
// int result = num2 / num1;
// if (num2 % num1 == 0) 
// {
//     Console.WriteLine($"Число {num2} кратно числу {num1}");
// } else 
//     Console.WriteLine($"Остаток от деления числа {num2} на {num1} равно: {result} ");
