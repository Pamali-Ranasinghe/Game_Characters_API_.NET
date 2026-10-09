using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Scalar.AspNetCore;
using VIdeoGameCharacterApi.Model;

namespace VIdeoGameCharacterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharacterController : ControllerBase
    {

        static List<Character> characters = new List<Character>
        {
            new Character{Id= 1, Name ="Mario", Game = "SUper Mario", Role = "Hero"},
            new Character{Id= 2, Name ="Link", Game = "The Legend of Zelda", Role = "Hero" },
            new Character{Id= 3, Name ="Bowser", Game = "Super Mario Bros", Role = "Villan"}
        };

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
            => await Task.FromResult(Ok(characters));

    }
}
