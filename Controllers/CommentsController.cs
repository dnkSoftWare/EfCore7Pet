using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DTOs;
using WebApplication.Entities;

namespace WebApplication.Controllers;

[ApiController]
[Route("api/movies/{movieId:int}/comments")]
public class CommentsController: ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CommentsController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> CreateComment(int movieId, CommentsCreationDTO commentsCreationDto)
    {
        var comment = _mapper.Map<Comment>(commentsCreationDto);
        comment.MovieId = movieId;
        await _context.AddAsync(comment);
        await _context.SaveChangesAsync();
        return Ok();
    }
    
}