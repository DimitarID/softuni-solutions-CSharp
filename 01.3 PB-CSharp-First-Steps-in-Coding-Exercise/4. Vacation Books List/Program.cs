int numberOfPages = int.Parse(Console.ReadLine());
int pagesForHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int timeForBook = numberOfPages / pagesForHour;
int hoursPerDay = timeForBook / days;

Console.WriteLine(hoursPerDay);