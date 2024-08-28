using System;

class Elements
{
    static void Main()
    {
       
        Console.WriteLine("Enter length of array: ");
        int n = int.Parse(Console.ReadLine());

        
        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("Your array is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();

        
        int start = 0; 
        int len = 1;   
        int bestStart = 0; 
        int bestLen = 1;   

        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                len++; 
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
                start = i;
                len = 1;
            }
        }

       
        if (len > bestLen)
        {
            bestLen = len;
            bestStart = start;
        }

        
        Console.WriteLine("The longest sequence is: ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}
