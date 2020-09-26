
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleStaff
{
    internal class Transaction<T>where T:Account<int>
    {
        //добавил функцию
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }
       
        public  void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет:{FromAccount.Id}:{FromAccount.Sum}$счет:{ToAccount.Id}:{ToAccount.Sum}");
            }
            else
            {
                Console.WriteLine($"не достаточно денег:{FromAccount.Id}");
            }
        }

    }
}
