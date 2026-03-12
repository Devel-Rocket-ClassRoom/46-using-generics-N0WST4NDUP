using System;

public static class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        Swap(ref array[index1], ref array[index2]);
    }

    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            min = min.CompareTo(array[i]) > 0 ? array[i] : min;
        }
        return min;
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            max = max.CompareTo(array[i]) > 0 ? max : array[i];
        }
        return max;
    }

    public static void Reverse<T>(T[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            SwapInArray(array, i, array.Length - 1 - i);
        }
    }
}