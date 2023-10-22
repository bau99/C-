// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

bool Polyndrom(int digit)
{
    int[] array = new int[5];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = digit % 10;
        digit = digit / 10;
    }
    int index = 0;
    if (array[index] == array[array.Length - 1] && array[index + 1] == array[array.Length - 2])
    {
        return true;
    }
    return false;
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    if (Polyndrom(num))
    {
        Console.WriteLine($"Введённое число {num} является полиндромом");
    }
    else Console.WriteLine($"Введённое число {num} не является полиндромом");


}
else
    Console.WriteLine("Введите пятизначное число");
return;
