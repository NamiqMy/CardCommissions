using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public abstract class CardInfo
    {
        public string HolderName { get; set; }
        public string HolderSurname { get; set; }
        public int CVV { get; set; }
        public string CardNumber { get; set; }
        public decimal Balance { get; set; }

        public abstract void CashIn(decimal amount);
        public abstract bool Withdraw(decimal amount);
    }
}
