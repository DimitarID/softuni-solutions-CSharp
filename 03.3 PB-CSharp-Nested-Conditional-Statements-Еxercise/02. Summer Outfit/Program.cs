namespace _10._Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (timeOfDay == "Evening")
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (timeOfDay == "Morning")
            {
                if (temp >= 10 && temp <= 18)
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temp > 18 && temp <= 24)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp >= 25)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (temp >= 10 && temp <= 18)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp > 18 && temp <= 24)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temp >= 25)
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}