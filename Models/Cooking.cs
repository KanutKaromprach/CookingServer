using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CookingServer.Models
{
    public class Cooking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<CookingMaterial> IngredientMeat { get; set; }
        public List<CookingMaterial> IngredientVeg { get; set; }
        public List<CookingMaterial> Seasoning { get; set; }
        public List<CookingMaterial> Noodle { get; set; }
        public int Person { get; set; }
        public bool Status { get; set; }
        public UserProfile UserProfile { get; set ;}
}
}