using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aiTrader
{
    public class TraderModel
    {
        private List<Transaction> transactions;
        private decimal balance;

        public TraderModel() 
        {
            transactions = new List<Transaction>()
            {
                new Transaction()
                {
                    TimeStamp= DateTime.Now,
                    Issuer  = "Sber",
                    Profit = 100,
                    Type = TransactionType.Profit
                },
                new Transaction()
                {
                    TimeStamp= DateTime.Now,
                    Issuer  = "Tinkoff",
                    Profit = 600,
                    Type = TransactionType.Profit
                },
                new Transaction()
                {
                    TimeStamp= DateTime.Now,
                    Issuer  = "Ford",
                    Profit = -300,
                    Type = TransactionType.Loss
                },
                new Transaction()
                {
                    TimeStamp= DateTime.Now,
                    Issuer  = "Tinkoff",
                    Profit = 200,
                    Type = TransactionType.Profit
                }
            };
        }

        public List<Transaction> Transactions { get { return transactions; } }
    }
}
