// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Ведите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());
if ((num == 6) || (num == 7)) {
    Console.WriteLine("Выходной");
} else if (num < 6) 
{
    Console.WriteLine("Будний день");
}
