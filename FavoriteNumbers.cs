using System;
using System.Collections.Generic;

public class Numbers
{

    public static void Main()
    {

        int[] ints = new int[5];

        Console.WriteLine("Podaj swoje 5 ulubione liczby:");

        for (int i = 0; i < ints.Length; i++)
        {
            while (true)
            {
                Console.WriteLine($"Liczba {i + 1}:");
                string userInput = Console.ReadLine();



                try
                {
                    ints[i] = int.Parse(userInput);
                    break;
                }

                catch
                {

                    Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę całkowitą.");

                }

            }



        }

        Console.WriteLine($"\nTwoje ulubione liczby to:");
        foreach (int number in ints)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} Parzysta");
            }
            else
            {
                Console.WriteLine($"{number} Nieparzysta");
            }
        }
    }
}

