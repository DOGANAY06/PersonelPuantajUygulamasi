using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PersonelPuantajUygulamasi.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Personel> Personels { get; set; }  
        public DbSet<Departman> Departmans { get; set; }   
        public DbSet<Vardiya> Vardiyas { get; set; }
        //veritabanında bulunacak olan tablolar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=Localhost;port=3306;user=root;password=;database=NetCoreEntityFrameworkCodeFirstPersonelPuantaj")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
            //MySql server bağlama
        }
    }
}
