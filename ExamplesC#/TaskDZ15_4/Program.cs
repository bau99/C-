// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива. Под удалением понимается 
// создание нового двумерного массива без строки и столбца

int Input(string message) 
{ 
    System.Console.Write(message); 
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result; 
}

int[,] Getmatrix(int len1, int len2, int a, int b) 
{ 
    int[,] matrix = new int[len1, len2]; 
    b++; 
// Генерировать будем до b включительно 
    Random rand = new Random(); 
    for (int i = 0; i < len1; i++) 
    { 
        for (int j = 0; j < len2; j++) 
        { 
            matrix[i, j] = rand.Next(a, b); 
        } 
    } 
    return matrix; 
}

 void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            System.Console.Write("{0, 3} ", matrix[i, j]); 
        } 
        System.Console.WriteLine();
    } 
}

int [] KoordinatyMin(int [,] arr1, int len1, int len2)
{
    int[] Koordinaty = new int[3];
    Koordinaty [0] = 0;
    for (int i = 0; i < len1; i++) 
    { 
        for (int j = 0; j < len2; j++) 
        { 
            if (arr1[i, j] < Koordinaty [1])
            {
                Koordinaty [0] = arr1[i, j];
                Koordinaty [1] = i;
                Koordinaty [2] = j;
                // System.Console.Write(Koordinaty[0]);
                // System.Console.Write(Koordinaty[1]);
                // System.Console.Write(Koordinaty[2]);
                // System.Console.WriteLine();
            }
        } 
    } 
    return Koordinaty; 
}

int [,] ChangeMatrix(int [,] arr2, int [] arr3, int len1, int len2)
{
    int[,] Change = new int[len1, len2];
    int a = 0;
    int b = 0;
    for (int i = 0; i < len1; i++) 
    { 
        if (i == arr3 [1])
        {
            a++;
            if (a == len1-1)
            {
                break;
            }
        }
        for (int j = 0; j < len2; j++) 
        { 
            if (j == arr3 [2])
            {
                    b++;
                    if (b == len2-1)
                    {
                        break;
                    }
            }
            Change [i, j] = arr2 [a, b];
            b++;
        } 
        a++;
    } 
    return Change; 
}

int m = Input("Введите количество строк: "), n = Input("Введите количество столбцов: "); 
int[,] arr = Getmatrix(m, n, 0, 20);
System.Console.WriteLine("Изначальная матрица"); 
PrintMatrix(arr);
int [] MinimalPosition = KoordinatyMin (arr, m, n);
int[,] array = ChangeMatrix(arr, MinimalPosition, m, n);

System.Console.WriteLine("Измененная матрица"); 
PrintMatrix(array);