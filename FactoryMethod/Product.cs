using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public string GetCardType()
        {
            return "Money Back";
        }

        public int GetCreditLimit()
        {
            return 10000;
        }
    }

    class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 200;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 20000;
        }
    }

    class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 50;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 5000;
        }
    }
}
