// Напишите программу, которая подсчитывает количество четных элементов в массиве 
// целых положительных трехзначных чисел и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, который принимает массив целых 
// положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

int SummOddElements (int[] array)
{
    // Введите свое решение ниже
    int summ = 0;
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = new Random().Next(0,100);
        if (i % 2 != 0)
        {
            summ += array [i];
        }
      }
      return summ;
}

void PrintArray(int[] array)
{
    // Введите свое решение ниже
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ((i != array.Length-1) ? "\t" : ""));
    }
    System.Console.WriteLine();
}
Console.WriteLine("Введите размер массива: ");
int arle = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arle];
int SummOdd = SummOddElements(arr);
PrintArray(arr);
Console.WriteLine($"Сумма не четных элементов: {SummOdd}");