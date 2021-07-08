using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    internal class EroeConfiguration : IEntityTypeConfiguration<Eroe>
    {
        public void Configure(EntityTypeBuilder<Eroe> modelbuilder)
        {
            modelbuilder.ToTable("Eroe");
            modelbuilder.HasKey(i => i.Id);
            
            modelbuilder.Property("TipologiaEroe").IsRequired();
            modelbuilder.Property("Giocatore").IsRequired();
            

            modelbuilder.HasOne(g => g.Giocatore).WithMany(e => e.Eroi).HasForeignKey(g => g.GiocatoreId);
            
        }
    }
}