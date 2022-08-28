using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoesBudgeHouseODiscountSandwiches
{
    internal class MenuItem
    {
        public static Random Randomizer = new Random();
        public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };
        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            Description = $"{randomProtein} with {randomCondiment} on {randomBread}";

            decimal bucks = Randomizer.Next(2, 5);
            Console.WriteLine("bucks: " + bucks);
            decimal cents = Randomizer.Next(1,98);
            Console.WriteLine("cents: " + cents);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
        }
    }
}
