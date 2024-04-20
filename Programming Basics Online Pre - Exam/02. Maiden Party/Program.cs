double partyPrice = double.Parse(Console.ReadLine());
int letters = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int keychain = int.Parse(Console.ReadLine());
int caricature = int.Parse(Console.ReadLine());
int surprise = int.Parse(Console.ReadLine());

double finalProfit = 0;

double profit = letters * 0.60 + roses * 7.20 + keychain * 3.60 + caricature * 18.20 + surprise * 22;
int totalItems = letters + roses + keychain + caricature + surprise;
finalProfit = profit * 0.9;

if (totalItems >= 25)
{
    finalProfit = finalProfit * 0.65;
}

if (finalProfit >= partyPrice)
{
    double output = finalProfit - partyPrice;  
    Console.WriteLine($"Yes! {output:f2} lv left.");
}
else
{
    double output = partyPrice - finalProfit;
    Console.WriteLine($"Not enough money! {output:f2} lv needed.");
}