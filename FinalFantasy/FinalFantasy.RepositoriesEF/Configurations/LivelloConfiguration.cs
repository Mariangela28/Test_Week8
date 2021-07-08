using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    internal class LivelloConfiguration : IEntityTypeConfiguration<Livello>
    {
        public void Configure(EntityTypeBuilder<Livello> modelbuilder)
        {
            modelbuilder.ToTable("Livello");
            modelbuilder.HasKey("Id");
            modelbuilder.Property(l => l.Livello1).IsRequired().HasDefaultValue(20);
            modelbuilder.Property(l => l.Livello2).IsRequired().HasDefaultValue(40);
            modelbuilder.Property(l => l.Livello3).IsRequired().HasDefaultValue(60);
            modelbuilder.Property(l => l.Livello4).IsRequired().HasDefaultValue(80);
            modelbuilder.Property(l => l.Livello5).IsRequired().HasDefaultValue(100);

        }
    }
}