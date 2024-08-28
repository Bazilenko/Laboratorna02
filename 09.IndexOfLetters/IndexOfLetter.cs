using System;
class IndexOfLetters
{
    static void Main()
    {
        string alphabet = "abcdefghijklmopqrstuvxyz", word;
        bool exist = false;
        Console.WriteLine("Enter word: ");
        word = Console.ReadLine();
        word = word.ToLower();
        Console.WriteLine("Your word is: " + word);
        for (int i = 0; i < word.Length; i++)
        {
            exist = false;
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    exist = true;
                    Console.WriteLine(word[i] + " -> " + alphabet[j]);
                }

            }
            if (!exist)
                Console.WriteLine(word[i] + " doesn't exist in english alphabet!");
        }
    }


        }
       