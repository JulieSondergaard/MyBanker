using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Visa : PaymentCard, IExperiation, IInternational, ICredit
    {
   


        public Visa(Account account, Person person): base(account, person)
        {
            prefix = new string[] { "4" };
            generatedNumberLength = 15;
            CreateExpiryDate();
            GenerateCardNumber();
        }


        public bool AllowInternationalUsage()
        {
            return true;
        }


        public string CreateExpiryDate()
        {
            
            DateTime currentDate = DateTime.UtcNow;
            DateTime fiveYearsFromNow = currentDate.AddYears(5);
            expiryDate = fiveYearsFromNow.ToString("MM/yy", CultureInfo.InvariantCulture);
            
            return expiryDate;
            
        }



        public int GetMaximumCreditAmount()
        {
            return 20000;
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
