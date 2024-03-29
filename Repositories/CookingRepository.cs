using System.Threading.Tasks;
using CookingServer.Models;
using MongoDB.Driver;

namespace CookingServer.Repositories
{
    public class CookingRepository: ICookingRepository
    {
        private readonly IMongoCollection<Cooking> _cooking;
         public CookingRepository(ICookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cooking = database.GetCollection<Cooking>(settings.CookingCollectionName);
        }
        public async Task CreateCooking(Cooking cooking)
        {
            await _cooking.InsertOneAsync(cooking);
        }
    }
}