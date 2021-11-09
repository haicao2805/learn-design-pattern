using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class PateIsFavoriteFood : IFavoriteFoodStrategy
    {
        public string FavoriteFood()
        {
            return "Pate is the favorite food";
        }
    }
}
