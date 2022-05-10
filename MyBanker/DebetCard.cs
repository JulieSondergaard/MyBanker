using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class DebetCard : PaymentCard, IExperiation, IInternational, ICredit
    {

        Account account;
        Person person;
        Random random = new Random();
        private new int generatedNumberLength = 12;
        private new string prefix = "2400";
        private string expiryDate = null;


        public DebetCard(Account account, Person person) : base(account, person)
        {
            this.account = account;
            this.person = person;

        }
        public bool AllowCredit()
        {
            return false;
        }

        public bool AllowInternationalUsage()
        {
            return false;
        }

        public string CreateExpiryDate()
        {           
            return expiryDate;
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

        public int GetMaximumCreditAmount()
        {
            return 0;
        }

        public bool HasExpiration()
        {
            return false;
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
    }
}
