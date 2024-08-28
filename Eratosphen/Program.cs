using System;

class Eratosphen
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter n: ");
        n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n];
        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = true;

        }
        primes[0] = false;
        primes[1] = false;
        for (int i = 2; i * i < n ; i++)
        {
            if (primes[i])
            {
                for (int j = i * i; j < n; j += i)
                {
                    primes[j] = false;
                }
            }
        }
        for (int i = 0; i < primes.Length; i++)
        {
            if (primes[i])
            Console.Write(i + " ");
        }
    }
}

