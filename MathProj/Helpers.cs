﻿namespace MathProj
{
    internal class Helpers
    {
        static List<string> games = new();

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History \n");
            Console.WriteLine("==================================\n");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("==================================\n");
            Console.WriteLine("Press Any Key To Return To The Main Menu");
            Console.ReadLine();
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            //keep generating random numbers until the division results in an integer
            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            var result = new int[2];
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}");
        }
    }
}
