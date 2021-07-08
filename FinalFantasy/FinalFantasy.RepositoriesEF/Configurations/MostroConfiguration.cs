using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    internal class MostroConfiguration : IEntityTypeConfiguration<Mostro>
    {
        public void Configure(EntityTypeBuilder<Mostro> modelbuilder)
        {
            modelbuilder.ToTable("Mostro");
            modelbuilder.HasKey(i => i.Id);
            modelbuilder.Property("TipologiaMostro").IsRequired();
        }
    }
}