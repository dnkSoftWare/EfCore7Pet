using AutoMapper;
using WebApplication.DTOs;
using WebApplication.Entities;

namespace WebApplication.Utilities;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<GenreCreationDTO, Genre>();
        CreateMap<ActorCreationDTO, Actor>();
        CreateMap<MovieCreationDTO, Movie>()
            .ForMember(ent => ent.Genres,
                dto => dto.MapFrom(field =>
                    field.Genres.Select(id => new Genre() { Id = id })));
        CreateMap<MovieActorCreationDTO, MovieActor>();
    }
}