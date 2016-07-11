using System;
using System.Collections.Generic;


namespace PotterShoppingCart.cs
{
    public class PotterShoppingCart_Class
    {
        public Dictionary<string, int> _PoterSet = new Dictionary<string, int>
        {
            ["HarryPoter_1"] = 0,
            ["HarryPoter_2"] = 0,
            ["HarryPoter_3"] = 0,
            ["HarryPoter_4"] = 0,
            ["HarryPoter_5"] = 0
        };


        public void BuyFirst(int v)
        {
            _PoterSet["HarryPoter_1"] += v;
        }

        public object Caltotal()
        {
            return 0;
        }
    }
}