using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.cs
{
    public class PotterShoppingCart_Class
    {
        public Dictionary<string, int> _PotterSet = new Dictionary<string, int>
        {
            ["HarryPotter_1"] = 0,
            ["HarryPotter_2"] = 0,
            ["HarryPotter_3"] = 0,
            ["HarryPotter_4"] = 0,
            ["HarryPotter_5"] = 0
        };

        public void BuyFirst(int v)
        {
            _PotterSet["HarryPotter_1"] += v;
        }

        public void BuySecond(int v)
        {
            _PotterSet["HarryPotter_2"] += v;
        }

        public void BuyThird(int v)
        {
            _PotterSet["HarryPotter_3"] += v;
        }

        public void BuyForth(int v)
        {
            _PotterSet["HarryPotter_4"] += v;
        }

        public void BuyFifth(int v)
        {
            _PotterSet["HarryPotter_5"] += v;
        }

        public decimal Caltotal()
        {
            var totalPay = 0;
            totalPay = getTotalMoney(_PotterSet.Values.ToArray());

            return totalPay;
        }

        private int getTotalMoney(int[] Values)
        {
            var Kind = 1;
            var totalPay = 0;

            while (Kind > 0)
            {
                Kind = 0;
                for (int i = 0; i <= Values.Length - 1; i++)
                {
                    if (Values[i] > 0)
                    {
                        Kind += 1;
                        Values[i] -= 1;
                    }
                }
                totalPay += getMoney(Kind);
            }
            return totalPay;
        }

        private int getMoney(int Kind)
        {
            switch (Kind)
            {
                case 1: //買1種=100
                    return 100;
                case 2: //買2種=190
                    return 190;
                case 3: //買3種=270
                    return 270;
                case 4: //買4種=320
                    return 320;
                case 5: //買5種=375
                    return 375;
                default:
                    return 0;
            }
        }
    }
}