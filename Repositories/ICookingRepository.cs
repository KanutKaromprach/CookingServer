using System.Threading.Tasks;
using CookingServer.Models;

namespace CookingServer.Repositories
{
    public interface ICookingRepository
    {
        Task CreateCooking(Cooking cooking);
    }
}