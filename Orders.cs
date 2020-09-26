using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeopleStaff
{
    public class Orders
    {
        public int Id { get; set; }
        public int onum { get; set; } // уникальный номер данный каждому приобретению;
        public double amt { get; set; } //значение суммы приобретений;

        public DateTime odate { get; set; } //дата приобретения;
        public int cnum { get; set; } // номер заказчика делающего приобретение (из таблицы Заказчиков);
        public int snum { get; set; } //номер продавца продающего приобретение (из таблицы Продавцов)
    }
}