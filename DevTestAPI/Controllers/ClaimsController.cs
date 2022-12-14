using DevTestAPI.DataModels;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("{PersonId}")]
        public async Task<IActionResult> GetClaimsByPersonId(int PersonId)
        {
            return Ok(await _context.Claims
                .Where(c => c.ExternalPersonId == PersonId)
                .Include(c => c.ClaimFkcodes)
                .ThenInclude(f => f.Fkcode)
                .Include(c => c.ExternalPerson)
                .ToListAsync());
        }

        //[HttpGet]
        //public async Task<IActionResult> GetClaims()
        //{
        //    var claims = await _context.Claims.ToListAsync();
        //    return Ok(claims);
        //}
    }
}
