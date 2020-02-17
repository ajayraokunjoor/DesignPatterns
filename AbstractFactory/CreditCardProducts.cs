using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PlatinumCreditCard : CreditCard
    {
        public PlatinumCreditCard()
        {
            System.Console.WriteLine("Platinum Credit Card......");
        }

        public override int GetAnnualCharge()
        {
            return 1500;
        }
        public new int GetCreditLimit()
        {
            return 150000;
        }
    }
    public class TitaniumCreditCard : CreditCard
    {
        public TitaniumCreditCard()
        {
            System.Console.WriteLine("Titanium Credit Card......");
        }
    }
    public class CashBackCreditCard : CreditCard
    {
        public CashBackCreditCard()
        {
            System.Console.WriteLine("CashBack Credit Card......");
        }
    }
}
