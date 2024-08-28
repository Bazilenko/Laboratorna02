using System;

class StrArray
{
    static void Main()
    {
        Console.WriteLine("Enter first string: ");
        string[] arr1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter second string: ");
        string[] arr2 = Console.ReadLine().Split(' ');

        int minlength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
        int commonBegin = 0;
        int commonEnd = 0;

        for (int i = 0; i < minlength; i++)
        {
            if (arr1[i] == arr2[i])
                commonBegin++;
            else
                break;
        }

        for (int i = 0; i < minlength; i++)
        {
            if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                commonEnd++;
            else
                break;
        }
        if (commonBegin > commonEnd)
        {
            Console.WriteLine("The most commonend is left: ");
            for (int i = 0; i < commonBegin; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
        else if (commonEnd > commonBegin)
        {
            Console.WriteLine("The most commonend is right: ");
            for (int i = arr1.Length - commonEnd; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("There is not common words!");
        }
    }
}
