using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleStaff
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            
            #region Анонимные типы

            // Анонимный тип 
            //var item = new { Name = "Tomas", Age = 22};
            //var item2 = new {Name = "Jonny", Age = 33, Year = 200};


            //var Name = "Jon";
            //var Age = 22;

            //var person = new {Name, Age};
            //Console.WriteLine($"{person.Name}\n{person.Age}");
            //Console.WriteLine($"Hello, {item.Name} Your Age is {item.Age}");
            //Console.WriteLine($"Hello, {item.Name} Your Age is {item.Age} your Year{item2.Year}");

            //var list = new[]
            //{
            //    new {Name = "Tomas", Age = 33},
            //    new {Name = "Jon", Age = 44}
            //};
            //foreach (var VARIABLE in list)
            //{
            //    Console.WriteLine(VARIABLE.Name + VARIABLE.Age);
            //}

            #endregion

            #region Инициализация коллекций 2

            //var ShopCar = new ShopCar()
            //{
            //    cars =
            //    {
            //        new Car("Nissan", 2006, 15.000f),
            //        new Car("BMW", 1999, 25.000f),
            //        new Car("Volvo", 2000, 45.000f),
            //    }
            //};
            //foreach (var resultCar in ShopCar.cars)
            //{
            //    Console.WriteLine(resultCar.Marka, resultCar.Price, resultCar.Year);
            //}

            #endregion

            #region Инициализация коллекций словарь Dictionary

            //var dict = new Dictionary<string, int>
            //{
            //    {"Tomas", 22 },
            //    {"Jimmy", 33 },
            //    {"Riko", 22 }
            //};
            //foreach (var VARIABLE in dict)
            //{
            //    Console.WriteLine(VARIABLE.Value + " " +   VARIABLE.Key);
            //}

            #endregion

            #region Инициализация коллекций

            // Инициализация коллекций
            //var classroom = new Classroom()
            //{
            //  Staves =
            //  {
            //      new Staff("Tomas"),
            //      new Staff("Jon"),
            //      new Staff("Boris")
            //  }
            //};
            // 2 выриант
            //var classroom2 = new Classroom();
            //{
            //    classroom2.Staves.Add(new Staff("Jon"));
            //    classroom2.Staves.Add(new Staff("Jimmy"));
            //}

            //foreach (var VARIABLE in classroom2.Staves)
            //{
            //    Console.WriteLine(VARIABLE);
            //}

            #endregion

            #region Инициализация объектов

            //// Инициализатор обьектов 1 способ
            //var StaffStudent = new StaffStudent()
            //{
            //    Name = "Tomas",
            //    Age = 33

            //};
            //// Инициализатор обьектов можно и так  2 способ
            //var employee2 = new StaffStudent();
            //employee2.Age = 33;
            //employee2.Name = "Jon";

            //var employee3 = new StaffStudent() {Name = "Sem", Age = 52}.ToString().ToUpper();

            //var employee4 =new StaffStudent("Jimmy") {Age = 30};
            //var Employee5 = new StaffStudent
            //{
            //    Name = "Gurt",
            //    Age = 22
            //};

            //Console.WriteLine(employee4);

            #endregion

            #region Виртуальный метод

            //var animals = new List<Animal>();
            //{
            //    animals.Add(new Dog("Tom", 12, 12.4f));
            //    animals.Add(new Cat("Jon", 15, 10.5f));
            //    foreach (var result in animals)
            //    {
            //        result.ShowAnimals();
            // }
            // }

            #endregion

            #region Конструктор

            //Staff Petr = new Staff("Petr", 1, true);
            //Console.WriteLine(Petr);
            //Staff Tomas = new Staff("Tomas", 2, false);
            //Console.WriteLine(Tomas);
            //Staff Jon = new Staff("Jon");
            //Console.WriteLine(Jon);
            //Show();

            #endregion

            #region Structura

            //User college = new User("Tomas", 33, 1);
            //Console.WriteLine(college);

            #endregion

            Show();


            Console.ReadLine();
        }


        #region Запросы  Linq №1

        //public static void Staff()
        //{
        //    //Напишите команду SELECT, которая бы вывела номер заказа, сумму, и дату для всех строк из таблицы Заказов.
        //    using (AppStafContext db = new AppStafContext())
        //    {
        //        //    var Query = db.orderses.Select(t => new
        //        //    {
        //        //        NumberOrder = t.onum,
        //        //        Sum = t.amt,
        //        //        date = t.odate.Date.ToString()
        //        //    });
        //        //    foreach (var result in Query)
        //        //    {
        //        //        Console.WriteLine($"\nНомер заказа:{result.NumberOrder}\nСумма:{result.Sum}\nДата:{result.date}");
        //        //    }


        // }
        // }

        #endregion

        private static void Show()
        {
            #region Метод Join

            //using var db = new AppStafContext();
            //var Query = db.orderses.Join(db.salespeoples, orders => orders.Id, salespeople => salespeople.Id,
            //    (orders, salespeople) => new
            //    {
            //        Номер_заказа = salespeople.snum,
            //        Номер_продавца = orders.cnum,
            //        Коммисионные = salespeople.comm * 12

            //    });

            //foreach (var result in Query)
            //{
            //    Console.WriteLine($"\nНомер заказа:" +
            //        $"{result.Номер_заказа}\nНомер продавца:" +
            //        $"{result.Номер_продавца}\nКомиссионные: %" +
            //        $"{result.Коммисионные}");
            //}

            #endregion

            #region Запросы SQL/Linq №2

            //Напишите запрос, который вывел бы все строки из таблицы Заказчиков, для которых номер продавца равен 1001

            //    var Query = db.orderses.Select(t => new
            //    {
            //        t.snum,
            //        t.amt,
            //        t.cnum,
            //        t.odate,
            //        t.onum
            //    });
            //    foreach (var VARIABLE in Query.Where(t=>t.snum==1007))
            //    {
            //        Console.WriteLine($"{VARIABLE.snum}-{VARIABLE.amt}-{VARIABLE.cnum}-{VARIABLE.odate}-{VARIABLE.onum}");
            //    }

            //Напишите запрос, который вывел бы таблицу со столбцами в следующем порядке: city, sname, snum, comm.
            //var Query = db.salespeoples.Select(t => new
            //{
            //    t.sity,
            //    t.sname,
            //    t.snum,
            //    t.comm
            //});
            //foreach (var VARIABLE in Query)
            //{
            //    Console.WriteLine($"{VARIABLE.sity}-{VARIABLE.sname}-{VARIABLE.snum}-{VARIABLE.}");
            //}
            //Напишите команду SELECT которая вывела бы оценку (rating), сопровождаемую именем каждого заказчика в San Jose.
            //var query = db.customerses.Where(r => r.sity =="San Jose").ToArray();
            //foreach (var u in query)
            //{
            //    Console.WriteLine($"\nИмя:{u.cname}\nОценка:{u.rating}");  
            //}

            #endregion

            #region Запросы Distinct №3

            //var Query = db.orderses.Select(t => t.snum).Distinct().ToList();
            //foreach (var result in Query)
            //{
            //    Console.WriteLine($"\nСумма всех продавцов:{result}");   
            //}

            #endregion

            #region Запросы linq №4

            //var Query = db.orderses.Where(t => t.amt > 1000).ToList();
            //{
            //    foreach (var VARIABLE in Query)
            //    {
            //        Console.WriteLine($"{VARIABLE}");
            //    }
            //}

            #endregion

            #region SQL №4

            //    var Query = db.salespeoples.Where(t => t.comm > 0.1).ToList();
            //    foreach (var VARIABLE in Query)
            //    {
            //        Console.WriteLine($"\nИмя продавца:{VARIABLE.sname}\nГород :{VARIABLE.sity}");
            //    }

            #endregion

            #region StartWith #5

            //var Query = db.customerses.Where(t => t.cname.StartsWith("H") || t.cname.StartsWith("C")).ToList();
            //foreach (var VARIABLE in Query)
            //{
            //    Console.WriteLine(VARIABLE.cname);
            //}

            #endregion

            #region Linq №6

            //Напишите запрос который выберет всех пользователей чьи имена начинаются с буквы C
            //var Query = db.customerses.Where(t => t.cname.StartsWith("C")).ToList();
            //foreach (var result in Query)
            //{
            //    Console.WriteLine(string.Format($"{result.cname}"));
            //}

            #endregion

            #region Linq StartWitch("T")

            // Напишите запрос, который бы выбирал заказчиков в алфавитном порядке, чьи имена начинаются с буквы G.
            //var Query = db.customerses.Where(t => t.cname.StartsWith("C")).ToList();
            //foreach (var VARIABLE in Query)
            //{
            //    Console.WriteLine($"{VARIABLE.cname}"); 
            //}

            #endregion

            #region BD

            //// using (AppStafContext db = new AppStafContext())
            // {
            //    #region OrderbyDesending

            //    //var query = db.customerses.OrderByDescending(t => t.rating).ToList();
            //    //foreach (var result in query)
            //    //{
            //    //    Console.WriteLine($"Рейтинг:{result.rating}\nИмя заказчика:{result.cname}");
            //    //}

            //    #endregion
            //    #region Join

            //var Queru = db.orderses.Join(db.customerses, orders => orders.cnum, customers => customers.cnum,
            //    (orders, customers) => new
            //    {
            //        orders.onum,
            //        customers.cname,
            //        customers.cnum,

            //    });
            //    //foreach (var result in Queru)
            //    //{
            //    //    Console.WriteLine($"\n{result.onum}\n{result.cname}");
            //    //}

            //    #endregion
            //    #region Анонимные типы

            //    //   var Query = from item in db.orderses select new {id = item.snum, Name = item.cnum};
            //    //   foreach (var VARIABLE in Query)
            //    //   {
            //    //       Console.WriteLine(VARIABLE.Name +  VARIABLE.id);
            //    //   }

            //    //var Query = from item in db.customerses select new {Sity = item.sity, Name = item.cname};
            //    //foreach (var VARIABLE in Query)
            //    //{
            //    //    Console.WriteLine($"\nГород:{VARIABLE.Sity}\nИмя:{VARIABLE.Name}");
            //    //}

            //    #endregion
            //    #region 2 варианта с form query linq

            //    //var query = from staff in db.customerses
            //    //    where staff.rating == 100
            //    //    select staff;
            //    //Console.ForegroundColor = ConsoleColor.White;
            //    //Console.WriteLine($"Выводит  имена (cname) и города (city) всех заказчиков с такой же оценкой (rating) как у Hoffmanа.");

            //    //foreach (var VARIABLE in query)
            //    //{
            //    //    Console.WriteLine();
            //    //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    //    Console.WriteLine($"\nИмя:{VARIABLE.cname}\nГород:{VARIABLE.sity}\nРэйтинг:{VARIABLE.rating}");
            //    //}

            //    // }
            //    //var Query = db.customerses.Where(t => t.rating == 100).ToList();
            //    //foreach (var VARIABLE in Query)
            //    //{
            //    //    Console.WriteLine($"{VARIABLE.cname}-{VARIABLE.sity}");
            //    //}

            //    #endregion


            //}

            #endregion


            using (var db = new AppStafContext())
            {
                #region Linq
                //var Query = db.customerses.Select(t => new
                //{
                //    Имя = t.cname,
                //    Номер = t.cnum,
                //    Город = t.sity
                //}).Where(t=>t.Город=="London").ToList();
                //foreach (var VARIABLE in Query)
                //{
                //    Console.WriteLine($"\nИмя:{VARIABLE.Имя}\nНомер:{VARIABLE.Номер}\nГород:{VARIABLE.Город}");
                //}
                #endregion
                #region Linq №1

                //var Query = db.salespeoples.Select(t => new
                //{
                //    Номер = t.snum,
                //    Город = t.sity
                //});
                //foreach (var VARIABLE in Query)
                //{
                //    Console.WriteLine($"\n{VARIABLE.Номер}\n{VARIABLE.Город}");
                //}
                #endregion



            }
        }
    }
}