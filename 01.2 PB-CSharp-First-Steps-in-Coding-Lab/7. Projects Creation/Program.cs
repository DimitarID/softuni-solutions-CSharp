string name = Console.ReadLine();
int numOfProgects =int.Parse(Console.ReadLine());

int hours = numOfProgects * 3;

Console.WriteLine($"The architect {name} will need {hours} hours to complete {numOfProgects} project/s.");