 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.Core._2_MovieAggregate;

namespace Movie.Infrastructure.Data.Config;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
  public void Configure(EntityTypeBuilder<Tag> builder)
  {
    builder.Property(p => p.Title)
        .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
        .IsRequired();
  }
    
}
