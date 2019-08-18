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
        public List<CookingDetail> Ingredient { get; set; }
        public List<CookingDetail> Seasoning { get; set; }
        public int Person { get; set ;}
        public bool Status { get; set ;}

    }
}