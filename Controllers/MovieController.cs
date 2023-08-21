using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.DTOs;
using WebApplication.Entities;

namespace WebApplication.Controllers;

[ApiController]
[Route("api/movies")]
public class MovieController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public MovieController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> CreateMovie(MovieCreationDTO movieCreationDto)
    {
        var movie = _mapper.Map<Movie>(movieCreationDto);
        if (movie is not null)
        {
            foreach (var genre in movie.Genres)
            {
                _context.Entry(genre).State = EntityState.Unchanged;
            }   
        }

        if (movie.MovieActors is not null)
        {
            for (var i = 0; i < movie.MovieActors.Count; i++)
            {
                movie.MovieActors[i].Order = i + 1;
            }
        }

        await _context.AddAsync(movie);
        await _context.SaveChangesAsync();
        return Ok();
    }
    
}