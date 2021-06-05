using Diary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diary.Persistence.Configurations
{
    class MemoryConfiguration : IEntityTypeConfiguration<Memory>
    {
        public void Configure(EntityTypeBuilder<Memory> builder)
        {
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(d => d.Description)
                .HasMaxLength(250);
        }
    }
}
