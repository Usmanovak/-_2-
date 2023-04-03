//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a3 = (num % 100 % 10); 
if (a3 >= 0) {
    Console.WriteLine(a3);
} else {
    Console.WriteLine("Третьей цифры нет");
}