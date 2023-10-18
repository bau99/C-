// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число = "); 
int number = int.Parse(Console.ReadLine()); 
if (number > 99 && number < 1000) //Проверяем: трехзначное ли число?
{
    int num1 = number % 10; //Берем третью цифру трехзначного числа
    Console.WriteLine(num1);
}
else if (number > 999 && number < 10000) //Проверяем: четырехзначное ли число?
{
    int num1 = number / 10 % 10; //Берем третью цифру четырехзначного числа
    Console.WriteLine(num1);
}
else if (number > 9999 && number < 100000) //Проверяем: пятизначное ли число?
{
    int num1 = number / 100 % 10; //Берем третью цифру пятизначного числа
    Console.WriteLine(num1);
}
else Console.WriteLine("Третьей цифры нет!");