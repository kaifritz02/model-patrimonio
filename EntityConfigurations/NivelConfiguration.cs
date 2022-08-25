using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PatrimonioSenaiTaguatinga.Entities;

namespace PatrimonioSenaiTaguatinga.EntityConfigurations
{
    public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
    {
        public void Configure(EntityTypeBuilder<Nivel> builder)
        {
            builder.ToTable("Nivel");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Nome).IsRequired().HasMaxLength(50);
        }
    }
}