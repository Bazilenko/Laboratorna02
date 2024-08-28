using System;
class SumOfSpin
{
    static void Main()
    {
        int length;
        do {
            Console.WriteLine("Enter lenght of the array: ");
            length = int.Parse(Console.ReadLine());

                }while(length % 4 != 0); 

        int[] array = new int[length];
        int[] sum = new int[length / 2];
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter " + (i + 1) + " element: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] first_spin = new int[length / 2];
        int[] second_spin = new int[length / 2];
        int k = length / 4;
        for (int i = 0; i < k; i++)
        {
            first_spin[i] = array[k - 1 - i];
        }
        for (int i = 0; i < k; i++)
        {
            first_spin[k + i] = array[length - 1 - i];
        }

        for (int i = 0; i < k; i++)
        {
            second_spin[i] = array[k + i];  
        }
        for (int i = 0; i < k; i++)
        {
            second_spin[k + i] = array[length / 2 + i];  
        }
        for (int i = 0; i < length / 2; i++)
        {
            sum[i] = first_spin[i] + second_spin[i];
        }
        Console.WriteLine("Your array: ");
        for (int i = 0; i < first_spin.Length; i++)
        {
            Console.Write(first_spin[i] + " ");
        }
        Console.Write("+");
        Console.WriteLine();
        for(int i = 0;i < length / 2; i++)
        {
            Console.Write(second_spin[i] + " ");
        }
        Console.Write("=");
        Console.WriteLine();
        for (int i = 0; i < length / 2; i++)
        {
            Console.Write(sum[i] + " ");
        }
        

    }
}