﻿Console.Clear();
Console.WriteLine("Ведите число: ");
int num = int.Parse(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0)) {
    Console.WriteLine("Кратно");
} else
    Console.WriteLine("Не кратно");