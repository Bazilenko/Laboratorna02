using System;
class PairsByDifference
{
    static void Main()
    {
        int length;
        int difference;
        int counter = 0;
        Console.WriteLine("\nEnter length of the array: ");
        length = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter difference of the pair: ");
        difference = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("\nEnter " + (i + 1) + " element ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nPairs of elements with difference " + difference + " -> ");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (Math.Abs(array[i] - array[j]) == difference)
                {
                    Console.WriteLine("{" + array[i] + ", " + array[j] + "} ");
                    counter++;
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("There is no pair of numbers with difference " + difference);
        }
        else
        {
            Console.WriteLine("There is " + counter + " pair of numbers with difference " + difference);
        }
        
        
    }
   
}