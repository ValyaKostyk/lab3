using System;
using CreditCard;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardService creditCardService = new CreditCardService();

            creditCardService.GetCreditCard();

            Console.ReadKey();
        }
    }
}
