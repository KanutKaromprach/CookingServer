using System.Threading.Tasks;
using CookingServer.Models;

namespace CookingServer.Services
{
    public interface ICookingService
    {
        Task CreateCooking(Cooking cooking);
    }
}