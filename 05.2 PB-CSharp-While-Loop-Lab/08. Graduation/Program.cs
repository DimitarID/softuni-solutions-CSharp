string name = Console.ReadLine();
int counter = 0;
double sum = 0;
int excluded = 0; 
bool isExcluded = false;
double grade = 0;


while (counter < 12)
{
    grade = double.Parse(Console.ReadLine());

    if (grade < 4.00)
    {
        excluded++;
    }

    else if (grade >= 4.00)
    {
        sum += grade;
        counter++;
    }
    if (excluded >= 2)
    {
        isExcluded = true;
        break;
    }
}

if (isExcluded == false)
{
    double avarage = sum / 12;
    Console.WriteLine($"{name} graduated. Average grade: {avarage:f2}");
}
else
{
    Console.WriteLine($"{name} has been excluded at {counter + 1} grade");
}