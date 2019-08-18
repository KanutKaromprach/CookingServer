namespace CookingServer.Models
{
    public class CookingDatabaseSettings : ICookingDatabaseSettings
    {
        public string CookingCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICookingDatabaseSettings
    {
        string CookingCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}