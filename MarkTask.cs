using System;

using System;

class MarkTask
{
    static void Main()
    {
        int[] oceny = { 5, 4, 3, 5, 2, 4, 3 };

        // Sprawdzanie, czy tablica ocen nie jest pusta
        if (oceny.Length == 0)
        {
            Console.WriteLine("Brak ocen do obliczeń.");
            return;
        }

        int suma = 0;

        for (int i = 0; i < oceny.Length; i++)
        {
            suma += oceny[i];
        }

        double srednia = (double)suma / oceny.Length;

        // Sortowanie ocen
        Array.Sort(oceny);

        double mediana;
        int najlepszaOcena = oceny[0];

        // Szukanie najlepszej oceny
        for (int i = 1; i < oceny.Length; i++)
        {
            if (oceny[i] > najlepszaOcena)
            {
                najlepszaOcena = oceny[i];
            }
        }

        // Obliczanie mediany
        if (oceny.Length % 2 == 0)
        {
            int midIndex1 = oceny.Length / 2 - 1;
            int midIndex2 = oceny.Length / 2;
            mediana = (oceny[midIndex1] + oceny[midIndex2]) / 2.0;
        }
        else
        {
            int midIndex = oceny.Length / 2;
            mediana = oceny[midIndex];
        }

        // Wyświetlanie wyników
        Console.WriteLine("Posortowane oceny ucznia: ");
        for (int i = 0; i < oceny.Length; i++)
        {
            Console.Write(oceny[i] + " ");
        }

        Console.WriteLine($"\nMediana ocen: {mediana}");
        Console.WriteLine($"Średnia ocen: {srednia:F2}");
        Console.WriteLine($"Najlepsza ocena: {najlepszaOcena}");
    }
}

