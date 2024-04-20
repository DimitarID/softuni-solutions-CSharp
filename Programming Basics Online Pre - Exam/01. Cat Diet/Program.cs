int fats = int.Parse(Console.ReadLine());
int proteins = int.Parse(Console.ReadLine());
int carbohydrates = int.Parse(Console.ReadLine());
int caloriesTotal = int.Parse(Console.ReadLine());
int water = int.Parse(Console.ReadLine());

double fatsTotal = (((fats * 100) * caloriesTotal) / 9);
double proteinsTotal = (((proteins * 100) * caloriesTotal) / 4);
double carbohydratesTotal = (((carbohydrates * 100) * caloriesTotal) / 4);

double foodWeight = fatsTotal + proteinsTotal + carbohydratesTotal;

double caloriesPerGram = caloriesTotal / foodWeight;

double caloriesWater = (100 - water) * 100;

double caloriesPerGramWithoutWater = caloriesWater * caloriesPerGram;

Console.WriteLine($"{caloriesPerGramWithoutWater:f4}");