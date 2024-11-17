using System;

class FavoriteNumbers
{
    public static void Main()
    {
        // Tworzymy tablicę na 5 liczb
        int[] numbers = new int[5];

        Console.WriteLine("Podaj 5 ulubionych liczb:");

        // Pętla do wczytywania liczb od użytkownika
        for (int i = 0; i < numbers.Length; i++)
        {
            while (true) // Pętla do obsługi błędów wprowadzania
            {
                Console.Write($"Liczba {i + 1}: ");
                string userInput = Console.ReadLine();

                try
                {
                    // Konwersja wprowadzonego tekstu na liczbę
                    numbers[i] = int.Parse(userInput);
                    break; // Jeśli konwersja się powiedzie, przerywamy pętlę
                }
                catch
                {
                    Console.WriteLine("Nieprawidłowa wartość. Podaj liczbę całkowitą.");
                }
            }
        }

        // Znalezienie największej liczby w tablicy
        int maxNumber = numbers[0]; // Zakładamy, że pierwsza liczba jest największa
        foreach (int number in numbers)
        {
            if (number > maxNumber)
                maxNumber = number;
        }

        // Wyświetlenie wyników
        Console.WriteLine($"\nTwoje ulubione liczby to:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"\nNajwiększa liczba: {maxNumber}");
    }
}
