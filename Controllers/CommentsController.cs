using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers;

[ApiController]
[Route("api/movies/{movieId:int}/comments")]
public class CommentsController: ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateComment()
    {
        
        return Ok();
    }
    
}