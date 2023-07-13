using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефонна_книжка__WinForms_EF_
{
    public class MyApplicationContext : DbContext
    {
        public DbSet<PhoneContact> PhoneContacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=my_db;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
