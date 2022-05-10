using System;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jules = new Person("Julie", 34);

            Account account = new Account(jules);
           account.GenerateAccountNumber();
            
            Visa visa = new Visa(account, jules);
            DebetCard debetCard = new DebetCard(account, jules);

            if (debetCard is DebetCard)
            {
                debetCard.GenerateCardNumber();
                Console.WriteLine($"Debet card:\n{debetCard.PrintCardInformation()}");
            }

            Console.WriteLine();
            
            if (visa is Visa)
            {
                if (visa.HasExpiration())
                {
                    visa.CreateExpiryDate();
                }
                visa.GenerateCardNumber();
                Console.WriteLine($"Visa:\n{visa.PrintCardInformation()}");
            }
            

            
             

            
        }
    }
}
