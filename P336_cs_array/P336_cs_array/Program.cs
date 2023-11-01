using System;
class Program
{
    static int[] CreateArray(int length, int value)
    {
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = value;
        }

        return array;
    }
    static void Main()
    {
        int length = 7;
        int value = 14;

        int[] newArray = CreateArray(length, value);

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
