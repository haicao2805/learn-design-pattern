using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class CatFoodIsFavoriteFood : IFavoriteFoodStrategy
    {
        public string FavoriteFood()
        {
            return "Cat Food is the favorite food";
        }
    }
}
