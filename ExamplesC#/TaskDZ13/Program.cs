// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//!!! Задача не уточнена: как задаются значения элементов массива? 
//    Примеры приведены некорректно условию: массивы 5 и 3 элементов!
//    Поэтому массив заполним случайным образом, а задачу сделаем более универсальной.

int Digits(string message)
{
    Console.WriteLine(message);
    int digit = Convert.ToInt32(Console.ReadLine());
    return digit;
}

void FillArray(int[] array, int min, int max )
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min,max+1);
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + ((j != array.Length-1) ? ", " : " "));
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int arle = Digits("Введите размер массива: ");
int start = Digits("Введите нижнюю границу значений элементов массива: ");
int finish = Digits("Введите верхнюю границу значений элементов массива: ");
int[] array = new int[arle];
FillArray(array, start, finish);
PrintArray(array);