using System;

class Program
{
    static void Main()
    {
        // Inicjalizujemy tablicę z 6 elementami
        int[] numbers = { 10, 20, 30, 40, 50, 60 };

        // Ustawiamy pierwszy element jako początkową największą liczbę
        int max = numbers[0];

        // Przechodzimy przez wszystkie elementy tablicy
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Wyświetlamy największą liczbę
        Console.WriteLine("Największa liczba w tablicy: " + max);
    }
}
