// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


using System;

class Program
{

    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        InverseArray(array, array.Length - 1);
    }

    static void InverseArray(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            InverseArray(array, index - 1);
        }
    }

}