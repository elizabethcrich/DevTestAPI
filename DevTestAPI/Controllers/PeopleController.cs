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

        [HttpGet]
        public async Task<IActionResult> GetPeople()
        {
            return Ok(await GetPeopleInternal());
        }

        [HttpGet("Organizations")]
        public async Task<IActionResult> GetOrganizations()
        {
            return Ok(await _context.Organizations.ToListAsync());
        }

        [HttpGet("{OrgId}")]
        public async Task<IActionResult> GetPeopleByOrgId(int OrgId)
        {
            var people = await GetPeopleInternal();

            return Ok(people.FindAll(p => p.OrganizationId == OrgId));
        }

        [HttpGet("Search/{OrgId}")]
        public async Task<IActionResult> SearchPeople(
            int OrgId, 
            string? ExtId = null,
            string? FName = null,
            string? LName = null,
            string? Email = null,
            string? Phone = null
            )
        {
            var people = await GetPeopleInternal();

            people = people.FindAll(p => p.OrganizationId == OrgId);

            if (ExtId != null)
                people = people.FindAll(p => p.ExternalPersonId == ExtId);

            if (FName != null)
                people = people.FindAll(p => p.FirstName?.ToLower() == FName.ToLower());

            if (LName != null)
                people = people.FindAll(p => p.LastName?.ToLower() == LName.ToLower());

            if (Email != null)
                people = people.FindAll(p => p.PersonEmails.Any(x => x.Email?.ToLower() == Email.ToLower()));

            if (Phone != null)
                people = people.FindAll(p => p.PersonPhones.Any(x => x.Phone == Phone));

            return Ok(people);
        }

        private async Task<List<PersonApi>> GetPeopleInternal()
        {
            return await _context.People
                .Include(p => p.Organization)
                .Include(p => p.PersonEmails)
                .Include(p => p.PersonPhones)
                .Select(p => ConvertPerson(p))
                .ToListAsync();
        }

        private static PersonApi ConvertPerson(Person person)
        {
            return new PersonApi(person);
        }
    }
}
