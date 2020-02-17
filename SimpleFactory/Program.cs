using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
#if problem
            string cardType = "MoneyBack";

            ICreditCard creditCard = null;
#endif

            //Moving the commented to a new class CreditCardFactory
#if code
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
#endif

#if !solution
            ICreditCard creditCard = CreditCardFactory.GetCreditCard("Platinum");
#endif
            if (creditCard != null)
            {
                Console.WriteLine("Card Type = {0}, Credit Limit = {1}, Annual Charge ={2}",
                creditCard.GetCardType(),
                creditCard.GetCreditLimit(),
                creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
