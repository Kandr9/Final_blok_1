﻿//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string [] startingArray = new string[] {"main", "333", "world", "999"};
string[] resultArray = new string [0];

foreach (var item in startingArray)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref resultArray, resultArray.Length + 1);
    resultArray [resultArray.Length-1] = item;
    }
}

Console.WriteLine($"[{String.Join("; ", resultArray)}]");