using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class Cat
    {
        private IFavoriteFoodStrategy _favoriteFoodStrategy;
        private string _description;

        public Cat(IFavoriteFoodStrategy favoriteFoodStrategy)
        {
            _favoriteFoodStrategy = favoriteFoodStrategy;
        }
        public void SetFavoriteFoodStrategy(IFavoriteFoodStrategy value)
        {
            _favoriteFoodStrategy = value;
        }

        public IFavoriteFoodStrategy GetFavoriteFoodStrategy()
        {
            return _favoriteFoodStrategy;
        }

        public string GetDescription()
        {
            _description = _favoriteFoodStrategy.FavoriteFood();
            return _description;
        }
    }
}
