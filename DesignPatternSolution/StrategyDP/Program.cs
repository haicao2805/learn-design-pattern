using System;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(new FishIsFavoriteFood());
            Console.WriteLine(cat.GetDescription());
            cat.SetFavoriteFoodStrategy(new PateIsFavoriteFood());
            Console.WriteLine(cat.GetDescription());
        }
    }
}
