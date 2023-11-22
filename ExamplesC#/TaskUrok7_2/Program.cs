// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

int Input(string message) 
{ 
    System.Console.Write(message); 
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result; 
}

int FAkkerman (int n, int m)
   {
        if (n == 0) return m + 1;
        if (m == 0) return FAkkerman(n - 1, 1);
        return FAkkerman(n - 1, FAkkerman(n, m - 1));
    }

int n0 = Input("Введите первое число: ");
int m0 = Input("Введите второе число: ");
if (n0 < 0 || m0 < 0) Console.WriteLine("Введенные числа должны быть положительными");
else Console.WriteLine(FAkkerman(n0, m0));