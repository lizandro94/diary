using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diary.Persistence.Configurations
{
    class DiaryConfiguration : IEntityTypeConfiguration<Domain.Entities.Diary>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Diary> builder)
        {
            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(d => d.Description)
                .HasMaxLength(250);

            builder.Property(d => d.UserId)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
