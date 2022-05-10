using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Person
    {
        private string name;
        private int age;
        private List<Account> accounts = new List<Account>();
        


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<Account> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
