var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please enter your name");

    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("\n------------------------------------\n");
    Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math game.");
    
    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                V - View Previous Games
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q - Quit the Program
                ");
        Console.WriteLine("==================================\n");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    } while (isGameOn);
}

void GetGames()
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

void AdditionGame(string message)
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

        firstNumber = random.Next(1,9);
        secondNumber = random.Next(1,9);

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

    AddToHistory(score, "Addition");
}

void SubtractionGame(string message)
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

    AddToHistory(score, "Subtraction");
}

void MultiplicationGame(string message)
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

    AddToHistory(score, "Multiplication");
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
    var score = 0;

    for (int i = 0; i < 2; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
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

    AddToHistory(score, "Division");
}

int[] GetDivisionNumbers()
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

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}");
}

void QuitGame()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
