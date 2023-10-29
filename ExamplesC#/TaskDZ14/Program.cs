// Напишите программу, которая подсчитывает количество четных элементов в массиве 
// целых положительных трехзначных чисел и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, который принимает массив целых 
// положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

int CountEvenElements(int[] array)
{
    // Введите свое решение ниже
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    // Введите свое решение ниже
    foreach (int item in array)
        Console.Write(item + ((i != array.Length-1) ? "\t" : ""));

    System.Console.WriteLine();
}
Console.WriteLine("Введите размер массива: ");
int arle = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arle];
int evenCount = CountEvenElements(arr);
PrintArray(arr);
Console.WriteLine($"Количество четных элементов: {evenCount}");