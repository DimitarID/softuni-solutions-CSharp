int students = int.Parse(Console.ReadLine());

int group1 = 0;
int group2 = 0;
int group3 = 0;
int group4 = 0;
double avaregeScore = 0;

for  (int i = 1; i <= students; i++)
{
    double score = double.Parse(Console.ReadLine());

    if (score >= 2.00 && score <= 2.99)
    {
        group1++;
    }
    else if (score >= 3.00 && score <= 3.99)
    {
        group2++;
    }
    else if (score >= 4.00 && score <= 4.99)
    {
        group3++;
    }
    else if (score >= 5.00)
    {
        group4++;
    }
    avaregeScore = avaregeScore + score;
}

double group1Percentage = ((double)group1 / students) * 100;
double group2Percentage = ((double)group2 / students) * 100;
double group3Percentage = ((double)group3 / students) * 100;
double group4Percentage = ((double)group4 / students) * 100;

avaregeScore = avaregeScore / students;

Console.WriteLine($"Top students: {group4Percentage:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {group3Percentage:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {group2Percentage:f2}%");
Console.WriteLine($"Fail: {group1Percentage:f2}%");
Console.WriteLine($"Average: {avaregeScore:f2}");