using System;

class Program
{
    static void Main()
    {
        // Tablica z ocenami ucznia
        int[] oceny = { 5, 4, 3, 5, 2, 4, 3 };


        int najlepszaOcena = oceny[0];

        // Zmienna do przechowywania sumy ocen
        int suma = 0;

        Array.Sort(oceny);

        // Zmienna do przechowywania mediany
        double mediana;

        // Sprawdzenie, czy liczba elementów jest parzysta czy nieparzysta
        if (oceny.Length % 2 == 0)
        {
            // Jeśli parzysta, mediana to średnia dwóch środkowych elementów
            int midIndex1 = oceny.Length / 2 - 1;
            int midIndex2 = oceny.Length / 2;
            mediana = (oceny[midIndex1] + oceny[midIndex2]) / 2.0;
        }
        else
        {
            // Jeśli nieparzysta, mediana to środkowy element
            int midIndex = oceny.Length / 2;
            mediana = oceny[midIndex];
        }

        // Wyświetlenie wyników
        Console.WriteLine("Posortowane oceny ucznia: ");
        for (int i = 0; i < oceny.Length; i++)
        {
            Console.Write(oceny[i] + " ");
        }



        for (int i = 0; i < oceny.Length; i++)
        {
            suma += oceny[i];
        }


        double srednia = (double)suma / oceny.Length;


        Console.WriteLine($"\nŚrednia ocen: {srednia:F2}");

        for (int i = 1; i < oceny.Length; i++)
        {
            if (oceny[i] > najlepszaOcena)
            {
                najlepszaOcena = oceny[i];
            }
        }

        Console.WriteLine($"\nNajlepsza ocena: {najlepszaOcena}");
        Console.WriteLine($"\nMediana ocen: {mediana}");


    }
}
