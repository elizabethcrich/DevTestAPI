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
            return Ok(await _context.People.Select(p => ConvertPerson(p)).ToListAsync());
        }

        private static PersonApi ConvertPerson(Person person)
        {
            return new PersonApi(person);
        }
    }
}
