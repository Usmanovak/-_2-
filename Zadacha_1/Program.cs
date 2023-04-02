Console.Clear();
//Console.WriteLine("Введите трехзначное число: ");
int num = new Random().Next(100, 1000);
int a1 = (num / 100); // 1 chislo
int a2 = (num / 10 % 10); // 2 chislo
int a3 = (num % 100 % 10); // 3
Console.WriteLine(num);
Console.Write(a1);
Console.Write(a3);
