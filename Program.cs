using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4_Lec
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many transaction today?");
            string numStr = Console.ReadLine();
            int num = Int32.Parse(numStr);

            //create TransactionList obj here
            //call init 
            TransactionArray trans = new TransactionArray(num);
            //trans.Init(num);

            for (int i = 0; i < num; i++)
            {
                //creating an object (variable of a certain class type)
                Transaction transaction;
                transaction = new Transaction();

                transaction.setDate(new DateTime(2008, 6, 1));
                transaction.setVal(10.5f);

                trans.AddTransaction(transaction);
            }

            trans.Display();
        }
    }
}
