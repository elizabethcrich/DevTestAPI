using DevTestAPI.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClaimsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Person")]
        public async Task<IActionResult> GetClaimsByPersonId(int? PersonId = null, string? ExternalPersonId = null)
        {
            return Ok(await _context.Claims
                .Where(c => c.ExternalPersonId == PersonId || c.ExternalPerson.ExternalPersonId == ExternalPersonId)
                .Include(c => c.ClaimFkcodes)
                .ThenInclude(f => f.Fkcode)
                .ToListAsync());
        }
    }
}
