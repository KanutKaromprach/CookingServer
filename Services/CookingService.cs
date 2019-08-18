using System.Threading.Tasks;
using CookingServer.Models;
using CookingServer.Repositories;

namespace CookingServer.Services
{
    public class CookingService: ICookingService
    {
        private readonly ICookingRepository _cookingRepository;
        public CookingService(ICookingRepository cookingRepository)
        {
            _cookingRepository = cookingRepository;
        }
        public async Task CreateCooking(Cooking cooking)
        {
            await _cookingRepository.CreateCooking(cooking);
        }
    }
}