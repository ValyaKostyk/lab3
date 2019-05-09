using System;
using Money;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyService moneyService = new MoneyService();

            moneyService.GetMoney();

            Console.ReadKey();
        }
    }
}
