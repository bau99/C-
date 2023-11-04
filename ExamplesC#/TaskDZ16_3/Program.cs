﻿// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string Input(string message)
{
  System.Console.Write(message);
  string result = Console.ReadLine()!; // восклицательный знак чтобы не ругался на возможный NULL
  return result;
}

bool IsPallindrome(string str)
{
  str = str.ToLower(); // Регистр нам не важен
  for (int i = 0; i < str.Length; i++)
  {
    if (str[i] != str[str.Length - 1 - i]) return false;
  }
  return true;
}

string str = Input("Введите строку: ");
System.Console.WriteLine(IsPallindrome(str) ? "Да, является полиндромом" : "Нет, не является полиндромом");