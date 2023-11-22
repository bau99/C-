// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int Input(string message) 
{ 
    System.Console.Write(message); 
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result; 
}

string RowNumbers(int min, int max)
{
    if (min <= max) return $"{min} " + RowNumbers(min+1, max);
    else return String.Empty;
}

int m = Input("Введите первое число: ");
int n = Input("Введите второе число: "); 

if (m < n) System.Console.WriteLine(RowNumbers(m, n));
else System.Console.WriteLine(RowNumbers(n, m));
