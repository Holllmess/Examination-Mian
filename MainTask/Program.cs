// Написать программу, которая из имеющегося массива строк формирует массив из 
// строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

string[] stringArray = { "hello", "world", "2", ":-)" };

void PrintStringArray(string[] stringArray)
{
  Write("["); // 6-я строка убирает console 
  for (int i = 0; i < stringArray.Length; i++)
  {
    Write($"\"{stringArray[i]}\"");
    if (i != stringArray.Length - 1)
    {
      Write(", ");
    }
  }
  Write("]");
}