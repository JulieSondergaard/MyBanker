using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Visa : PaymentCard, IExperiation, IInternational, ICredit
    {
        Account account;
        Person person;
        Random random = new Random();
        private new int generatedNumberLength = 15;
        private new string prefix = "4";
        private string expiryDate;
     


        public Visa(Account account, Person person): base(account, person)
        {
            this.account = account;
            this.person = person;

        }


        public bool AllowInternationalUsage()
        {
            return true;
        }
        public bool HasExpiration()
        {
            return true;
        }

        public string CreateExpiryDate()
        {
            
            DateTime currentDate = DateTime.UtcNow;
            DateTime fiveYearsFromNow = currentDate.AddYears(5);
            expiryDate = fiveYearsFromNow.ToString("MM-yyyy");
            
            return expiryDate;
            
        }

        public bool AllowCredit()
        {
            return true;
        }

        public int GetMaximumCreditAmount()
        {
            return 20000;
        }

        public override string PrintCardInformation()
        {
            string PrintCardInformation = 
                $"{cardNumber}\n" +
                $"{person.Name}\n" +
                $"{expiryDate}\n" +
                $"{account.AccountNumber}\n" +
                $"{account.RegNumber}";

            return PrintCardInformation;
        }

        public override string GenerateCardNumber()
        {
            
            for (int i = 0; i < generatedNumberLength; i++)
            {
                generatedNumber += random.Next(0, 10);
            }

            cardNumber = $"{prefix}{generatedNumber}";

            return cardNumber;
        }




    }
}
