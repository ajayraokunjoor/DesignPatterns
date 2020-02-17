using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Credit Card Details : Type = {0}, Limit = {1}, Annual Charge {2}",
                    creditCard.GetCardType(), creditCard.GetCreditLimit(), creditCard.GetAnnualCharge()); ;
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Credit Card Details : Type = {0}, Limit = {1}, Annual Charge {2}",
                    creditCard.GetCardType(), creditCard.GetCreditLimit(), creditCard.GetAnnualCharge()); ;
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("---------------------------");
            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Credit Card Details : Type = {0}, Limit = {1}, Annual Charge {2}",
                    creditCard.GetCardType(), creditCard.GetCreditLimit(), creditCard.GetAnnualCharge()); ;
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
