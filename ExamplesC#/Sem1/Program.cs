// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int GetCountDigits(int number)
// {
//     int count = 0;
//     if (number == 0)
//     {
//         count = 1;
//     }
//     else
//         while (number != 0) // Если число не равно 0, т.е. 
//                             // принимаем в работу и положительные и отрицательные числа
//         {
//             number /= 10;
//             count++;
//         }
//     return count;
// }

// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // int count = 0;
// // if (num == 0)
// // {
// //     count = 1;
// // }
// // else
// //     while (num != 0) // Если число не равно 0, т.е. 
// //                      // принимаем в работу и положительные и отрицательные числа
// //     {
// //         num /= 10;
// //         count++;
// //     }

// System.Console.WriteLine("Количество цифр " + GetCountDigits(num));

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// int GetFaktDigits(int number)
// {
//     int Fakt = 1;
//     for (int i = 1; i <= number; i++)
//         Fakt *= i;
//     return Fakt;
// }

// Console.WriteLine("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)
// {
//     Console.WriteLine("Факториал вычислить невозможно! ");
// }
// else System.Console.WriteLine($"Факториал числа {num} = {GetFaktDigits(num)} ");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,2);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
       Console.Write($"{item} ");
    System.Console.WriteLine();
}

int GetCountOnes(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] == 1)
    {
        count ++;
    }
    return count;
}


int[] array = new int[8];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Количество единиц в массиве " + GetCountOnes(array));