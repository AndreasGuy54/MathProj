namespace MathProj
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = int.Parse(Console.ReadLine());

                if (result == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Enter any key to see the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer is wrong! Enter any key to see the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"\nGame Over. You scored: {score}/2. Press any key to return to the main menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, "Addition");
        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = int.Parse(Console.ReadLine());
                if (result == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Enter any key to see the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer is wrong! Enter any key to see the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"\nGame Over. You scored: {score}/2. Press any key to return to the main menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, "Subtraction");
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = int.Parse(Console.ReadLine());
                if (result == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Enter any key to see the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer is wrong! Enter any key to see the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"\nGame Over. You scored: {score}/2. Press any key to return to the main menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);
            var score = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = int.Parse(Console.ReadLine());
                if (result == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Enter any key to see the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer is wrong! Enter any key to see the next question");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"\nGame Over. You scored: {score}/2. Press any key to return to the main menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, "Division");
        }
    }
}
