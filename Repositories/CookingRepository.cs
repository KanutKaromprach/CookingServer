using System.Threading.Tasks;
using CookingServer.Models;
using MongoDB.Driver;

namespace CookingServer.Repositories
{
    public class CookingRepository : ICookingRepository
    {
        private readonly IMongoCollection<Cooking> _cooking;
        public CookingRepository(ICookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cooking = database.GetCollection<Cooking>(settings.CookingCollectionName);
        }
        public async Task<Cooking> GetCooking(string username)
        {
            var result = await _cooking.Find(o => o.Username == username).SingleOrDefaultAsync();
            return result;
        }
        public async Task CreateCooking(Cooking cooking)
        {
            await _cooking.InsertOneAsync(cooking);
        }

        public async Task UpdateCooking(Cooking cooking)
        {
            var filter = Builders<Cooking>.Filter.Eq("Username", cooking.Username);
            var update = Builders<Cooking>.Update
                .Set(o => o.IngredientMeat, cooking.IngredientMeat)
                .Set(o => o.IngredientVeg, cooking.IngredientVeg)
                .Set(o => o.Seasoning, cooking.Seasoning)
                .Set(o => o.Person, cooking.Person);
            await _cooking.UpdateOneAsync(filter, update);
        }
    }
}