using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using TheSaltyGlutton.Models;

namespace TheSaltyGlutton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationApiController : ControllerBase
    {
        private SaltyContext db;

        public LocationApiController(ISaltyDatabaseSettings settings)
        {
            db = new SaltyContext(settings);
        }

        [HttpGet]
        public ActionResult StatesByCountry(int CountryId)
        {
            PipelineDefinition<State, Object> pipeline = new BsonDocument[]
            {
                new BsonDocument{{"$match", new BsonDocument("CountryId", CountryId)}},
                new BsonDocument{{"$project", 
                        new BsonDocument("_id", 0),
                        new BsonDocument("")
                    }}

            };

            //FilterDefinition<State> filter = new BsonDocument("CountryId", CountryId);
            db.States.FindAsync<State>(State => State.CountryId == CountryId).
        }

    }
}