using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    internal class GiocatoreConfiguration : IEntityTypeConfiguration<Giocatore>
    {
        public void Configure(EntityTypeBuilder<Giocatore> modelbuilder)
        {
            modelbuilder.ToTable("Giocatore");
            modelbuilder.HasKey(n => n.NickName);
            modelbuilder.Property("NickName").IsRequired();
            modelbuilder.Property("Password").IsRequired();
        }
    }
}