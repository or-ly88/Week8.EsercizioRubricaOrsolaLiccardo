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
    internal class IndirizzoConfiguration : IEntityTypeConfiguration<Indirizzo>
    {
        public void Configure(EntityTypeBuilder<Indirizzo> builder)
        {
            builder.ToTable("Indirizzo");
            builder.HasKey(k => k.IndirizzoID);
            builder.Property(t => t.Tipologia).HasMaxLength(30).IsRequired();
            builder.Property(v => v.Via).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Città).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Città).HasMaxLength(30).IsRequired();
            builder.Property(c => c.CAP).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Provincia).HasMaxLength(30).IsRequired();
            builder.Property(n => n.Nazione).HasMaxLength(30).IsRequired();

            //relazione 1 a molti tra contatto e indirizzo
            builder.HasOne(c => c.Contatto).WithMany(i => i.Indirizzi).HasForeignKey(c => c.ContattoID);


        }
    }
}
