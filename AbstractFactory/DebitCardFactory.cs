namespace AbstractFactory
{
    public class DebitCardFactory : CardFactory
    {
        public override ICard GetCard(string cardType)
        {
            if (cardType.Equals("Platinum"))
            {
                return new PlatinumCreditCard();
            }
            if (cardType.Equals("Titanium"))
            {
                return new TitaniumCreditCard();
            }
            if (cardType.Equals("CashBack"))
            {
                return new CashBackCreditCard();
            }
            else
            {
                return null;
            }
        }
    }
}