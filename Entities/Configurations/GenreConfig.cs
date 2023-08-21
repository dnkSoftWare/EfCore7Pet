using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication.Entities.Configurations;

public class GenreConfig: IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        var scienceFiction = new Genre() { Id = 5, Name = "Science Fiction" };
        var animation = new Genre() { Id = 6, Name = "Animation" };
        builder.HasData(scienceFiction, animation);
    }
}