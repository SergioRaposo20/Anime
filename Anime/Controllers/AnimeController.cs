using Microsoft.AspNetCore.Mvc;

namespace Anime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        [HttpGet(Name = "teste")]
        public IEnumerable<string> GetAll()
        {
            return "Olá mundo";
        }
    }
}
