using System;
using CreditCard;
using Money;
using BuisnessCard;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardService creditCardService = new CreditCardService();
            MoneyService moneyService = new MoneyService();
            BuisnessCardService buisnessCardService = new BuisnessCardService();
            
            creditCardService.GetCreditCard();
            moneyService.GetMoney();
            buisnessCardService.GetBuisnessCard();

            Console.ReadKey();
        }
    }
}
