using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4_Lec
{
    internal class TransactionArray
    {
        //data
        private Transaction[] transactions; // transactions is an Array object 
        private int numTransactions;

        public TransactionArray()
        {
            transactions = new Transaction[10];
        }

        public TransactionArray(int num)
        {
            transactions = new Transaction[num];
        }

        public void Init(int num) 
        {
            transactions = new Transaction[num];
        }
        public void AddTransaction(Transaction transaction)
        {
            transactions[numTransactions++] = transaction;
        }

        public void Display()
        {
            for (int i = 0; i < numTransactions; i++)
            {
                Console.WriteLine(transactions[i].getVal());
            }
        }
    }
}
