double record = double.Parse(Console.ReadLine());
double meters = double.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());

double ivanTimeS = meters * time;

double ivanMinus = Math.Floor(meters / 15) * 12.5;

double ivanTotalTime = ivanTimeS + ivanMinus;

if (ivanTotalTime < record)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {ivanTotalTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {(ivanTotalTime - record):f2} seconds slower.");
}