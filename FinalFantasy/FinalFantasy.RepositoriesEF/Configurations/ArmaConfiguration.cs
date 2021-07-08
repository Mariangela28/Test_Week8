using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    internal class ArmaConfiguration : IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> modelbuilder)
        {
            
        }
    }
}