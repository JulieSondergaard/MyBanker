using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
   public abstract class PaymentCard
    {
        protected Random random = new Random();
        protected string cardNumber;
        protected string[] prefix;
        protected string expiryDate;
        protected string generatedNumber;
        protected int generatedNumberLength;
        Account account;
        Person person;

        public PaymentCard(Account account, Person person)
        {
            this.account = account;
            this.person = person;
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }


        public abstract string GenerateCardNumber();

        public virtual string PrintCardInformation() 
        {
            string PrintCardInformation =
                $"Card number: {cardNumber}\n" +
                $"Name: {person.Name}\n" +
                $"Expiry: {expiryDate}\n" +
                $"Account number: {account.AccountNumber}\n" +
                $"Registration number: {account.RegNumber}";

            return PrintCardInformation;
        }

    }
       
        

    
}
