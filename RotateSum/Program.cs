using System;


class RotateAndSumArray
{
    static void Main()
    {
        int n, k;
       
        Console.WriteLine("Enter length of array: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter quantity of rotate: ");
        k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int[] sum = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your array is: ");
        printArray (arr);
        
        for (int i = 0; i < k; i++)
        {
            rotateArray (arr);
            Console.WriteLine($"{i + 1} rotate:");
            printArray(arr);
            for (int j = 0; j < arr.Length; j++)
            {
                sum[i] += arr[j];
            }
            
     
           
        }
        Console.WriteLine($"Sum: ");
        printArray (sum);



        void printArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        void rotateArray(int[] array)
        {
            int temp;
            for(int i = 0;i < 1; i++)
            {
               for(int j = i + 1; j < array.Length; j++)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

        }

        
        
    }
}
