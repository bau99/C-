// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int Input(string message) 
{ 
    System.Console.Write(message); 
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result; 
}

int[] Getmatrix(int length, int a, int b) 
{ 
    int[] matrix = new int[length]; 
    b++; 
// Генерировать будем до b включительно 
    Random rand = new Random(); 
    for (int i = 0; i < length; i++) 
    { 
        matrix[i] = rand.Next(a, b); 
    } 
    return matrix; 
}

void PrintMatrix(int[] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        System.Console.Write("{0, 3} ", matrix[i]); 
    } 
    System.Console.WriteLine();
}

void NewMatrix(int[] array, int i = 0)
{
    if (i < array.Length - 1) NewMatrix(array, i + 1);
    System.Console.Write("{0, 3} ", array[i]);
}

int m = Input("Введите длинну массива: ");
int[] arr = Getmatrix(m, 0, 20);

System.Console.WriteLine("Изначальная матрица"); 
PrintMatrix(arr);

System.Console.WriteLine("Измененная матрица"); 
NewMatrix(arr);