using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

    [HttpPost]
    public async Task<ActionResult> CreateActor(ActorCreationDTO actorCreationDto)
    {
        var actor = _mapper.Map<Actor>(actorCreationDto);
        await _context.AddAsync(actor);
        await _context.SaveChangesAsync();
        return Ok();
    }
}