// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] Koordinaty(string message)
{
    System.Console.WriteLine(message);
    int[] array = new int[3];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(System.Console.ReadLine());
    }
    return array;
}

// d = sqrt (x2 — x1)^2 + (y2 — y1)^2 + (z2 — z1)^2)
double dist(int[] array1, int[] array2) 
{
  double result = Math.Sqrt(Math.Pow((array2[0] - array1[0]), 2) + Math.Pow((array2[1] - array1[1]),2) + Math.Pow((array2[2] - array1[2]),2));
  return result;
}

int[] arrayA = Koordinaty("Ведите координаты первой точки: ");
int[] arrayB = Koordinaty("Ведите координаты второй точки: ");
System.Console.WriteLine("Расстояние между точками " + Math.Round(dist(arrayA, arrayB),2));