// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1;
for (int i = 2; i <= num2; i++)
{
    result*= num1;
}
System.Console.WriteLine($"{num1} в степени {num2} будет {result}");