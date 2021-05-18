using Microsoft.EntityFrameworkCore;
using RegistroCompleto_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RegistroCompleto_Blazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data\RegistroBlazor.db");
        }
    }
}
