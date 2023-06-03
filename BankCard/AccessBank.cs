using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class AccessBank : CardInfo
    {
        public override void CashIn(decimal amount)
        {
            decimal commission = amount * 0.003m; // 0.3% commission
            decimal totalAmount = amount - commission;

            Balance += totalAmount;
        }

        public override bool Withdraw(decimal amount)
        {
            decimal commission = amount * 0.016m; // 1.6% commission
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
