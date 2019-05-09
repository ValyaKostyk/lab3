using System;
using BuisnessCard;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            BuisnessCardService buisnessCardService = new BuisnessCardService();

            buisnessCardService.GetBuisnessCard();

            Console.ReadKey();
        }
    }
}
