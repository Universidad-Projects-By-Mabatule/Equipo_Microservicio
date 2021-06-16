using EquipoAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoAPI.Data
{
    public class EquipoDbContext:DbContext
    {
        public DbSet<EquipoEntity> Equipos { get; set; }
        public EquipoDbContext(DbContextOptions<EquipoDbContext> options)
                  : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EquipoEntity>().ToTable("Torneos");
            modelBuilder.Entity<EquipoEntity>().Property(t => t.Id).ValueGeneratedOnAdd();

            //dotnet tool install --global dotnet-ef
            //dotnet ef migrations add InitialCreate
            //dotnet ef database update
        }
    }
}
