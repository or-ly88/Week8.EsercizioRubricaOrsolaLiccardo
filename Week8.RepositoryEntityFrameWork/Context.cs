using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.Models;
using Week8.RepositoryEntityFrameWork.Configuration;

namespace Week8.RepositoryEntityFrameWork
{
    internal class Context : DbContext
    {
        //Elenco i Dbset ovvero le tabelle/entità in gioco
        public DbSet<Contatto> Contatti { get; set; }
        public DbSet<Indirizzo> Indirizzi { get; set; }

        //costruttore vuoto
        public Context()
        {

        }

        //costruttore con option
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RubricaEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Contatto
            modelBuilder.ApplyConfiguration<Contatto>(new ContattoConfiguration());
            //Indirizzo
            modelBuilder.ApplyConfiguration<Indirizzo>(new IndirizzoConfiguration());
 

        }

    }
}
