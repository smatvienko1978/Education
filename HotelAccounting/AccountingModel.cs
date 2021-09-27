using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAccounting
{
    //создайте класс AccountingModel здесь
    public class AccountingModel: ModelBase
    {
        private double price;
        private int nightsCount;
        private double discount;
        private double total;
        public double Price 
        { 
            get { return price; } 
            set 
            {
                if (value >= 0) price = value;
                else throw new ArgumentException();
                CountTotal();
                Notify(nameof(Price));
            } 
        }
        public int NightsCount 
        {
            get { return nightsCount; } 
            set 
            {
                if (value > 0) nightsCount = value;
                else throw new ArgumentException();
                CountTotal();
                Notify(nameof(NightsCount));
            } 
        }
        public double Discount 
        {
            get { return discount; }
            set
            {
                discount = value;
                if (discount != ((-1) * Total / (Price * NightsCount) + 1) * 100)
                    CountTotal();
                Notify(nameof(Discount));
            } 
        }
        public double Total 
        {
            get { return total; } 
            set
            {
                if (value > 0) total = value;
                else throw new ArgumentException();
                if (total != Price * NightsCount * (1 - Discount / 100))
                    CountDiscount();
                Notify(nameof(Total));
            }
        }

        private void CountDiscount()
        {
            Discount = ((-1) * Total / (Price * NightsCount) + 1) * 100;
        }

        private void CountTotal()
        {
            Total = Price * NightsCount * (1 - Discount / 100);
        }
        public AccountingModel()
        {
            price = 0;
            nightsCount = 1;
            discount = 0;
            total = 0;
        }
    }
}
