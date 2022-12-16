using DevTestAPI.DataModels;
using DevTestAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PeopleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Organizations")]
        public async Task<IActionResult> GetOrganizations()
        {
            return Ok(await _context.Organizations.ToListAsync());
        }

        [HttpGet("{OrganizationId}")]
        public async Task<IActionResult> GetPeopleByOrgId(int OrganizationId)
        {
            return Ok(await _context.People
                .Where(p => p.OrganizationId == OrganizationId)
                .Include(p => p.Organization)
                .Include(p => p.PersonEmails)
                .Include(p => p.PersonPhones)
                .Select(p => ConvertPerson(p))
                .ToListAsync());
        }

        private static PersonApi ConvertPerson(Person person)
        {
            return new PersonApi(person);
        }

        [HttpGet]
        public async Task<IActionResult> GetPeople()
        {
            return Ok(await _context.People
                .Include(p => p.Organization)
                .Include(p => p.PersonEmails)
                .Include(p => p.PersonPhones)
                .Select(p => ConvertPerson(p))
                .ToListAsync());
        }
    }
}
