using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSaltyGlutton.Models;

namespace TheSaltyGlutton.Models
{
    public class SaltyContext 
    {
        public IMongoDatabase Database;

        public SaltyContext(ISaltyDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            Database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<Country> Countries(ISaltyDatabaseSettings settings) =>
            Database.GetCollection<Country>(settings.CountriesCollectionName);
     
        public IMongoCollection<State> States(ISaltyDatabaseSettings settings) =>
            Database.GetCollection<State>(settings.StatesCollectionName);
        
        public IMongoCollection<City> Cities(ISaltyDatabaseSettings settings) =>
            Database.GetCollection<City>(settings.CitiesCollectionName);
        
        public IMongoCollection<Restaurant> Restaurants(ISaltyDatabaseSettings settings) =>
            Database.GetCollection<Restaurant>(settings.RestaurantsCollectionName);
        
        public IMongoCollection<Review> Reviews(ISaltyDatabaseSettings settings) =>
            Database.GetCollection<Review>(settings.ReviewsCollectionName);
    }
}
