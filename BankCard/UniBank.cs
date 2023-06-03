using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class UniBank : CardInfo
    {
        public override void CashIn(decimal amount)
        {
            Balance += amount;
        }

        public override bool Withdraw(decimal amount)
        {
            decimal commission = amount * 0.015m; // 1.5% commission
            decimal totalAmount = amount + commission;

            if (Balance >= totalAmount)
            {
                Balance -= totalAmount;
                return true;
            }

            return false;
        }
    }
}
