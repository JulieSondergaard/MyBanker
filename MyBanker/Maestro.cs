using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MyBanker
{
    public class Maestro : PaymentCard, IExperiation, IInternational
    {




        public Maestro(Account account, Person person) : base(account, person)
        {
            generatedNumberLength = 15;
            prefix = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"};
            GenerateCardNumber();
            CreateExpiryDate();

        }
        
        public bool AllowInternationalUsage()
        {
            return true;
        }


        public string CreateExpiryDate()
        {
            DateTime currentDate = DateTime.UtcNow;
            DateTime expiry = currentDate.AddYears(5).AddMonths(8);           
            expiryDate = expiry.ToString("MM/yy", CultureInfo.InvariantCulture);

            return expiryDate;
        }

        public override string GenerateCardNumber()
        {
            int rnd = random.Next(0, prefix.Length);

            cardNumber = prefix[rnd];

            for (int i = 0; i < generatedNumberLength; i++)
            {
                generatedNumber += random.Next(0, 10);
            }

            cardNumber += $"{generatedNumber}";

            return cardNumber;
        }

    }
}
