using System.Collections.Generic;

namespace CookingServer.Models
{
    public class CookingDetail
    {
        public string status { get; set; }
        public List<CookingMaterial> cookingMaterial { get; set; }

    }
}