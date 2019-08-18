using System.Threading.Tasks;
using CookingServer.Models;
using CookingServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace CookingServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookingController : ControllerBase
    {
        private readonly ICookingService _cookingService;
        public CookingController(ICookingService cookingService)
        {
            _cookingService = cookingService;
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<Cooking>> GetCooking(string username)
        {
            var result = await _cookingService.GetCooking(username);
            return Ok(result);
        }


        [ProducesResponseType(201)]
        [HttpPost("create")]
        public async Task<IActionResult> CreateCooking([FromBody]Cooking cooking)
        {
            await _cookingService.CreateCooking(cooking);
            return StatusCode(201);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCooking([FromBody]Cooking cooking)
        {
            await _cookingService.UpdateCooking(cooking);
           return Ok();
        }


    }
}