using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleStaff
{
    class Account
    {
        // Ограничение обобщений 
        public int  Id { get; set; }
        public int Sum { get; set; }

        public Account(int id)
        {
            Id = id;
        }

    }
}
