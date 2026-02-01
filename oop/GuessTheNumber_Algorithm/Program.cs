using System;

class GuessTheNumber_AlgorithmGuesses
{
    static void Main()
    {
        Console.Write("1 ile 1000 arasinda bir sayi tut (enter'a bas): ");
        Console.ReadLine();

        int minRange = 1;
        int maxRange = 1000;
        int guessCount = 0;
        bool found = false;

        Console.WriteLine("Algoritma tahmin edecek, sen kucuk/buyuk/dogru de.");
        Console.WriteLine();

        while (!found)
        {
            guessCount++;
            int algorithmGuess = (minRange + maxRange) / 2;

            Console.WriteLine("Tahmin " + guessCount + ": " + algorithmGuess);
            Console.Write("(k=kucuk, b=buyuk, d=dogru): ");
            string response = Console.ReadLine().ToLower();

            if (response == "k")
            {
                minRange = algorithmGuess + 1;
            }
            else if (response == "b")
            {
                maxRange = algorithmGuess - 1;
            }
            else if (response == "d")
            {
                Console.WriteLine("Buldum!");
                Console.WriteLine("Sayi: " + algorithmGuess);
                Console.WriteLine("Toplam Tahmin Sayisi: " + guessCount);
                found = true;
            }
            else
            {
                Console.WriteLine("Gecersiz giris. k, b veya d gir.");
                guessCount--;
            }
        }
    }
}