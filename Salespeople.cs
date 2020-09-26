using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleStaff
{
    public class Salespeople
    {
        public int Id { get; set; }
        public int snum { get; set; } // Уникальный номер назначенный каждому продавцу
        public string sname { get; set; } // Имя продавца
        public string sity { get; set; } // Город
        public double comm { get; set; } // комиссионные продавцов в десятичной форме.
    }
}