using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.Models;

namespace Week8.RepositoryEntityFrameWork.Configuration 
{
    internal class ContattoConfiguration : IEntityTypeConfiguration<Contatto>
    {
        public void Configure(EntityTypeBuilder<Contatto> builder)
        {
            builder.ToTable("Contatto");
            builder.HasKey(k => k.ContattoID);
            builder.Property(n => n.Nome).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Cognome).HasMaxLength(30).IsRequired();

           //Relazione 1 a molti tra contatto e indirizzi
            builder.HasMany(i => i.Indirizzi).WithOne(c => c.Contatto).HasForeignKey(c => c.ContattoID); ;

            
        }
    }
}
