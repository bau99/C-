// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Digits(string message)
{
      while (true) 
    {   
        Console.WriteLine(message);
        int digit = Convert.ToInt32(Console.ReadLine());
        if (digit > 0) return digit;   
        else System.Console.WriteLine("Число должно быть натуральным"); 
    } 
}

void DegreeOfNumber(int digit1, int digit2)
{
    int result = digit1;
    for (int i = 2; i <= digit2; i++)
    {
        result *= digit1;
    }
    System.Console.WriteLine($"{digit1} в степени {digit2} будет {result}");
}

int num1 = Digits("Введите первое натуральное число: ");
int num2 = Digits("Введите второе натуральное число: ");
DegreeOfNumber(num1, num2);