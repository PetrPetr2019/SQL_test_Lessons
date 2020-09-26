using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PeopleStaff
{
    public class AppStafContext : DbContext
    {
        internal DbSet<Salespeople> salespeoples { get; set; }
        internal DbSet<Customers> customerses { get; set; }
        internal DbSet<Orders> orderses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StafPeopleTest;Trusted_Connection=true;");
        }
    }
}