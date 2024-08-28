using System;
class MostOftenNUmber
{
    static void Main()
    {
        int length;
        int maxlength = 1;
        int currlength = 1;
        Console.WriteLine("\nEnter length of array: ");
        length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter " + (i + 1) + " element of array: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nYour array: ");
        for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
        }
        int currelement = array[0];
        int maxlengthelement = array[0];
        for (int i = 1; i < array.Length; i++) { 
            if (array[i] == currelement)
            {
                currlength++;
            }
            else
            {
                if (currlength > maxlength)
                {
                    maxlength = currlength;
                    maxlengthelement = currelement;
                }
                currelement = array[i];
                currlength = 0;
            }

        }
        if (currlength > maxlength)
        {
            maxlength = currlength;
            maxlengthelement = currelement;
        }
        Console.WriteLine("Result " + maxlengthelement);
    }
}