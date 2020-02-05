using Microsoft.EntityFrameworkCore;
using PracticaParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaParcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prestamos> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = JMP-PC\SQLEXPRESS; DataBase = PracticaParcial; Trusted_Connection = true");
        }
    }
}
