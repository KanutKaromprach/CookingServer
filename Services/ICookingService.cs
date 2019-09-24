using System.Threading.Tasks;
using CookingServer.Models;

namespace CookingServer.Services
{
    public interface ICookingService
    {
        Task<Cooking> GetCooking(string username);
        Task CreateCooking(Cooking cooking);
        Task UpdateCooking(Cooking cooking);
        Task UpdateProfile(Cooking cooking);
    }
}