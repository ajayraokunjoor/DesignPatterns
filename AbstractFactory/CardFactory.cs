namespace AbstractFactory
{
    public abstract class CardFactory
    {
        public abstract ICard GetCard(string cardType);
        public static CardFactory CreateCardFactory(string factoryType)
        {
            if (factoryType.Equals("Credit"))
            {
                return new CreditCardFactory();
            }
            else if (factoryType.Equals("Debit"))
            {
                return new DebitCardFactory();
            }
            else
                return null;
        }
    }
}
