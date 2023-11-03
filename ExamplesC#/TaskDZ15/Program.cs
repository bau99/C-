// Задача 1: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

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

int m = Input("Введите кол-во строк: "), n = Input("Введите кол-во стобцов: "); 
int s1 = Input("Введите номер строки искомого элемента: "), s2 = Input("Введите номер столбца искомого элемента: "); 
int[,] arr = Getmatrix(m, n, 0, 20); 
if (s1 > m || s2 > n)
{
    System.Console.WriteLine("Такого элемента массива нет");
}
else 
System.Console.WriteLine($"Значение элемента на {s1} строке в {s2} столбце равно {arr[s1, s2]}"); 