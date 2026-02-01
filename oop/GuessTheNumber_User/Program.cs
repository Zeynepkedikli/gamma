using System;

class GuessTheNumber_UserGuesses
{
    static int GetRandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 1001);
    }

    static void Main()
    {
        int secretNumber = GetRandomNumber();
        int guessCount = 0;
        bool isCorrect = false;

        Console.WriteLine("Sayi Tahmin Oyunu");
        Console.WriteLine("1 ile 1000 arasinda bir sayi tuttum.");
        Console.WriteLine();

        while (!isCorrect)
        {
            guessCount++;
            Console.Write("Tahmininiz: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userGuess))
            {
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Daha buyuk bir sayi deneyin.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Daha kucuk bir sayi deneyin.");
                }
                else
                {
                    Console.WriteLine("Dogru tahmin!");
                    Console.WriteLine("Sayi: " + secretNumber);
                    Console.WriteLine("Toplam Tahmin Sayisi: " + guessCount);
                    isCorrect = true;
                }
            }
            else
            {
                Console.WriteLine("Gecerli bir sayi girin.");
                guessCount--;
            }
        }
    }
}