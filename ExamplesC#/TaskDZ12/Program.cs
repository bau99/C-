// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Digits(string message)
{
    Console.WriteLine(message);
    int digit = Convert.ToInt32(Console.ReadLine());
    return digit;
}

int SummDigits(int number)
{
    int summ = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

int num1 = Digits("Введите целое число: ");
System.Console.WriteLine($"Сумма цифр числа {num1} равна {SummDigits(num1)}");