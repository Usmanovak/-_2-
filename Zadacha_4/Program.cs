Console.Clear();
Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1) 
    {
    Console.WriteLine("Да");
} else 
{
    Console.WriteLine("Нет");
}
    