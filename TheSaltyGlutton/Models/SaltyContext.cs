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
        private IMongoDatabase _db;
        private ISaltyDatabaseSettings _settings;

        public SaltyContext(ISaltyDatabaseSettings settings)
        {
            IMongoClient client = new MongoClient(settings.ConnectionString);
            _db = client.GetDatabase(settings.DatabaseName);
            _settings = settings;
        }

        public IMongoCollection<Country> Countries =>
            _db.GetCollection<Country>(_settings.CountriesCollectionName);
     
        public IMongoCollection<State> States =>
            _db.GetCollection<State>(_settings.StatesCollectionName);
        
        public IMongoCollection<City> Cities =>
            _db.GetCollection<City>(_settings.CitiesCollectionName);
        
        public IMongoCollection<Restaurant> Restaurants =>
            _db.GetCollection<Restaurant>(_settings.RestaurantsCollectionName);
        
        public IMongoCollection<Review> Reviews =>
            _db.GetCollection<Review>(_settings.ReviewsCollectionName);
    }
}
