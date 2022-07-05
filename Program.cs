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

/*
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
*/
/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = 22;
int b = 3;
int c = 9;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max= ");
Console.WriteLine(max);
*/
/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int i;

Console.Write("Введите число : ");

i = int.Parse(Console.ReadLine());

if (i % 2 == 0)

{

    Console.Write("Введенное число является четным");
    Console.Read();

}

else
{

    Console.Write("Введенное число нечетное");
    Console.Read();
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*
Console.Write("Введите Ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.WriteLine(username);
Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int N = int.Parse(Console.ReadLine());
int i = 1, k = 1;
while (true)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        k++;
    }
    if (k > N)
    {
        break;
    }
    i++;
}
*/

Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();