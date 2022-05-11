using System;
using System.Collections.Generic;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jules = new Person("Julie", 34);

            Account account = new Account(jules);

            

            Visa visa = new Visa(account, jules);
            DebetCard debetCard = new DebetCard(account, jules);
            Maestro maestro = new Maestro(account, jules);

            List<PaymentCard> cards = new List<PaymentCard>() {visa, debetCard, maestro };


            foreach (PaymentCard card in cards)
            {
                Console.WriteLine($"{card.GetType().Name}:\n{card.PrintCardInformation()}\n");
            }
           
           
        }

    }
}
