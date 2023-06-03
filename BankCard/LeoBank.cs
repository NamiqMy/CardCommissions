using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class LeoBank : CardInfo
    {
        public override void CashIn(decimal amount)
        {
            Balance += amount;
        }

        public override bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }
    }
}
