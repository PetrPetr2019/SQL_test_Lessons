using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleStaff
{
    public class Account<T>
    {
        // Ограничение обобщений 
        public T  Id { get; set; }
        public int Sum { get; set; }

        public Account(T id)
        {
            Id = id;
        }

    }
}
