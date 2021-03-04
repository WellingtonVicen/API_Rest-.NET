using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseMySqlIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Nome)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("nome")
                    .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Senha)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("senha")
                    .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.Email)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasColumnName("email")
                    .HasColumnType("VARCHAR(180)");
        }
    }
}
