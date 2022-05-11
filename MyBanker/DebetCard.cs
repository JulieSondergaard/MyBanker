using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBanker
{
    public class DebetCard : PaymentCard
    {

        
    
        public DebetCard(Account account, Person person) : base(account, person)
        {
            generatedNumberLength = 12;
            prefix = new string[] { "2400" };
            GenerateCardNumber();
        }

        public override string GenerateCardNumber()
        {
            cardNumber = prefix[0];
            for (int i = 0; i < generatedNumberLength; i++)
            {
                generatedNumber += random.Next(0, 10);
            }

            cardNumber += $"{generatedNumber}";

            return cardNumber;
        }

    }
}
