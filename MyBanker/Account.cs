using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Account
    {
        Random random = new Random();
        protected string accountNumber;
        protected string regNumber = "3520";
        private string generatedNumber;
        List<PaymentCard> cards = new List<PaymentCard>();
        Person person;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string RegNumber
        {
            get { return regNumber; }
            set { regNumber = value; }
        }

        public Account(Person person)
        {
            this.person = person;
        }

        public string GenerateAccountNumber()
        {
            int length = 10;
            

            for (int i = 0; i < length; i++)
            {
                generatedNumber += random.Next(0, length);
                

            }

            accountNumber = $"{regNumber}{generatedNumber}";

            return accountNumber;
        }


    }
}
