using FeriadosAPI.Data.Maps;
using FeriadosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<FeriadoNacional> FeriadosNacionais { get; set; }
        public DbSet<FeriadoEstadual> FeriadosEstaduais { get; set; }
        public DbSet<FeriadoMunicipal> FeriadosMunicipais { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlite("DataSource=api.db;Cache=Shared");
        //    //optionsBuilder.UseSqlServer("Server=PLANTDEV;Database=FuncionalPlant;User ID=appFuncPlant;Password=@Plant2017");
        //    optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ControlePessoal2;User ID=sa;Password=q1w2e3r4t5");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FeriadoNacionalMap());
            modelBuilder.ApplyConfiguration(new FeriadoEstadualMap());
            modelBuilder.ApplyConfiguration(new FeriadoMunicipalMap());

            modelBuilder.Entity<FeriadoNacional>()
                .HasData(
                    new FeriadoNacional { Id = 1, Data = new DateTime(1900, 1, 1), Nome = "Confraternização Universal", FixoMovel = "F" },
                    new FeriadoNacional { Id = 2, Data = new DateTime(1900, 4, 21), Nome = "Tiradentes", FixoMovel = "F" },
                    new FeriadoNacional { Id = 3, Data = new DateTime(1900, 5, 1), Nome = "Dia do Trabalhador", FixoMovel = "F" },
                    new FeriadoNacional { Id = 4, Data = new DateTime(1900, 9, 7), Nome = "Independência", FixoMovel = "F" },
                    new FeriadoNacional { Id = 5, Data = new DateTime(1900, 10, 12), Nome = "Nossa Senhora Aparecida", FixoMovel = "F" },
                    new FeriadoNacional { Id = 6, Data = new DateTime(1900, 11, 2), Nome = "Finados", FixoMovel = "F" },
                    new FeriadoNacional { Id = 7, Data = new DateTime(1900, 11, 15), Nome = "Proclamação da República", FixoMovel = "F" },
                    new FeriadoNacional { Id = 8, Data = new DateTime(1900, 12, 25), Nome = "Natal", FixoMovel = "F" }
                );

            modelBuilder.Entity<FeriadoEstadual>()
                .HasData(
                    new FeriadoEstadual { Id = 1, Uf = "SP", Data = new DateTime(1900, 7, 9), Nome = "Revolução Constitucionalista de 1932", FixoMovel = "F" },
                    new FeriadoEstadual { Id = 2, Uf = "RJ", Data = new DateTime(1900, 4, 23), Nome = "Dia de São Jorge", FixoMovel = "F" },
                    new FeriadoEstadual { Id = 3, Uf = "RJ", Data = new DateTime(1900, 11, 20), Nome = "Dia da Consciência Negra", FixoMovel = "F" },
                    new FeriadoEstadual { Id = 4, Uf = "MG", Data = new DateTime(1900, 4, 21), Nome = "Data Magna de Minas Gerais", FixoMovel = "F" }
                );

            modelBuilder.Entity<FeriadoMunicipal>()
                .HasData(
                    new FeriadoMunicipal { Id = 1, Uf = "SP", Cidade = "Guarulhos", Data = new DateTime(1900, 12, 8), Nome = "Aniversário de Guarulhos", FixoMovel = "F" },
                    new FeriadoMunicipal { Id = 2, Uf = "SP", Cidade = "São Paulo", Data = new DateTime(1900, 1, 25), Nome = "Aniversário de São Paulo", FixoMovel = "F" }
                );
        }
    }
}
