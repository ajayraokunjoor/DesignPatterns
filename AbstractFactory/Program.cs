using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ICard card = null;
            CardFactory cardFactory = null;

            cardFactory = CardFactory.CreateCardFactory("Credit");

            card = cardFactory.GetCard("Platinum");
            System.Console.WriteLine("{0} - {1} - {2}",card.GetCardType(), card.GetCreditLimit(),card.GetAnnualCharge());

            cardFactory = CardFactory.CreateCardFactory("Debit");
            System.Console.WriteLine("Card Factory Type - {0}", cardFactory.GetType().Name);

            card = cardFactory.GetCard("CashBack");
            System.Console.WriteLine("{0} - {1} - {2}", card.GetCardType(), card.GetCreditLimit(), card.GetAnnualCharge());
        }
    }
}
