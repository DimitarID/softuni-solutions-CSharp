string tittle = Console.ReadLine();
int movieTime = int.Parse(Console.ReadLine());
int rest = int.Parse(Console.ReadLine());

double launchTime = rest * 0.125;
double restTime = rest * 0.25;
double timeRemaining = rest - launchTime - restTime;

if (movieTime <= timeRemaining)
{
    Console.WriteLine($"You have enough time to watch {tittle} and left with {Math.Ceiling(timeRemaining - movieTime)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {tittle}, you need {Math.Ceiling(movieTime - timeRemaining)} more minutes.");
}