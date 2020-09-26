using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PeopleStaff
{
    public class Staff
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Staff()
        {
        }

        public Staff(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}