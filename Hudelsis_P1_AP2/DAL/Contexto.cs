using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hudelsis_P1_AP2.Models;

namespace Hudelsis_P1_AP2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Producto.db");

        }

    }
    
}
