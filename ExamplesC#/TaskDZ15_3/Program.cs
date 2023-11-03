// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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
            System.Console.Write(matrix[i,j]+ ((j != len2-1) ? "\t" : ""));
        } 
        System.Console.WriteLine();
    } 
    return matrix; 
}

int[] SummElements (int[,] array, int Length1, int Length2)
{
    int[] SummRow = new int[Length1];
    for (int i = 0; i < Length1; i++)
    {
        SummRow [i] = 0;
        for (int j = 0; j < Length2; j++) 
        { 
            SummRow [i] += array [i, j];
        }
    }
    return SummRow;
}

int MinimalSumm(int[] SummArr, int LengthStr)
{
    int min = SummArr [0];
    int numberStr = 0;
    for (int i = 0; i < LengthStr; i++)
    {
        if (SummArr [i] < min)
        {
            min = SummArr [i];
            numberStr = i;
        }
    }
    return numberStr;
}

int m = Input("Введите количество строк: "), n = Input("Введите количество столбцов: "); 
int[,] arr = Getmatrix(m, n, 0, 20); 
int [] SummStr = SummElements(arr, m, n);
int minsumm = MinimalSumm(SummStr, m);
Console.WriteLine($"Строка с минимальной суммой элементов: {minsumm+1}");