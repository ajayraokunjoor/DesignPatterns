namespace AbstractFactory
{
    public class CreditCard : ICard
    {
        public virtual int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Credit Card";
        }

        public virtual int GetCreditLimit() 
        {
            return 100000;
        }
       
    }
}
