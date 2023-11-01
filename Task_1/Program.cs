/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


//string[] primaryArray = { "Hello", "2", "world", ":-)" };
string[] primaryArray = { "1234", "1567", "-2", "computer science" };
//string[] primaryArray = { "Russia", "Denmark", "Kazan" };
string[] newArray = new string[primaryArray.Length];
int count = 0;

void SecondArray(string[] args)
{
    for (int i = 0; i < primaryArray.Length; i++)
    {
        if (primaryArray[i].Length <= 3)
        {
            newArray[count] = primaryArray[i];
            count++;
        }
    }

    Console.Write("-> [");

    for (int i = 0; i < count; i++)
    {
        Console.Write("\"" + newArray[i] + "\"");
        Console.Write("; ");
    }
    if (count > 0)
    {
        Console.Write("\b\b");
    }
    Console.Write("]");
}

SecondArray(primaryArray);

