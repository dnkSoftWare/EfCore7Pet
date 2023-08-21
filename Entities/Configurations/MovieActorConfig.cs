﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication.Entities.Configurations;

public class MovieActorConfig: IEntityTypeConfiguration<MovieActor>
{
    public void Configure(EntityTypeBuilder<MovieActor> builder)
    {
        builder.HasKey(ma => new { ma.ActorId, ma.MovieId });
    }
}