using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface ICredit
    {
        public bool AllowCredit();

        public int GetMaximumCreditAmount();
    }
}
