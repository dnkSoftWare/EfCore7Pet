using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.DTOs;
using WebApplication.Entities;

namespace WebApplication.Controllers;

[ApiController]
[Route("api/actors")]
public class ActorController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    public IMapper _mapper { get; }

    public ActorController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> GetActor()
    {
        return await _context.Actors.ToListAsync();
    }
    [HttpGet("name")]
    public async Task<ActionResult<IEnumerable<Actor>>> GetActor(string name)
    {
        return await _context.Actors.Where(x => x.Name.Contains(name)).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult> CreateActor(ActorCreationDTO actorCreationDto)
    {
        var actor = _mapper.Map<Actor>(actorCreationDto);
        await _context.AddAsync(actor);
        await _context.SaveChangesAsync();
        return Ok();
    }
}