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


        for (int i = 0; i < oceny.Length; i++)
        {
            suma += oceny[i];
        }


        double srednia = (double)suma / oceny.Length;

        Console.WriteLine("Oceny ucznia: ");
        for (int i = 0; i < oceny.Length; i++)
        {
            Console.Write(oceny[i] + " ");
        }

        Console.WriteLine($"\nŚrednia ocen: {srednia:F2}");

        for (int i = 1; i < oceny.Length; i++)
        {
            if (oceny[i] > najlepszaOcena)
            {
                najlepszaOcena = oceny[i];
            }
        }

        Console.WriteLine($"\nNajlepsza ocena: {najlepszaOcena}");

    }
}
