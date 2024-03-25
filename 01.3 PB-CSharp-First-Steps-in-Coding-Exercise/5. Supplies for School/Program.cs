int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int liters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pensPrice = pens * 5.80;
double markersPrice = markers * 7.20;
double litersPrice = liters * 1.20;

double totalPrice = (pensPrice + markersPrice + litersPrice) * ((100.0 - discount) / 100);

Console.WriteLine(totalPrice);