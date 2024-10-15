using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4_Lec
{
    internal class TransactionList
    {
        //Data
        private List<Transaction> transactions;

        //constructor -
        //1) no return type
        //2) name is that of the class
        //3) usually used for initialization
        public TransactionList()
        {
            transactions = new List<Transaction>();
        }
         
        public TransactionList(int numm)
        { 
            transactions = new List<Transaction>(); 
        }

        //operations 
        public void Init(int num)
        {
            transactions = new List<Transaction>(num);
        }

        //how to complete this?????
        public void Add(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public void Display()
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine(transactions[i].getVal());
            }
        }
    }
}
