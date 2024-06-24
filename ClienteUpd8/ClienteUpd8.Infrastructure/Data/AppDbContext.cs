using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClienteUpd8.Domain.Entities;

namespace ClienteUpd8.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(p => p.Id);

            modelBuilder.Entity<Cliente>().HasData(new Cliente() { Nome="Andre Sombra"
                , DataNascimento= new DateTime(1975,3,31)
                , Cidade="Fortaleza"
                , Estado="Ceara"
                , Endereco="Rua Nove, 40"
                , CPF="580.941.213-00"
                , Sexo="M"});

            base.OnModelCreating(modelBuilder);
            // Configurações adicionais do modelo

        }
    }
}
