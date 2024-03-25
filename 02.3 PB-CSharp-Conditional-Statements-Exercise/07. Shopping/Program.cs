double budget = double.Parse(Console.ReadLine());
int videoCard = int.Parse(Console.ReadLine());
int processor = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double totalSum = 0;

double videoCardSum = 250 * videoCard;
double processorPrice = videoCardSum * 0.35;
double processorSumTotal = processorPrice * processor;
double ramSumTotal = (videoCardSum * 0.1) * ram;

totalSum = videoCardSum + processorSumTotal + ramSumTotal;

if (videoCard > processor)
{
    totalSum = totalSum * 0.85;
}

if (totalSum <= budget)
{
    double over = budget - totalSum;
    Console.WriteLine($"You have {over:f2} leva left!"); 
}

else
{
    double below = totalSum - budget;
    Console.WriteLine($"Not enough money! You need {below:f2} leva more!");
}