using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleStaff
{
    public class Customers
    {
        public int Id { get; set; }
        public int cnum { get; set; } // уникальный номер назначенный каждому заказчику
        public string sity { get; set; } //расположение заказчика (город)

        public int
            rating { get; set; } // код, указывающий уровень предпочтения// данного заказчика перед другими. Более

        // высокий номер указывают на большее предпочтение (рейтинг);
        public int snum { get; set; } // номер продавца, назначенного этому заказчику (из таблицы Продавцов)
        public string cname { get; set; }
    }
}