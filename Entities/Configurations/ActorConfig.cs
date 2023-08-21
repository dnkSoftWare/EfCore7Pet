using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication.Entities.Configurations;

public class ActorConfig: IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.Property(c=>c.DayOfBirthday).HasColumnType("date");
        builder.Property(c => c.Fortune).HasPrecision(18, 2);
    }
}