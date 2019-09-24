using System.Threading.Tasks;
using CookingServer.Models;

namespace CookingServer.Repositories
{
    public interface ICookingRepository
    {
        Task<Cooking> GetCooking(string username);
        Task CreateCooking(Cooking cooking);
        Task UpdateCooking(Cooking cooking);
        Task UpdateProfile(Cooking cooking);
    }
}