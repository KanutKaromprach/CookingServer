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

        [ProducesResponseType(201)]
        [HttpPost()]
        public async Task<IActionResult> CreateCooking([FromBody]Cooking cooking)
        {
            await _cookingService.CreateCooking(cooking);
            return StatusCode(201);
        }


    }
}