using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class FishIsFavoriteFood : IFavoriteFoodStrategy
    {
        public string FavoriteFood()
        {
            return "Fish is the favorite food";
        }
    }
}
