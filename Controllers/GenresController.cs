using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DTOs;
using WebApplication.Entities;

namespace WebApplication.Controllers;

[ApiController]
[Route("api/genres")]
public class GenresController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GenresController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> Post(GenreCreationDTO genreDTO)
    {
        var genre = _mapper.Map<Genre>(genreDTO);
        await _context.AddAsync(genre);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpPost("several")]
    public async Task<ActionResult> Post(GenreCreationDTO[] genreDTO)
    {
        var genres = _mapper.Map<Genre[]>(genreDTO);
        await _context.AddRangeAsync(genres);
        await _context.SaveChangesAsync();
        return Ok();
    }

}