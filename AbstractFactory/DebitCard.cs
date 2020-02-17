using System;

namespace AbstractFactory
{
    public class DebitCard : ICard
    {
        public int GetAnnualCharge()
        {
            throw new NotImplementedException();
        }

        public string GetCardType()
        {
            throw new NotImplementedException();
        }

        public int GetCreditLimit()
        {
            throw new NotImplementedException();
        }
    }
}
