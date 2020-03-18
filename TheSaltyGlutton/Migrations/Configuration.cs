using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheSaltyGlutton.Models;

namespace TheSaltyGlutton.Migrations
{
    public class Configuration
    {
        private SaltyContext db;

        public Configuration(ISaltyDatabaseSettings settings)
        {
            db = new SaltyContext(settings);
        }

        public void Seed()
        {
            string pathBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations");
            string pathCountries = Path.Combine(pathBase, "countries.json");
            string pathStates = Path.Combine(pathBase, "states.json");
            string pathCitites = Path.Combine(pathBase, "cities.json");

            string jsonCountries = File.ReadAllText(pathCountries);
            JsonConvert.DeserializeObject<List<Country>>(jsonCountries);

            string jsonStates = File.ReadAllText(pathStates);

            string jsonCities = File.ReadAllText(pathCitites);


        }
    }
}
