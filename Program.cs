/*
// Задача 0
// Напишите программу, которая на вход принимает число и выдает его квадрат
//(число умноженное на само себя)
int n = 7;
int result;

result = n * n;
{

    Console.WriteLine(result);

}
*/
/*
// Задача 1
// Напишите программу, которая на вход принимает число и проверяет, 
// является первое число квадратом второго

int a = 3;
int b = 25;

if (b == a * a)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго");
}
*/
/*
// Задача 3
// Напишите программу, которая на по номеру будет выдавать день недели
// 1+1=1 `1`+`1`=`11`, a+b=ab
Console.WriteLine("Введите число:");
int dey = Convert.ToInt32(Console.ReadLine());

if (dey == 1)
{
    Console.WriteLine("Понедельник");
}
else if (dey == 2)
{
    Console.WriteLine("Вторник");
}
else if (dey == 3)
{
    Console.WriteLine("Среда");
}
else if (dey == 4)
{
    Console.WriteLine("Четверг");
}
else if (dey == 5)
{
    Console.WriteLine("Пятница");
}
else if (dey == 6)
{
    Console.WriteLine("Суббота");
}
else if (dey == 7)
{
    Console.WriteLine("Воскресенье");
}
*/
/*
// Задача 5 Введите целые числа от -N до N
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int start = -Math.Abs(n);
int finich = Math.Abs(n);

Console.WriteLine("Начало вывода:");
while (start <= finich)
{
    Console.WriteLine(start);
    start++;

}
*/
/*
//Задача 7 
// Напишите программу, которая на вход принимает трехзначное число, 
// а на выход  показывает последнюю цифру этого числа

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
    Console.WriteLine("Последнее число");
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}
*/
//Домашнее задание

// Задача 2: Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


int a=5;
int b=7;

int max=a;
int min=b;

if (a>max) max=a;
if (b>max) max=b;
if (b<max) min=b;
if (a<max) min=a;

Console.Write("max= ");
Console.WriteLine (max);
Console.Write("min= ");
Console.WriteLine (min);

