using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models
{
    /*
     * The SaltyDatabaseSettings class is used to store the appsettings.json file's SaltyDatabaseSettings property values. 
     * The JSON and C# property names are named identically to ease the mapping process. This class will also be added 
     * to the ConfigureServices method in Startup.cs (as a service obviously). This will allow the developer to refer
     * 
     * The configuration instance to which the appsettings.json file's SaltyDatabaseSettings section binds is registered 
     * in the Dependency Injection (DI) container. For example, a SaltyDatabaseSettings object's ConnectionString property 
     * is populated with the SaltyDatabaseSettings:ConnectionString property in appsettings.json. 
     * 
     * The ISaltyDatabaseSettings interface is registered in DI with a singleton service lifetime. When injected, the 
     * interface instance resolves to a SaltyDatabaseSettings object.
     */

    public class SaltyDatabaseSettings : ISaltyDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CountriesCollectionName { get; set; }
        public string StatesCollectionName { get; set; }
        public string CitiesCollectionName { get; set; }
        public string RestaurantsCollectionName { get; set; }
        public string ReviewsCollectionName { get; set; }
        public string ReviewPicturesCollectionName { get; set; }
        public string UsersCollectionName { get; set; }

    }

    public interface ISaltyDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CountriesCollectionName { get; set; }
        string StatesCollectionName { get; set; }
        string CitiesCollectionName { get; set; }
        string RestaurantsCollectionName { get; set; }
        string ReviewsCollectionName { get; set; }
        string ReviewPicturesCollectionName { get; set; }
        string UsersCollectionName { get; set; }
    }
}
