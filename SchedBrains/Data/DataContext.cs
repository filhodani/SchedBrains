using Microsoft.EntityFrameworkCore;
using SchedBrains.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Data
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=BDSchedBrains; Integrated Security=SSPI");
        }

        public DbSet<Tarefa> TBTarefa { get; set; }
        public DbSet<Evento> TBEvento { get; set; }
        public DbSet<Contato> TBContato { get; set; }
    }
}
