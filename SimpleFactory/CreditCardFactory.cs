namespace SimpleFactory
{
    class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;

            if (cardType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                creditCard = new Platinum();
            }
            //Adding a new type of product leads to building the whole class - voilates open closed priciple &
            //there is tight coupling between product types and factory class
            else if (cardType == "SimplySave")
            {
                creditCard = new Platinum();
            }
            return creditCard;           
        }
    }
}
