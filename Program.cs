// Задача 0
// Напишите программу, которая на вход принимает число и выдает его квадрат
//(число умноженное на само себя)
int n = 7;
int result;

result = n * n;
{

    Console.WriteLine(result);

}
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
// Задача 3
// Напишите программу, которая на по номеру будет выдавать день недели

int dey = 5;

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
