using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    public static class OnlineStore
    {
        public static List<double> ListOfPurchasePrices()
        {
            List<double> purchasePrices = new List<double> { 10.50, 25.00, 15.75 };
            List<double> markedUpPrices = new List<double>();

            foreach (double price in purchasePrices)
            {
                markedUpPrices.Add(price * 1.18);
            }
            return markedUpPrices;
        }

    }
}
    
