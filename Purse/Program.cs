using System;
using CreditCard;
using Money;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardService creditCardService = new CreditCardService();
            MoneyService moneyService = new MoneyService();
            
            creditCardService.GetCreditCard();
            moneyService.GetMoney();

            Console.ReadKey();
        }
    }
}
