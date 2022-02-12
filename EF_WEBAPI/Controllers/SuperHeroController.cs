using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EF_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        static List<SuperHero> heroes = new List<SuperHero>()
            { new SuperHero(){ FirstName="Sai", LastName="Sherlekar", Id =1 } };
        private readonly DataContext context;

        // GET: api/<SuperHeroController>

        public SuperHeroController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var heroes1 = await this.context.SuperHeroes.ToListAsync();
            return  Ok(heroes1);
        }
        [HttpPost]
        public async Task<IActionResult> Add(SuperHero myhero)
        {
            this.context.SuperHeroes.Add(myhero);
            await this.context.SaveChangesAsync();
            return Ok(heroes);  
        }

    }
}
