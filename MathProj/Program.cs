using MathProj;

var menu = new Menu();
var date = DateTime.UtcNow;

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please enter your name");

    var name = Console.ReadLine();
    return name;
}

void QuitGame()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
