// Написать программу, которая из имеющегося массива строк формирует массив из 
// строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

string[] stringArray = { "world", ":-)", "happy", "GB", "&", "7777", "co" };

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

int SearchStringWithSizeLessOrEqual3(string[] stringArray)
{
  int numberOfString = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      numberOfString++;
    }
  }
  return numberOfString;
}

string[] CreatArrayWithSizeLessOrEqual3(string[] stringArray, int sizeNewArray)
{
  string[] newStringArray = new string[sizeNewArray];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      newStringArray[j] = stringArray[i];
      j++;
    }
  }
  return newStringArray;
}

PrintStringArray(stringArray);
int sizeNewArray = SearchStringWithSizeLessOrEqual3(stringArray);
string[] newStringArray = CreatArrayWithSizeLessOrEqual3(stringArray, sizeNewArray);
Write(" --> ");
PrintStringArray(newStringArray);