// Задача 23: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void FillArray(int[] array)
{
    for (int i = 1; i <= array.Length; i++)
    {
        array[i-1] = i; 
        for (int kub = 1; kub < 3; kub++)
        {
            array[i-1] *= i;
        }
    }
}
void PrintArray(int[] array)
{
    foreach (int item in array)
       Console.Write($"{item} ");
    System.Console.WriteLine();
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int[] array = new int[num];
    FillArray(array);
    PrintArray(array);
}
else
System.Console.WriteLine("Введите число больше 0 ");
return;